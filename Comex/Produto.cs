 class Produto
{
    public string Nome { get; }
    public string Descricao { get; set; }
    public float PrecoUnitario { get; }
    public int Quantidade { get; set; }

    public Produto(string nome)
    {
        Nome = nome;
    }
}
