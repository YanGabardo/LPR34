#include <iostream>
#include <string>

using namespace std;

//definindo a struct produto
struct Produto
{
    string nome;
    int codigo;
    float preco;
    int quantidade;
};

int main()
{
    Produto produtos[3];

    //solicitando os dados dos produtos
    for (int i = 0; i < 3; i++)
    {
        cout << "\nProduto " << i + 1 << endl;

        cout << "Digite o nome do produto: ";
        getline(cin, produtos[i].nome);

        cout << "Digite o codigo do produto: ";
        cin >> produtos[i].codigo;

        cout << "Digite o preco do produto: ";
        cin >> produtos[i].preco;

        cout << "Digite a quantidade em estoque: ";
        cin >> produtos[i].quantidade;
        cin.ignore();
     }

    //calculando o valor total do estoque
    float valorTotal = 0;

    for (int i = 0; i < 3; i++)
    {
        valorTotal += produtos[i].preco * produtos[i].quantidade;
    }

    cout << "\nValor total do estoque: R$ " << valorTotal << endl;

    return 0;
}