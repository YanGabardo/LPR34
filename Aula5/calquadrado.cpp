#include <iostream>

using namespace std;

int main() {
    long long numero, quadrado;
    int soma = 0;

    cout << "Digite um numero: ";
    cin >> numero;
    quadrado = numero * numero;

    while (quadrado > 0) {
        soma += quadrado % 10; // adiciona o ultimo digito do quadrado a soma
        quadrado /= 10; // remove o ultimo digito do quadrado
    }

    cout << "Soma dos digitos do quadrado: " << soma << endl;

    return 0;
}