using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        for (int i = 50; i <= 500; i++)
        {
            if (i % 2 != 0 && i % 3 == 0) //verifica se o número é ímpar e múltiplo de 3
            {
                soma += i;
            }
        }

        Console.WriteLine($"A soma total é: {soma}");
    }
}