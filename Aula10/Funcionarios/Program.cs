// Progama para ler nome de um funcionario e calcular aumento de seu salario, ultilizando POO
using System;

class Funcionario
{
    public string Nome;
    public double Salario;

}
class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Digite o nome do funcionário: ");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Digite o salário do funcionário: ");
        funcionario.Salario = double.Parse(Console.ReadLine());

        double aumento = 0;

        if (funcionario.Salario <= 2000)
        {
            aumento = funcionario.Salario * 0.10;
        }
        else if (funcionario.Salario <= 3000)
        {
            aumento = funcionario.Salario * 0.15;
        }
        else
        {
            aumento = funcionario.Salario * 0.20;
        }

        double novoSalario = funcionario.Salario + aumento;

        Console.WriteLine($"Nome: {funcionario.Nome}");
        Console.WriteLine($"Salário atual: {funcionario.Salario}");
        Console.WriteLine($"Aumento: {aumento}");
        Console.WriteLine($"Novo salário: {novoSalario}");
    }
}