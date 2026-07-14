using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> jogos = new Dictionary<string, string>();

        // cadastra 5 jogos com seus respectivos gêneros
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o nome do jogo: ");
            string nomeJogo = Console.ReadLine();
            Console.Write("Digite o gênero do jogo: ");
            string generoJogo = Console.ReadLine();

            jogos[nomeJogo] = generoJogo;
        }

        // solicita o nome do jogo e exibe o gênero
        Console.Write("\nDigite o nome do jogo para consultar o gênero: ");
        string consultaJogo = Console.ReadLine();

        if (jogos.ContainsKey(consultaJogo))
        {
            Console.WriteLine($"O gênero do jogo '{consultaJogo}' é: {jogos[consultaJogo]}");
        }
        else
        {
            Console.WriteLine($"O jogo '{consultaJogo}' não foi encontrado.");
        }
    }
}