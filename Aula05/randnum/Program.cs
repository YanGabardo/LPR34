using System;

class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101); //gera um número inteiro aleatório entre 1 e 100
        int chute;
        int tentativas = 0;

        do
        {
            Console.Write("Digite seu chute (1 a 100): ");
            if (int.TryParse(Console.ReadLine(), out chute))
            {
                tentativas++;

                if (chute > valorInteiro)
                {
                    Console.WriteLine("chutou alto");
                }
                else if (chute < valorInteiro)
                {
                    Console.WriteLine("chutou baixo");
                }
                else
                {
                    Console.WriteLine("acertou");
                }
            }
        } while (chute != valorInteiro);

        Console.WriteLine($"Tentativas usadas: {tentativas}");
    }
}