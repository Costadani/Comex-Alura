namespace Comex.Menus;
using Comex.Modelos;
using System;

internal class MenuCadastrarProduto:Menu
{
    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);
        ExibirTituloDaOpcao("Cadastrar Produto");
        

        Console.Write("Digite o nome do produto: ");
        string produto = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        string preco = Console.ReadLine();
        decimal precoConvertido = decimal.Parse(preco);
        
        produtos.Add(new Produto(produto) { PrecoUnitario = precoConvertido});
        
        Console.WriteLine($"O produto {produto} foi registrado com sucesso!");

        FinalizarMenu();
    }
}
