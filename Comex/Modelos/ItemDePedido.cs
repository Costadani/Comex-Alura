using Comex.Modelos;


namespace Comex.Models;
internal class ItemDePedido
{
    public Produto Produto { get; set; }

    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Subtotal => Quantidade * PrecoUnitario;

    public void DetalharItem()
    {
        Console.WriteLine($"  {Produto.Nome} - {Quantidade}x R${PrecoUnitario} Subtotal: R${Subtotal}");
    }
}