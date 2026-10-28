using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    private readonly List<Matricula> _matriculas = new();

    public string Nome { get; set; }
    public IReadOnlyList<Matricula> Matriculas => _matriculas.AsReadOnly();

    public Aluno(string nome)
    {
        Nome = nome;
    }

    public bool AdicionarMatricula(Turma turma, DateTime? dataMatricula = null)
    {
        ArgumentNullException.ThrowIfNull(turma);
        return Matricula.Registrar(this, turma, dataMatricula ?? DateTime.Today);
    }

    internal bool JaMatriculadoEm(Turma turma)
    {
        return _matriculas.Any(matricula => matricula.Turma == turma);
    }

    internal void AdicionarMatriculaInterna(Matricula matricula)
    {
        _matriculas.Add(matricula);
    }
}

class Turma
{
    private readonly List<Matricula> _matriculas = new();

    public string Nome { get; set; }
    public IReadOnlyList<Matricula> Matriculas => _matriculas.AsReadOnly();

    public Turma(string nome)
    {
        Nome = nome;
    }

    public bool AdicionarMatricula(Aluno aluno, DateTime? dataMatricula = null)
    {
        ArgumentNullException.ThrowIfNull(aluno);
        return Matricula.Registrar(aluno, this, dataMatricula ?? DateTime.Today);
    }

    public IReadOnlyList<Aluno> ObterAlunosMatriculados()
    {
        return _matriculas.Select(matricula => matricula.Aluno).ToList();
    }

    internal bool JaMatriculado(Aluno aluno)
    {
        return _matriculas.Any(matricula => matricula.Aluno == aluno);
    }

    internal void AdicionarMatriculaInterna(Matricula matricula)
    {
        _matriculas.Add(matricula);
    }
}

class Matricula
{
    public Aluno Aluno { get; }
    public Turma Turma { get; }
    public DateTime DataMatricula { get; }

    private Matricula(Aluno aluno, Turma turma, DateTime dataMatricula)
    {
        Aluno = aluno;
        Turma = turma;
        DataMatricula = dataMatricula;
    }

    internal static bool Registrar(Aluno aluno, Turma turma, DateTime dataMatricula)
    {
        if (aluno.JaMatriculadoEm(turma) || turma.JaMatriculado(aluno))
        {
            return false;
        }

        Matricula matricula = new(aluno, turma, dataMatricula);
        aluno.AdicionarMatriculaInterna(matricula);
        turma.AdicionarMatriculaInterna(matricula);
        return true;
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno1 = new("Mariana");
        Aluno aluno2 = new("Lucas");

        Turma turma1 = new("Programação");
        Turma turma2 = new("Banco de Dados");

        aluno1.AdicionarMatricula(turma1, new DateTime(2026, 10, 28));
        aluno1.AdicionarMatricula(turma2, new DateTime(2026, 10, 28));
        turma1.AdicionarMatricula(aluno2, new DateTime(2026, 10, 28));

        bool matriculaDuplicada = aluno1.AdicionarMatricula(turma1);
        Console.WriteLine(matriculaDuplicada
            ? "Matrícula realizada."
            : $"{aluno1.Nome} já está matriculado em {turma1.Nome}.");

        Console.WriteLine($"\nAlunos matriculados em {turma1.Nome}:");
        foreach (Aluno aluno in turma1.ObterAlunosMatriculados())
        {
            Console.WriteLine($"- {aluno.Nome}");
        }

        Console.WriteLine($"\nData da matrícula de {aluno1.Nome} em {turma1.Nome}: " +
                          $"{aluno1.Matriculas[0].DataMatricula:dd/MM/yyyy}");
    }
}
