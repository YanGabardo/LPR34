using System;
using System.Linq;

// definindo a struct Heroi
struct Heroi
{
    public string Nome;
    public string Poder;
    public float Pontuacao;
}

class Program
{
    static void Main()
    {
        // cadastrar 5 herois e definir a seleção de equipes com 3 herois cada. Imprimir as equipes formadas.
        Console.WriteLine("Cadastro de Heróis:");
        Heroi[] herois = new Heroi[5];

        foreach (int i in Enumerable.Range(0, 5))
        {
            Console.WriteLine($"\nHerói {i + 1}:");
            Console.Write("Nome: ");
            herois[i].Nome = Console.ReadLine();

            Console.Write("Poder: ");
            herois[i].Poder = Console.ReadLine();

            Console.Write("Pontuação: ");
            herois[i].Pontuacao = float.Parse(Console.ReadLine());
        }

        // Seleção de uma equipe com 3 heróis com menu
        Console.WriteLine("\nSeleção de Equipe:");
        Heroi[] equipe = new Heroi[3];
        for (int i = 0; i < equipe.Length; i++)
        {
            Console.WriteLine($"\nSeleção do Herói {i + 1}:");
            for (int j = 0; j < herois.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {herois[j].Nome} - Poder: {herois[j].Poder}, Pontuação: {herois[j].Pontuacao}");
            }
            Console.Write("Escolha o número do herói para a equipe: ");
            int escolha = int.Parse(Console.ReadLine()) - 1;
            equipe[i] = herois[escolha];
        }

        // Imprimir a equipe formada
        Console.WriteLine("\nEquipe Formada:");
        foreach (Heroi heroi in equipe)
        {
            Console.WriteLine($"Nome: {heroi.Nome}, Poder: {heroi.Poder}, Pontuação: {heroi.Pontuacao}");
        }
        //calcular a pontuação total da equipe
        float pontuacaoTotal = equipe.Sum(h => h.Pontuacao);
        Console.WriteLine($"\nPontuação Total da Equipe: {pontuacaoTotal}");
    }
}