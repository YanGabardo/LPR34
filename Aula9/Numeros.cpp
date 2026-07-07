#include <iostream>
#include <map>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

int main() {
    map<int, int> numeros; // dicionário para armazenar números e suas contagens
    vector<int> listaNumeros; // lista para armazenar os números aleatórios

    // gerando 100 números aleatórios entre 1 e 100
    for (int i = 0; i < 100; ++i) {
        int numeroAleatorio = rand() % 100 + 1; // número aleatório entre 1 e 100
        listaNumeros.push_back(numeroAleatorio);
        numeros[numeroAleatorio]++; // atualiza a contagem no dicionário
    }

    // Ordenando a lista de números em ordem crescente
    sort(listaNumeros.begin(), listaNumeros.end());

    // Imprimindo a lista de números ordenada
    cout << "Lista de números em ordem crescente:\n";
    for (const auto& numero : listaNumeros) {
        cout << numero << " ";
    }
    cout << endl;

    // Removendo todos os números pares da lista
    listaNumeros.erase(remove_if(listaNumeros.begin(), listaNumeros.end(),
                                  [](int num) { return num % 2 == 0; }),
                       listaNumeros.end());

    // Imprimindo a lista após remover os números pares
    cout << "Lista após remover os números pares:\n";
    for (const auto& numero : listaNumeros) {
        cout << numero << " ";
    }
    cout << endl;

    // Imprimindo os números que se repetem, se existirem
    cout << "Números que se repetem:\n";
    bool encontrouRepetidos = false;
    for (const auto& par : numeros) {
        if (par.second > 1) {
            cout << par.first << " aparece " << par.second << " vezes.\n";
            encontrouRepetidos = true;
        }
    }
    
    if (!encontrouRepetidos) {
        cout << "Não há números repetidos.\n";
    }

    return 0;
}