
string mensagemDeBoasVindas = "Boas vindas ao  COMEX!!!";

List<string> ListaDeProdutos = new List<string>();
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
    Console.WriteLine("\nDigite 1 para criar produto");
    Console.WriteLine("\nDigite 2 para listar produtos");
    Console.WriteLine("\nDigite -1 para sair");

    Console.WriteLine("\nDigite a sua opção:");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            criarProduto();
            break;
            case 2: ListarProdutos();

            break;
        case -1:
            Console.WriteLine("saindo do programa...");
            break;

        default:
            Console.WriteLine("opção inválida");
            break;

    }
}
void ListarProdutos()
{
    Console.Clear();
    foreach(var produtos in ListaDeProdutos)
    {

    Console.WriteLine("Produto: "+produtos); }
}
    


void criarProduto()
{
    Console.Clear();
    Console.WriteLine("Registro de protuto");

    Console.Write("digite o nome do produto: ");
    string produto = Console.ReadLine();

    ListaDeProdutos.Add(produto);
    Console.WriteLine($"O produto {produto} foi registrado com sucesso!");
    Console.WriteLine("\nDigite uma recla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();


}

exibirOpcoesDoMenu();