using System;

class Aluno
{
    public int Matricula;
    public string Nome = "";
    public double NotaProva1;
    public double NotaProva2;
    public double NotaTrabalho;

    public double media()
    {
        return (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7;
    }

    public double final()
    {
        double mediaAtual = media();

        if (mediaAtual < 60)
        {
            return 120 - mediaAtual;
        }

        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Digite a matrícula do aluno: ");
        aluno.Matricula = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine() ?? "";

        Console.WriteLine("Digite a nota da primeira prova: ");
        aluno.NotaProva1 = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Digite a nota da segunda prova: ");
        aluno.NotaProva2 = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Digite a nota do trabalho: ");
        aluno.NotaTrabalho = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"Matrícula: {aluno.Matricula}");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"Média: {aluno.media():F2}");

        double notaFinal = aluno.final();

        if (notaFinal > 0)
        {
            Console.WriteLine($"Nota necessária na prova final: {notaFinal:F2}");
        }
        else
        {
            Console.WriteLine("O aluno não precisa fazer a prova final.");
        }
    }
}
