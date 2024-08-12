namespace Comex.Modelos;
internal class Produto
{

    public string Nome { get; }
    public string Descricao { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome)
    {
        Nome = nome;
    }
}
