namespace CSharpCollections;

public class AulaArrays
{
    public static void main()
    {
        var alunos = new string[] { "Janio", "Saulo", "West", "Judson", "Newton" };
        
        Console.WriteLine(Array.IndexOf(alunos, "Janio"));

        // Array.Reverse(alunos);
        // Array.Resize(ref alunos, 10);

        /*
        alunos[0] = "Janio";
        alunos[1] = "Saulo";
        alunos[2] = "West";
        alunos[3] = "Judson";
        alunos[4] = "Newton";
        */

        imprimir(alunos);
    }
    
    private static void imprimir(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}