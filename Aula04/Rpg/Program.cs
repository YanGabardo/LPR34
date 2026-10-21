using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma classe:");
        Console.WriteLine("1 - Guerreira");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueira");

        Console.Write("Digite o numero da classe: ");
        int opcao = int.Parse(Console.ReadLine()); //selecionar a classe

        Console.WriteLine();

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Classe: Guerreira");
                Console.WriteLine("Habilidades: Ataque Pesado, Defesa Total");
                break;

            case 2:
                Console.WriteLine("Classe: Mago");
                Console.WriteLine("Habilidades: Bola de Fogo, Escudo de Gelo");
                break;

            case 3:
                Console.WriteLine("Classe: Arqueira");
                Console.WriteLine("Habilidades: Flecha Precisa, Disparo Triplo");
                break;
        }
    }
}