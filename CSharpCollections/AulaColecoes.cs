namespace CSharpCollections;

public class AulaColecoes
{
    public static void main()
    {
        var alunos = new HashSet<Aluno>();
        alunos.Add(new Aluno("Janio", "Alexandre"));
        alunos.Add(new Aluno("Saulo", "Regis"));
        imprimir(alunos);

        Console.WriteLine(new Aluno("Ênio", "Maxson").GetHashCode());
        Console.WriteLine(new Aluno("Newton", "Borges").GetHashCode());
    }
    
    private static void imprimir(HashSet<Aluno> set)
    {
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}

public class Aluno
{
    public Aluno(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public override string ToString()
    {
        return $"{Nome} {Sobrenome}";
    }
}