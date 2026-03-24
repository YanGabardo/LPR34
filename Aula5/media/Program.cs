int n = int.Parse(Console.ReadLine());
int contador = 0;
double soma = 0;
int i = 1;

while (i <= n)
{
    int numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0) //verifica se o número é par
    {
        soma += numero;
        contador++;
    }

    i++;
}

if (contador > 0) //verifica se houve algum número par digitado
{
    double media = soma / contador;
    Console.WriteLine("Média: " + media);
}
else
{
    Console.WriteLine("Nenhum numero par foi digitado");
}