using System;
using System.Collections.Generic;

class Program
{
    // definicao da struct livro
    struct Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public int QntDisponivel;
    }

    // dicionario global para armazenar os livros (chave: codigo, valor: struct livro)
    static Dictionary<int, Livro> acervo = new Dictionary<int, Livro>();

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n Menu de opcoes:");
            Console.WriteLine("1 Cadastrar livro");
            Console.WriteLine("2 Buscar livro");
            Console.WriteLine("3 Emprestar livro");
            Console.WriteLine("4 Exibir relatorio");
            Console.WriteLine("5 Sair");
            Console.Write("Escolha uma opcao ");
            
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CadastrarLivro();
                        break;
                    case 2:
                        BuscarLivro();
                        break;
                    case 3:
                        EmprestarLivro();
                        break;
                    case 4:
                        ExibirRelatorio();
                        break;
                    case 5:
                        Console.WriteLine("saindo do programa");
                        break;
                    default:
                        Console.WriteLine("opcao invalida");
                        break;
                }
            }
            else
            {
                opcao = 0;
                Console.WriteLine("opcao invalida");
            }

        } while (opcao != 5);
    }

    // 1 funcao para cadastrar livro
    static void CadastrarLivro()
    {
        Console.Write("digite o codigo do livro ");
        if (!int.TryParse(Console.ReadLine(), out int codigo))
        {
            Console.WriteLine("codigo invalido");
            return;
        }

        if (acervo.ContainsKey(codigo))
        {
            Console.WriteLine("esse codigo ja esta cadastrado");
            return;
        }

        Livro novoLivro;
        Console.Write("digite o titulo ");
        novoLivro.Titulo = Console.ReadLine();

        Console.Write("digite o autor ");
        novoLivro.Autor = Console.ReadLine();

        Console.Write("digite o ano de publicacao ");
        int.TryParse(Console.ReadLine(), out novoLivro.AnoPublicacao);

        Console.Write("digite a quantidade disponivel ");
        int.TryParse(Console.ReadLine(), out novoLivro.QntDisponivel);

        acervo.Add(codigo, novoLivro);
        Console.WriteLine("livro cadastrado com sucesso");
    }

    // 2 funcao para buscar livro pelo codigo
    static void BuscarLivro()
    {
        Console.Write("digite o codigo do livro para buscar ");
        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            if (acervo.TryGetValue(codigo, out Livro livro))
            {
                Console.WriteLine("livro encontrado");
                Console.WriteLine($"titulo {livro.Titulo}");
                Console.WriteLine($"autor {livro.Autor}");
                Console.WriteLine($"ano {livro.AnoPublicacao}");
                Console.WriteLine($"disponivel {livro.QntDisponivel}");
            }
            else
            {
                Console.WriteLine("livro nao encontrado");
            }
        }
        else
        {
            Console.WriteLine("codigo invalido");
        }
    }

    // 3 funcao para emprestar livro (reduz a quantidade)
    static void EmprestarLivro()
    {
        Console.Write("digite o codigo do livro para emprestimo ");
        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            if (acervo.ContainsKey(codigo))
            {
                Livro livro = acervo[codigo];

                if (livro.QntDisponivel > 0)
                {
                    livro.QntDisponivel--; // reduz a quantidade
                    acervo[codigo] = livro; // atualiza a struct no dicionario
                    Console.WriteLine("emprestimo realizado com sucesso");
                }
                else
                {
                    Console.WriteLine("nao ha exemplares disponiveis para emprestimo");
                }
            }
            else
            {
                Console.WriteLine("livro nao encontrado");
            }
        }
        else
        {
            Console.WriteLine("codigo invalido");
        }
    }

    // 4 funcao para exibir o relatorio completo e contagem por autor
    static void ExibirRelatorio()
    {
        if (acervo.Count == 0)
        {
            Console.WriteLine("nenhum livro cadastrado no sistema");
            return;
        }

        int totalLivros = acervo.Count;
        
        string tituloMaisAntigo = "";
        int anoMaisAntigo = int.MaxValue;

        string tituloMaiorQuantidade = "";
        int maiorQuantidade = int.MinValue;

        // dicionario auxiliar para contar livros por autor
        Dictionary<string, int> livrosPorAutor = new Dictionary<string, int>();

        foreach (var par in acervo)
        {
            Livro livro = par.Value;

            // verifica o mais antigo
            if (livro.AnoPublicacao < anoMaisAntigo)
            {
                anoMaisAntigo = livro.AnoPublicacao;
                tituloMaisAntigo = livro.Titulo;
            }

            // verifica o que tem maior quantidade
            if (livro.QntDisponivel > maiorQuantidade)
            {
                maiorQuantidade = livro.QntDisponivel;
                tituloMaiorQuantidade = livro.Titulo;
            }

            // contabiliza livros por autor
            if (livrosPorAutor.ContainsKey(livro.Autor))
            {
                livrosPorAutor[livro.Autor]++;
            }
            else
            {
                livrosPorAutor.Add(livro.Autor, 1);
            }
        }

        Console.WriteLine("\n--- relatorio geral ---");
        Console.WriteLine($"total de livros cadastrados {totalLivros}");
        Console.WriteLine($"livro mais antigo {tituloMaisAntigo} ano {anoMaisAntigo}");
        Console.WriteLine($"livro com maior quantidade {tituloMaiorQuantidade} quantidade {maiorQuantidade}");

        Console.WriteLine("\n--- quantidade de livros por autor ---");
        foreach (var par in livrosPorAutor)
        {
            Console.WriteLine($"autor {par.Key} possui {par.Value} livros cadastrados");
        }
    }
}