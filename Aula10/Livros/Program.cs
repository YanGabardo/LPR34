using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}

class Biblioteca
{
    private readonly List<Livro> _livros = new();

    public void AdicionarLivro(Livro livro)
    {
        ArgumentNullException.ThrowIfNull(livro);
        _livros.Add(livro);
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros da biblioteca:");

        if (_livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }

        foreach (Livro livro in _livros)
        {
            Console.WriteLine($"{livro.Titulo} - {livro.Autor} ({livro.AnoPublicacao})");
        }
    }
}

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new();

        Livro livro1 = new("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro2 = new("O Guarani", "José de Alencar", 1857);

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);

        biblioteca.ListarLivros();
    }
}
