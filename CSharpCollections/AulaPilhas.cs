namespace CSharpCollections;

public class AulaPilhas
{
    public static void main()
    {
        var pilha = new Stack<string>();

        pilha.Push("Introdução ao C#");

        pilha.Push("Orientação a Objetos com C#");

        pilha.Push("Introdução ao ASP.NET");

        pilha.Pop();

        imprimir(pilha);
    }
    
    private static void imprimir(Stack<string> pilha)
    {
        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
    } 
}