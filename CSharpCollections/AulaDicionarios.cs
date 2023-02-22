public class AulaDicionarios
{
    public static void main()
    {
        var alunos = new Dictionary<string, string>();

        alunos["123"] = "Janio";
        alunos["321"] = "Alexandre";

        imprimir(alunos);

        Console.WriteLine(alunos.FirstOrDefault(aluno => aluno.Key == "123").Value);
    }

    private static void imprimir(Dictionary<string, string> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}