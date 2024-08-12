using Comex.Menus;
using Comex.Modelos;

internal class MenuListarProdutos : Menu
{
    public override void Executar(List<Produto> ListaDeProdutos)
    {
        base.Executar(ListaDeProdutos);
        ExibirTituloDaOpcao("Lista de Produtos");
        foreach (var produtos in ListaDeProdutos)
        {

            Console.WriteLine($"Produto: {produtos.Nome} | Preço: R$ {produtos.PrecoUnitario}");
        }

        FinalizarMenu();

    }
}