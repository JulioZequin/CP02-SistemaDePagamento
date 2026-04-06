using SistemaPagamento.Models;
using System.Globalization;

bool continuar = true;

while (continuar)
{
    Menu.ExibirMenu();
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ProcessarFluxoCartao();
            break;
        case "2":
            ProcessarFluxoBoleto();
            break;
        case "3":
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void ProcessarFluxoCartao()
{
    var p = new PagamentoCartao();
    p.Valor = LerValor();
    Console.Write("Informe o número do cartão: ");
    p.NumeroCartao = Console.ReadLine();
    Console.WriteLine(p.ProcessarPagamento());
}

void ProcessarFluxoBoleto()
{
    var p = new PagamentoBoleto();
    p.Valor = LerValor();
    Console.Write("Informe o código de barras: ");
    p.CodigoBarras = Console.ReadLine();
    Console.WriteLine(p.ProcessarPagamento());
}

decimal LerValor()
{
    Console.Write("Valor do pagamento: ");
    // Garante aceitação de diferentes formatos (. ou ,)
    decimal.TryParse(Console.ReadLine().Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal resultado);
    return resultado;
}