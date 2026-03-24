using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantidade: ");
        if (!int.TryParse(Console.ReadLine(), out int total)) return;

        int i = 0;
        int qtdPares = 0;
        double somaPares = 0;

        while (i < total)
        {
            Console.Write($"{i + 1}º número: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num % 2 == 0)
                {
                    somaPares += num;
                    qtdPares++;
                }
                i++;
            }
        }

        if (qtdPares > 0)
        {
            double media = somaPares / qtdPares;
            Console.WriteLine($"Média: {media}");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}