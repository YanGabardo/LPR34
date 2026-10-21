#include <iostream>
#include <string>

using namespace std;

// definindo a struct filme
struct Filme
{
    string titulo;
    string diretor;
    int anoLancamento;
};

int main()
{
    Filme filmes[3];

    // solicitando os dados dos filmes
    for (int i = 0; i < 3; i++)
    {
        cout << "\nFilme " << i + 1 << endl;

        cout << "Digite o titulo do filme: ";
        getline(cin, filmes[i].titulo);

        cout << "Digite o diretor do filme: ";
        getline(cin, filmes[i].diretor);

        cout << "Digite o ano de lancamento do filme: ";
        cin >> filmes[i].anoLancamento;
        cin.ignore();
    }

    for (int i = 0; i < 3; i++)
    {
        cout << "\nFilme " << i + 1 << endl;
        cout << "Titulo: " << filmes[i].titulo << endl;
        cout << "Diretor: " << filmes[i].diretor << endl;
        cout << "Ano de Lancamento: " << filmes[i].anoLancamento << endl;
    }

    // encontrando o filme mais antigo
    int maisAntigo = 0;

    for (int i = 1; i < 3; i++)
    {
        if (filmes[i].anoLancamento < filmes[maisAntigo].anoLancamento)
        {
            maisAntigo = i;
        }
    }

    cout << "Filme mais antigo:" << endl;
    cout << "Titulo: " << filmes[maisAntigo].titulo << endl;
    cout << "Diretor: " << filmes[maisAntigo].diretor << endl;
    cout << "Ano de Lancamento: " << filmes[maisAntigo].anoLancamento << endl;

    return 0;
}