namespace CSharpCollections;

public class AulaListas
{
    public static void main()
    {
        var alunos = new List<string>() { "Janio", "Saulo", "West", "Judson", "Newton" };
        Console.WriteLine(alunos.Count);
        Console.WriteLine(alunos.Capacity);
        imprimir(alunos);

        // alunos.Clear();
        Console.WriteLine(alunos.IndexOf("Janio"));
        alunos.Remove("Newton");
        Console.WriteLine(alunos.Contains("Janio"));
        imprimir(alunos);
    }
    
    private static void imprimir(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}