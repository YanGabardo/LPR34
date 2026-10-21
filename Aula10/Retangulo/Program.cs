//Progama para ler lardura e altura de um retângulo e calcular a área e o perímetro, ultilizando POO
using System;

class Retangulo
{
    public double Largura;
    public double Altura;

    public double calcArea()
    {
        return Largura * Altura;
    }

    public double calcPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.WriteLine("Digite a largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        double area = retangulo.calcArea();
        double perimetro = retangulo.calcPerimetro();

        Console.WriteLine($"Área: {area}");
        Console.WriteLine($"Perímetro: {perimetro}");
    }
}