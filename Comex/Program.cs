using Comex.Modelos;
using Comex.Menus;
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
opcoes.Add(1, new MenuCadastrarProduto());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(3, new MenuListarPorNome());
opcoes.Add(4, new MenuListarPorPreco());
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

void exibirOpcoesDoMenu()
{
    exibirLogo();
    Console.WriteLine("\nDigite 1 - para criar produto.");
    Console.WriteLine("Digite 2 - para listar produtos.");
    Console.WriteLine("Digite 3 - para listar produtos ordenados por nome.");
    Console.WriteLine("Digite 4 - para listar produtos ordenados por preço.");
    Console.WriteLine("\n\nDigite -1 para sair");

    Console.Write("\nDigite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida!);

    if (opcaoEscolhidaNumerica > 0)
    {
        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(ListaDeProdutos);
        exibirOpcoesDoMenu();
    }
}





exibirOpcoesDoMenu();