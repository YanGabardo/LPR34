using System;

struct Heroi
{
    public string Nome;
    public string Poder;
    public float Pontuacao;
}

struct Equipe
{
    public Heroi[] Herois;
    public float PontuacaoTotal;
}

class Program
{
    static void CadastrarHeroi(Heroi[] herois, ref int quantidade)
    {
        if (quantidade >= 5)
        {
            Console.WriteLine("Limite de 5 heróis atingido!");
            return;
        }

        Console.Write("Nome do herói: ");
        herois[quantidade].Nome = Console.ReadLine();

        Console.Write("Poder do herói: ");
        herois[quantidade].Poder = Console.ReadLine();

        Console.Write("Pontuação: ");
        herois[quantidade].Pontuacao = float.Parse(Console.ReadLine());

        quantidade++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void SelecionarEquipe(Heroi[] herois, int quantidade, ref Equipe equipe)
    {
        if (quantidade < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis primeiro!");
            return;
        }

        Console.WriteLine("\n=== HERÓIS DISPONÍVEIS ===");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].Nome} | Poder: {herois[i].Poder} | Pontuação: {herois[i].Pontuacao}");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nEscolha o herói {i + 1}: ");
            int escolha = int.Parse(Console.ReadLine());

            equipe.Herois[i] = herois[escolha - 1];
        }

        equipe.PontuacaoTotal = CalcularPontuacaoTotal(equipe);

        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    static float CalcularPontuacaoTotal(Equipe equipe)
    {
        float total = 0;

        for (int i = 0; i < 3; i++)
        {
            total += equipe.Herois[i].Pontuacao;
        }

        return total;
    }

    static void ExibirEquipe(Equipe equipe)
    {
        Console.WriteLine("\n=== EQUIPE MARVEL ===");

        for (int i = 0; i < 3; i++)
        {
            if (equipe.Herois[i].Nome != null)
            {
                Console.WriteLine($"Herói: {equipe.Herois[i].Nome}");
                Console.WriteLine($"Poder: {equipe.Herois[i].Poder}");
                Console.WriteLine($"Pontuação: {equipe.Herois[i].Pontuacao}");
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Pontuação Total da Equipe: {equipe.PontuacaoTotal}");
    }

    static void MenuPrincipal()
    {
        Heroi[] herois = new Heroi[5];
        int quantidadeHerois = 0;

        Equipe equipe = new Equipe();
        equipe.Herois = new Heroi[3];
        equipe.PontuacaoTotal = 0;

        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU PRINCIPAL ===");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarHeroi(herois, ref quantidadeHerois);
                    break;

                case 2:
                    SelecionarEquipe(herois, quantidadeHerois, ref equipe);
                    break;

                case 3:
                    ExibirEquipe(equipe);
                    break;

                case 4:
                    Console.WriteLine("Programa encerrado!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }

    static void Main()
    {
        MenuPrincipal();
    }
}