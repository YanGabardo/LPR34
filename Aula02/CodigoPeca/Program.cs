using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Dados da Peça 1 (Código, Quantidade, Valor):");
        string[] peca1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(peca1[0]);
        int qte1 = int.Parse(peca1[1]);
        double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

      
        Console.WriteLine("Dados da Peça 2 (Código, Quantidade, Valor):");
        string[] peca2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(peca2[0]);
        int qte2 = int.Parse(peca2[1]);
        double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);


        double total = (qte1 * valor1) + (qte2 * valor2);


        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}