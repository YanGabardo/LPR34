using System;

class Program
{
    static void Main()
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        string h1 = "", p1 = "", h2 = "", p2 = "", h3 = "", p3 = "", h4 = "", p4 = "", h5 = "", p5 = "";
        int pt1 = 0, pt2 = 0, pt3 = 0, pt4 = 0, pt5 = 0;

        string sel1 = "", sel2 = "", sel3 = "";
        string pod1 = "", pod2 = "", pod3 = "";
        int pont1 = 0, pont2 = 0, pont3 = 0;

        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n--- SELEÇÃO DE HERÓIS MARVEL ---");
            Console.WriteLine("1 - Cadastrar 5 Heróis");
            Console.WriteLine("2 - Selecionar Equipe (3 Heróis)");
            Console.WriteLine("3 - Exibir Equipe e Pontuação");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                cadastrarHeroi(ref h1, ref p1, ref pt1, 1);
                cadastrarHeroi(ref h2, ref p2, ref pt2, 2);
                cadastrarHeroi(ref h3, ref p3, ref pt3, 3);
                cadastrarHeroi(ref h4, ref p4, ref pt4, 4);
                cadastrarHeroi(ref h5, ref p5, ref pt5, 5);
            }
            else if (opcao == 2)
            {
                selecionarEquipe(h1, p1, pt1, h2, p2, pt2, h3, p3, pt3, h4, p4, pt4, h5, p5, pt5,
                                 ref sel1, ref pod1, ref pont1,
                                 ref sel2, ref pod2, ref pont2,
                                 ref sel3, ref pod3, ref pont3);
            }
            else if (opcao == 3)
            {
                int total = calcularPontuacaoTotal(pont1, pont2, pont3);
                exibirEquipe(sel1, pod1, sel2, pod2, sel3, pod3, total);
            }
        }
    }

    static void cadastrarHeroi(ref string nome, ref string poder, ref int pontos, int numero)
    {
        Console.WriteLine($"\nCadastro do Herói {numero}:");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Poder: ");
        poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        pontos = int.Parse(Console.ReadLine());
    }

    static void selecionarEquipe(string h1, string p1, int pt1, string h2, string p2, int pt2, 
                                 string h3, string p3, int pt3, string h4, string p4, int pt4, 
                                 string h5, string p5, int pt5,
                                 ref string s1, ref string d1, ref int n1,
                                 ref string s2, ref string d2, ref int n2,
                                 ref string s3, ref string d3, ref int n3)
    {
        Console.WriteLine("\nHeróis Disponíveis:");
        Console.WriteLine($"1 - {h1} ({p1}) - Pontos: {pt1}");
        Console.WriteLine($"2 - {h2} ({p2}) - Pontos: {pt2}");
        Console.WriteLine($"3 - {h3} ({p3}) - Pontos: {pt3}");
        Console.WriteLine($"4 - {h4} ({p4}) - Pontos: {pt4}");
        Console.WriteLine($"5 - {h5} ({p5}) - Pontos: {pt5}");

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Selecione o herói {i} (digite o número de 1 a 5): ");
            int escolha = int.Parse(Console.ReadLine());

            string nomeEscolha = ""; string poderEscolha = ""; int pontoEscolha = 0;

            if (escolha == 1) { nomeEscolha = h1; poderEscolha = p1; pontoEscolha = pt1; }
            else if (escolha == 2) { nomeEscolha = h2; poderEscolha = p2; pontoEscolha = pt2; }
            else if (escolha == 3) { nomeEscolha = h3; poderEscolha = p3; pontoEscolha = pt3; }
            else if (escolha == 4) { nomeEscolha = h4; poderEscolha = p4; pontoEscolha = pt4; }
            else if (escolha == 5) { nomeEscolha = h5; poderEscolha = p5; pontoEscolha = pt5; }

            if (i == 1) { s1 = nomeEscolha; d1 = poderEscolha; n1 = pontoEscolha; }
            else if (i == 2) { s2 = nomeEscolha; d2 = poderEscolha; n2 = pontoEscolha; }
            else if (i == 3) { s3 = nomeEscolha; d3 = poderEscolha; n3 = pontoEscolha; }
        }
    }

    static int calcularPontuacaoTotal(int p1, int p2, int p3)
    {
        return p1 + p2 + p3;
    }

    static void exibirEquipe(string s1, string d1, string s2, string d2, string s3, string d3, int total)
    {
        Console.WriteLine("\n--- EQUIPE SELECIONADA ---");
        Console.WriteLine($"1. {s1} - Poder: {d1}");
        Console.WriteLine($"2. {s2} - Poder: {d2}");
        Console.WriteLine($"3. {s3} - Poder: {d3}");
        Console.WriteLine($"PONTUAÇÃO TOTAL: {total}");
    }
}