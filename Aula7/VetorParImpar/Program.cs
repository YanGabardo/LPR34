using System;
using System.Linq;

// entrar com 10 nmeros inteiros. Armazenar os numeros em um vetore os nmeros mpares em outro vetor. Imprimir os dois vetores.
Console.WriteLine("Digite 10 números inteiros:");
int[] numeros = new int[10];

foreach (int i in Enumerable.Range(0, 10))
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// verificar quais números são pares e quais são ímpares
int[] pares = new int[10];
int[] impares = new int[10];
int indexPar = 0, indexImpar = 0;

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        pares[indexPar] = numero;
        indexPar++;
    }
    else
    {
        impares[indexImpar] = numero;
        indexImpar++;
    }
}

// imprimir os vetores de pares e ímpares
Console.WriteLine("\nNúmeros Pares:");
foreach (int i in Enumerable.Range(0, indexPar))
{
    Console.Write(pares[i] + " ");
}
Console.WriteLine("\nNúmeros Ímpares:");
foreach (int i in Enumerable.Range(0, indexImpar))
{
    Console.Write(impares[i] + " ");
}
