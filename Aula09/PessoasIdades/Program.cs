using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        // cadastra 5 pessoas com suas respectivas idades
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o nome da pessoa: ");
            string nomePessoa = Console.ReadLine();
            Console.Write("Digite a idade da pessoa: ");
            int idadePessoa = int.Parse(Console.ReadLine());

            pessoas[nomePessoa] = idadePessoa;
        }

        // calcula a média das idades
        double mediaIdades = 0;
        foreach (var idade in pessoas.Values)
        {
            mediaIdades += idade;
        }
        mediaIdades /= pessoas.Count;

        Console.WriteLine($"\nMédia das idades: {mediaIdades}");

        // encontra e imprime os nomes das pessoas com idades acima da média
        Console.WriteLine("\nPessoas com idades acima da média:");
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > mediaIdades)
            {
                Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
            }
        }

        // encontra a pessoa mais velha e mais nova
        string pessoaMaisVelha = null;
        string pessoaMaisNova = null;
        int idadeMaisVelha = int.MinValue;
        int idadeMaisNova = int.MaxValue;

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > idadeMaisVelha)
            {
                idadeMaisVelha = pessoa.Value;
                pessoaMaisVelha = pessoa.Key;
            }
            if (pessoa.Value < idadeMaisNova)
            {
                idadeMaisNova = pessoa.Value;
                pessoaMaisNova = pessoa.Key;
            }
        }

        Console.WriteLine($"\nPessoa mais velha: {pessoaMaisVelha} - {idadeMaisVelha} anos");
        Console.WriteLine($"Pessoa mais nova: {pessoaMaisNova} - {idadeMaisNova} anos");

        // remove todas as pessoas com idade igual a Y fornecida pelo usuário
        Console.Write("\nDigite uma idade para remover todas as pessoas com essa idade: ");
        int idadeParaRemover = int.Parse(Console.ReadLine());

        List<string> nomesParaRemover = new List<string>();
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == idadeParaRemover)
            {
                nomesParaRemover.Add(pessoa.Key);
            }
        }
    }
}             