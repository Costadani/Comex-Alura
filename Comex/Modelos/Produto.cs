using System.Text.Json;
using System.Text.Json.Serialization;

namespace Comex.Modelos;
internal class Produto
{

    [JsonPropertyName("title")]
    public string Nome { get; }


    [JsonPropertyName("description")]
    public string Descricao { get; set; }

    [JsonPropertyName("price")]
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome)
    {
        Nome = nome;
    }
}
