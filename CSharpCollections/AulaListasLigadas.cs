namespace CSharpCollections;

public class AulaListasLigadas
{
    public static void main()
    {
        var listaLigada = new LinkedList<string>();

        var node1 = listaLigada.AddFirst("Primeira posição");

        var node2 = listaLigada.AddAfter(node1, "Segunda posição");

        var node3 = listaLigada.AddBefore(node2, "Terceira posição");

        var node4 = listaLigada.AddLast("Quarta posição");

        imprimir(listaLigada);

        Console.WriteLine("----------------------------------------");

        listaLigada.RemoveFirst();
        imprimir(listaLigada);

        Console.WriteLine("----------------------------------------");

        listaLigada.RemoveLast();
        imprimir(listaLigada);

        Console.WriteLine("----------------------------------------");

        listaLigada.Remove("Terceira posição");
        imprimir(listaLigada);

        Console.WriteLine("----------------------------------------");

        Console.WriteLine(listaLigada.Contains("Primeira posição"));

        Console.WriteLine("----------------------------------------");

        Console.WriteLine(listaLigada.Find("Segunda posição")?.Value);
    }

    private static void imprimir(LinkedList<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}