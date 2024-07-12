# COMEX

## Descrição

COMEX é um programa de console simples em C# para gerenciar uma lista de produtos. Ele permite ao usuário adicionar novos produtos e listar os produtos registrados. O programa exibe um menu com opções e interage com o usuário através de entradas de console.

## Funcionalidades

- **Exibir Logo**: Exibe um logo estilizado ao iniciar o programa.
- **Exibir Menu de Opções**: Mostra as opções disponíveis para o usuário, incluindo criar produto, listar produtos e sair do programa.
- **Criar Produto**: Permite ao usuário adicionar novos produtos à lista.
- **Listar Produtos**: Exibe todos os produtos registrados na lista.

## Estrutura do Código

- `string mensagemDeBoasVindas`: Armazena a mensagem de boas-vindas do programa.
- `List<string> ListaDeProdutos`: Lista para armazenar os produtos registrados.
- `void exibirLogo()`: Função que exibe o logo do programa.
- `void exibirOpcoesDoMenu()`: Função que exibe o menu de opções e trata a entrada do usuário.
- `void ListarProdutos()`: Função que lista todos os produtos registrados.
- `void criarProduto()`: Função que permite o registro de novos produtos.

## Fluxo do Programa

1. O programa inicia exibindo o logo e o menu de opções.
2. O usuário escolhe uma opção digitando o número correspondente.
   - Opção 1: Criar Produto.
     - O usuário digita o nome do produto, que é adicionado à lista e uma mensagem de confirmação é exibida.
   - Opção 2: Listar Produtos.
     - O programa exibe todos os produtos registrados.
   - Opção -1: Sair.
     - O programa exibe uma mensagem de saída e termina a execução.
   - Qualquer outra opção: Exibe uma mensagem de opção inválida.

## Como Executar

1. Clone o repositório ou copie o código para seu ambiente de desenvolvimento C#.
2. Compile e execute o programa.
3. Interaja com o menu exibido no console para criar e listar produtos.


