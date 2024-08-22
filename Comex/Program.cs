using Comex.Modelos;
using Comex.Menus;
using Comex.Models;
string mensagemDeBoasVindas = "Boas vindas ao  COMEX!!!";

List<Produto> ListaDeProdutos = new List<Produto>()
{
            new Produto("Arroz") { PrecoUnitario = 8.75m, Quantidade = 20 },
            new Produto("Feijão") { PrecoUnitario = 7.50m, Quantidade = 15 },
            new Produto("Macarrão") { PrecoUnitario = 4.30m, Quantidade = 30 },
            new Produto("Azeite") { PrecoUnitario = 18.90m, Quantidade = 10 },
            new Produto("Sal") { PrecoUnitario = 2.50m, Quantidade = 50 },
            new Produto("Açúcar") { PrecoUnitario = 3.80m, Quantidade = 25 },
            new Produto("Café") { PrecoUnitario = 14.00m, Quantidade = 12 },
            new Produto("Leite") { PrecoUnitario = 4.50m, Quantidade = 40 },
            new Produto("Manteiga") { PrecoUnitario = 9.20m, Quantidade = 8 },
            new Produto("Farinha") { PrecoUnitario = 6.60m, Quantidade = 20 }
};
Dictionary<int, Menu> opcoes = new();

List<Cliente> clientes = new() {
   new Cliente("Carlos Daniel"){CPF = "000.000.000-01"},
   new Cliente("Emilly"){CPF = "000.000.000-02"}
};
List<Pedido> pedidos = new() {
    new Pedido(clientes[1]){Numero = 1001, Data = DateTime.Now},
    new Pedido(clientes[0]){Numero = 1000, Data = DateTime.Now}

};

opcoes.Add(1, new MenuCadastrarProduto());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(3, new MenuListarPorNome());
opcoes.Add(4, new MenuListarPorPreco());
opcoes.Add(5, new MenuConsultarAPI());
opcoes.Add(6, new MenuCadastrarCliente(clientes));
opcoes.Add(7, new MenuListarCliente(clientes));
opcoes.Add(8, new MenuCadastrarPedido(pedidos, clientes));
opcoes.Add(9, new MenuListarPedido(pedidos));
opcoes.Add(10, new MenuAdicionarItem(pedidos));

void exibirLogo()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");
}

async Task exibirOpcoesDoMenu()
{
    exibirLogo();
    Console.WriteLine("\nDigite 1 - para criar produto.");
    Console.WriteLine("Digite 2 - para listar produtos.");
    Console.WriteLine("Digite 3 - para listar produtos ordenados por nome.");
    Console.WriteLine("Digite 4 - para listar produtos ordenados por preço.");
    Console.WriteLine("Digite 5 - para consultar api externa.");
    Console.WriteLine("Digite 6 - para cadastrar um cliente.");
    Console.WriteLine("Digite 7 - Para ver a lista de Clientes");
    Console.WriteLine("Digite 8 - Para cadastrar pedido");
    Console.WriteLine("Digite 9 - Adicionar item ao pedido");
    Console.WriteLine("Digite 10 - Para ver a lista de pedidos");
    Console.WriteLine("\n\nDigite -1 para sair");

    Console.Write("\nDigite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida!);

    if (opcaoEscolhidaNumerica > 0)
    {

        if (opcaoEscolhidaNumerica == 5)
        {
            await new MenuConsultarAPI().Executar();
            await exibirOpcoesDoMenu();
        }
        else
        {
            Menu menu = opcoes[opcaoEscolhidaNumerica];
            menu.Executar(ListaDeProdutos);
            await exibirOpcoesDoMenu();
        }
    }




}
await exibirOpcoesDoMenu();