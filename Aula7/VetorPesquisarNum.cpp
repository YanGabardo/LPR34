#include <iostream>
using namespace std;

//Entrar com 10 numeros inteiros em um vetor
int main()
{
    int vetor[10], num, posicao = -1;

    cout << "Digite 10 numeros inteiros: " << endl;
    for (int i = 0; i < 10; i++)
    {
        cin >> vetor[i];
    }

    // Pesquisar o numero no vetor
    cout << "Digite um numero para pesquisar: ";
    cin >> num;

    for (int i = 0; i < 10; i++)
    {
        if (vetor[i] == num)
        {
            posicao = i;
            break;
        }
    }

    if (posicao != -1)
    {
        cout << "O numero " << num << " foi encontrado na posicao " << posicao << "." << endl;
    }
    else
    {
        cout << "O numero " << num << " nao foi encontrado no vetor." << endl;
    }

    return 0;
}