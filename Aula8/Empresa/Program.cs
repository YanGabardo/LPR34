//NAO FINALIZADO


using System.Linq;
using System;
//criando struct Chamado
struct Chamado
{
    public int numero;
    public string Solicitante;
    public int setor;
    public int prioridade;
}
class Program
{
    static void Main()
    {
        //cadastrar 5 chamados e imprimir a lista de chamados
        Console.WriteLine("Cadastro de Chamados:");
        Chamado[] chamados = new Chamado[5];

        foreach (int i in Enumerable.Range(0, 5))
        {
            Console.WriteLine($"\nChamado {i + 1}:");
            Console.Write("Número: ");
            chamados[i].numero = int.Parse(Console.ReadLine());

            Console.Write("Solicitante: ");
            chamados[i].Solicitante = Console.ReadLine();

            Console.Write("Setor: ");
            chamados[i].setor = int.Parse(Console.ReadLine());

            Console.Write("Prioridade: ");
            chamados[i].prioridade = int.Parse(Console.ReadLine());
        }

        // Imprimir a lista de chamados
        Console.WriteLine("\nLista de Chamados:");
        foreach (Chamado chamado in chamados)
        {
            Console.WriteLine($"Número: {chamado.numero}, Solicitante: {chamado.Solicitante}, Setor: {chamado.setor}, Prioridade: {chamado.prioridade}");
        }
    }
}