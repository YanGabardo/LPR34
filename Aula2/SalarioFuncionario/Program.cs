using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        Console.Write("Número do funcionário: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Horas trabalhadas: ");
        int horas = int.Parse(Console.ReadLine()); 
        Console.Write("Valor por hora: ");
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pede as informaçoes


        double salario = horas * valorHora;


        Console.WriteLine($"NUMBER = {numero}");
        Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}