#include <iostream>
#include <string>

using namespace std;

// definindo a struct livro
struct Livro
{
    string titulo;
    string autor;
    int anoPublicacao;
    int numPaginas;
    float preco;
};

int main()
{
    Livro livros[3];

    // solicitando os dados dos livros
    for (int i = 0; i < 3; i++)
    {
        cout << "\nLivro " << i + 1 << endl;

        cout << "Digite o titulo do livro: ";
        getline(cin, livros[i].titulo);

        cout << "Digite o autor do livro: ";
        getline(cin, livros[i].autor);

        cout << "Digite o ano de publicacao do livro: ";
        cin >> livros[i].anoPublicacao;

        cout << "Digite o numero de paginas do livro: ";
        cin >> livros[i].numPaginas;

        cout << "Digite o preco do livro: ";
        cin >> livros[i].preco;
        cin.ignore();
     }

    //calculando o preco total dos livros
    float precoTotal = 0;  

    for (int i = 0; i < 3; i++)
    {
        precoTotal += livros[i].preco;
    }

    //calculando a media de paginas dos livros
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++)
    {
        totalPaginas += livros[i].numPaginas;
    }
    float mediaPaginas = static_cast<float>(totalPaginas) / 3;
    cout << "\nPreco total dos livros: R$ " << precoTotal << endl;
    cout << "Media de paginas dos livros: " << mediaPaginas << endl;
    return 0;
}