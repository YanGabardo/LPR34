using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero inteiro: "); //ler o numero
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0) //verificar se o numero é par ou impar
        {
            Console.WriteLine("O numero é par");
        }
        else
        {
            Console.WriteLine("O numero é ímpar");
        }
    }
}