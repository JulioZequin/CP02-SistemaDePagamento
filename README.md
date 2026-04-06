<h1 align="center">💳 Sistema de Simulação de Pagamentos</h1>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C# Badge">
  <img src="https://img.shields.io/badge/.NET_8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Badge">
  <img src="https://img.shields.io/badge/Visual_Studio_2022-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white" alt="VS 2022 Badge">
</p>

<hr>

<h2>👥 Integrantes do Grupo</h2>
<ul>
    <li><strong>Nome 1</strong> - RM XXXXX</li>
    <li><strong>Nome 2</strong> - RM XXXXX</li>
    <li><strong>Nome 3</strong> - RM XXXXX</li>
    <li><strong>Nome 4</strong> - RM XXXXX</li>
    <li><strong>Nome 5</strong> - RM XXXXX</li>
</ul>

<hr>

<h2>📌 Sobre o Projeto</h2>
<p>
    Este projeto consiste em uma aplicação de console desenvolvida em C# para simular um sistema de processamento de pagamentos. 
    A solução foi arquitetada focando nos princípios de <strong>Programação Orientada a Objetos (POO)</strong>, garantindo extensibilidade e organização.
</p>

<h3>🚀 Funcionalidades</h3>
<ul>
    <li>Menu interativo via classe estática.</li>
    <li>Processamento de pagamento via Cartão de Crédito.</li>
    <li>Processamento de pagamento via Boleto Bancário.</li>
    <li>Tratamento de entradas numéricas para valores monetários.</li>
</ul>

<hr>

<h2>🏗️ Arquitetura e POO</h2>
<p>Para atender aos critérios técnicos, aplicamos os seguintes conceitos:</p>
<ul>
    <li><strong>Abstração e Herança:</strong> Criamos uma classe base <code>Pagamento</code> que contém as propriedades comuns (Valor, Data) e o método abstrato <code>ProcessarPagamento()</code>.</li>
    <li><strong>Polimorfismo:</strong> As classes filhas <code>PagamentoCartao</code> e <code>PagamentoBoleto</code> sobrescrevem o método de processamento para exibir mensagens específicas de cada contexto.</li>
    <li><strong>Encapsulamento:</strong> Uso de propriedades com <i>getters</i> e <i>setters</i>.</li>
    <li><strong>Classes Estáticas:</strong> Implementação da classe <code>Menu</code> para gerenciar a interface com o usuário sem necessidade de instanciar objetos de navegação.</li>
</ul>

<h3>📁 Estrutura de Pastas</h3>
<pre>
/SistemaPagamento
│
├── /Models
│   ├── Pagamento.cs (Classe Base)
│   ├── PagamentoCartao.cs
│   ├── PagamentoBoleto.cs
│   └── Menu.cs (Classe Estática)
│
└── Program.cs (Ponto de entrada)
</pre>

<hr>

<h2>📸 Evidências de Testes</h2>
<p>Abaixo está a captura de tela demonstrando o funcionamento do sistema:</p>

<img width="1279" height="582" alt="image" src="https://github.com/user-attachments/assets/cb677249-d942-4564-af5b-e89def9331f3" />


<hr>

<h2>🛠️ Como executar</h2>
<ol>
    <li>Clone o repositório.</li>
    <li>Abra o projeto no Visual Studio 2022.</li>
    <li>Pressione <code>F5</code> para compilar e executar.</li>
</ol>
