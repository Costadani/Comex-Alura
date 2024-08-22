using Comex.Menus;
using Comex.Modelos;
using Comex.Models;

internal class MenuListarCliente : Menu
{
    public List<Cliente> Clientes;

    public MenuListarCliente(List<Cliente> clientes)
    {
        Clientes = clientes;
    }

    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);

        ExibirTituloDaOpcao("Listar Clientes");

        foreach (var cliente in Clientes)
        {
            Console.WriteLine(cliente.Identificar());
        }

        FinalizarMenu();
    }
}