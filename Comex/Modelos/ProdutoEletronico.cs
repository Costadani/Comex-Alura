namespace Comex.Modelos;

internal class ProdutoEletronico : Produto
{
    public int voltagem { get; set; }
    public int potencia { get; set; }
    public ProdutoEletronico(string nome) : base(nome) { }


}





