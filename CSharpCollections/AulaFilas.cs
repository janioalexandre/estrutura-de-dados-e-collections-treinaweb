namespace CSharpCollections;

public class AulaFilas
{
    public static void main()
    {
        var fila = new Queue<string>();

        fila.Enqueue("Janio");

        fila.Enqueue("Alexandre");

        fila.Enqueue("Ribeiro");

        fila.Dequeue();

        imprimir(fila);
    }

    private static void imprimir(Queue<string> fila)
    {
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
    }
}