#include <iostream>

using namespace std;

int main() {
   
    int A, B, C, D, diferenca;

    cout << "Digite o valor de A:";
    cin >> A;
    cout << "Digite o valor de B:";
    cin >> B;
    cout << "Digite o valor de C:";
    cin >> C;
    cout << "Digite o valor de D:";
    cin >> D; //pede todos os valores


    diferenca = (A * B - C * D);

    cout << "Diferença = " << diferenca << endl;

    return 0;
}