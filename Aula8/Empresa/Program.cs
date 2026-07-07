using System;
using System.Linq;

struct Chamado
{
    public int Numero;
    public string Solicitante;
    public int Setor;
    public int Prioridade;
    public string Status;
    public string Descricao;
}

class Program
{
    static void cadastrarChamado(Chamado[] chamados, ref int quantidade)
    {
        if (quantidade >= 10)
        {
            Console.WriteLine("Limite de chamados atingido!");
            return;
        }

        Console.WriteLine($"\nChamado {quantidade + 1}");

        Console.Write("Número: ");
        chamados[quantidade].Numero = int.Parse(Console.ReadLine()!);

        Console.Write("Solicitante: ");
        chamados[quantidade].Solicitante = Console.ReadLine()!;

        Console.Write("Setor: ");
        chamados[quantidade].Setor = int.Parse(Console.ReadLine()!);

        Console.Write("Prioridade (1 a 3): ");
        chamados[quantidade].Prioridade = int.Parse(Console.ReadLine()!);

        Console.Write("Descrição: ");
        chamados[quantidade].Descricao = Console.ReadLine()!;

        chamados[quantidade].Status = "Aberto";

        quantidade++;

        Console.WriteLine("Chamado cadastrado!");
    }

    static void listarChamados(Chamado[] chamados, int quantidade)
    {
        Console.WriteLine("\n===== LISTA DE CHAMADOS =====");

        if (quantidade == 0)
        {
            Console.WriteLine("Nenhum chamado cadastrado.");
            return;
        }

        foreach (int i in Enumerable.Range(0, quantidade))
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Número: {chamados[i].Numero}");
            Console.WriteLine($"Solicitante: {chamados[i].Solicitante}");
            Console.WriteLine($"Setor: {chamados[i].Setor}");
            Console.WriteLine($"Prioridade: {classificarPrioridade(chamados[i].Prioridade)}");
            Console.WriteLine($"Status: {chamados[i].Status}");
            Console.WriteLine($"Descrição: {chamados[i].Descricao}");
        }
    }

    static void atualizarStatus(Chamado[] chamados, int quantidade)
    {
        Console.Write("Digite o número do chamado: ");
        int numero = int.Parse(Console.ReadLine()!);

        bool encontrado = false;

        foreach (int i in Enumerable.Range(0, quantidade))
        {
            if (chamados[i].Numero == numero)
            {
                Console.WriteLine("1 - Em andamento");
                Console.WriteLine("2 - Resolvido");
                Console.WriteLine("3 - Cancelado");

                Console.Write("Novo status: ");
                int op = int.Parse(Console.ReadLine()!);

                switch (op)
                {
                    case 1:
                        chamados[i].Status = "Em andamento";
                        break;
                    case 2:
                        chamados[i].Status = "Resolvido";
                        break;
                    case 3:
                        chamados[i].Status = "Cancelado";
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        return;
                }

                Console.WriteLine("Status atualizado!");
                encontrado = true;
            }
        }

        if (!encontrado)
            Console.WriteLine("Chamado não encontrado.");
    }

    static string classificarPrioridade(int prioridade)
    {
        switch (prioridade)
        {
            case 1:
                return "Baixa";
            case 2:
                return "Média";
            case 3:
                return "Alta";
            default:
                return "Inválida";
        }
    }

    static void estatisticas(Chamado[] chamados, int quantidade)
    {
        int aberto = 0;
        int andamento = 0;
        int resolvido = 0;
        int cancelado = 0;

        foreach (int i in Enumerable.Range(0, quantidade))
        {
            switch (chamados[i].Status)
            {
                case "Aberto":
                    aberto++;
                    break;

                case "Em andamento":
                    andamento++;
                    break;

                case "Resolvido":
                    resolvido++;
                    break;

                case "Cancelado":
                    cancelado++;
                    break;
            }
        }

        Console.WriteLine("\n===== ESTATÍSTICAS =====");
        Console.WriteLine($"Abertos: {aberto}");
        Console.WriteLine($"Em andamento: {andamento}");
        Console.WriteLine($"Resolvidos: {resolvido}");
        Console.WriteLine($"Cancelados: {cancelado}");
    }

    static void Main()
    {
        Chamado[] chamados = new Chamado[10];
        int quantidade = 0;
        int opcao;

        do
        {
            Console.WriteLine("\nMenu de Chamados");
            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Listar Chamados");
            Console.WriteLine("3 - Atualizar Status");
            Console.WriteLine("4 - Estatísticas");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    cadastrarChamado(chamados, ref quantidade);
                    break;

                case 2:
                    listarChamados(chamados, quantidade);
                    break;

                case 3:
                    atualizarStatus(chamados, quantidade);
                    break;

                case 4:
                    estatisticas(chamados, quantidade);
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 5);
    }
}