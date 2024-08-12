using Comex.Modelos;

namespace Comex.Menus;

internal class MenuListarPorNome : Menu
{
    public override void Executar(List<Produto> ListaDeProdutos)
    {
        base.Executar(ListaDeProdutos);
        ExibirTituloDaOpcao("Produtos Ordenados Por Nome");

        var listaOrdenada = ListaDeProdutos.OrderBy(p => p.Nome).ToList();
        foreach (var item in listaOrdenada)
        {
            Console.WriteLine($"Produto: {item.Nome} | Preço: R$ {item.PrecoUnitario}");
        }
        FinalizarMenu();
    }

}
