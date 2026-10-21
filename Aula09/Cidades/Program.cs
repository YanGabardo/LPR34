using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // construindo o dicionário de cidades e suas populações
        Dictionary<string, int> cidades = new Dictionary<string, int>()
        {
            { "São Paulo", 12300000 },
            { "Rio de Janeiro", 6700000 },
            { "Belo Horizonte", 2500000 },
            { "Salvador", 2900000 },
            { "Fortaleza", 2700000 },
            { "Curitiba", 1900000 }
        };

        Console.WriteLine("Dicionário de cidades e suas populações:");
        ExibirDicionario(cidades);

        // encontrar e imprimir todas as cidades com população acima da média
        double mediaPopulacao = cidades.Values.Average();
        Console.WriteLine($"A média populacional é: {mediaPopulacao:N0} habitantes.");
        Console.WriteLine("Cidades com população acima da média:");
        foreach (var par in cidades)
        {
            if (par.Value > mediaPopulacao)
            {
                Console.WriteLine($"- {par.Key}: {par.Value:N0} habitantes");
            }
        }
        // encontrar e imprimir a cidade mais populosa e a menos populosa
        string cidadeMaisPopulosa = "";
        int maxPopulacao = int.MinValue;

        string cidadeMenosPopulosa = "";
        int minPopulacao = int.MaxValue;

        foreach (var par in cidades)
        {
            if (par.Value > maxPopulacao)
            {
                maxPopulacao = par.Value;
                cidadeMaisPopulosa = par.Key;
            }

            if (par.Value < minPopulacao)
            {
                minPopulacao = par.Value;
                cidadeMenosPopulosa = par.Key;
            }
        }

        Console.WriteLine($"Cidade mais populosa: {cidadeMaisPopulosa} ({maxPopulacao:N0} habitantes)");
        Console.WriteLine($"Cidade menos populosa: {cidadeMenosPopulosa} ({minPopulacao:N0} habitantes)");
        

        // remover cidades com população igual a um valor Y fornecido pelo usuário
        Console.Write("Digite um valor de população (Y) para remover as cidades correspondentes: ");
        if (int.TryParse(Console.ReadLine(), out int valorY))
        {
            // criamos uma lista com as chaves a remover para não modificar o dicionário enquanto o percorremos
            List<string> chavesParaRemover = new List<string>();

            foreach (var par in cidades)
            {
                if (par.Value == valorY)
                {
                    chavesParaRemover.Add(par.Key);
                }
            }

            // removendo as cidades encontradas
            if (chavesParaRemover.Count > 0)
            {
                foreach (var chave in chavesParaRemover)
                {
                    cidades.Remove(chave);
                }
                Console.WriteLine($"\nCidades com exatamente {valorY:N0} habitantes foram removidas.");
            }
            else
            {
                Console.WriteLine($"\nNenhuma cidade possui exatamente {valorY:N0} habitantes.");
            }

            // exibir o dicionário atualizado
            Console.WriteLine("\nAtualização do dicionário de cidades após a remoção:");
            ExibirDicionario(cidades);
        }
        else
        {
            Console.WriteLine("Valor inválido digitado.");
        }
    }

    // função auxiliar para exibir o dicionário formatado
    static void ExibirDicionario(Dictionary<string, int> dic)
    {
        if (dic.Count == 0)
        {
            Console.WriteLine("O dicionário está vazio.");
            return;
        }

        foreach (var par in dic)
        {
            Console.WriteLine($"{par.Key} => {par.Value:N0} habitantes");
        }
    }
}