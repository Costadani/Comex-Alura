namespace Comex.Menus;
using Comex.Modelos;

internal class Menu
{
    public virtual void Executar(List<Produto> produtos)
    {
        Console.Clear();   
    }
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '=');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public void FinalizarMenu() 
    {
        Console.WriteLine("\nDigite uma Tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

}
