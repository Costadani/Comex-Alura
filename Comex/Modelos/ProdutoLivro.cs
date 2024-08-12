namespace Comex.Modelos;

internal class ProdutoLivro : Produto, IIdentificar
{
    public string Isbn { get; set; }
    public int TotalDePaginas { get; set; }
    public ProdutoLivro(string nome) : base(nome) { }

    public string Identificar()
    {
        return $"{Nome} - {Isbn}";
    }

}
