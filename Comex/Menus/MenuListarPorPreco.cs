using Comex.Modelos;

namespace Comex.Menus;

internal class MenuListarPorPreco : Menu
{
    public override void Executar(List<Produto> ListaDeProdutos)
    {
        base.Executar(ListaDeProdutos);
        ExibirTituloDaOpcao("Produtos Ordenados Por Preço");
        var listaOrdenada = ListaDeProdutos.OrderBy(p => p.PrecoUnitario).ToList();
        foreach (var item in listaOrdenada)
        {
            Console.WriteLine($"Produto: {item.Nome} | Preço: R$ {item.PrecoUnitario}");
        }
        FinalizarMenu();
    }

}
