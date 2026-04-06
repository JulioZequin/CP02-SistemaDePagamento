using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento.Models
{
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de {Valor:C} via Cartão (Número: {NumeroCartao}) na data {Data:dd/MM/yyyy}.";
        }
    }
}
