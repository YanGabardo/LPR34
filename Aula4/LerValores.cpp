#include <iostream>
using namespace std;

int main() {
    int A, B;

    cout << "Digite dois numeros inteiros: ";
    cin >> A >> B; //entra com os nmeros

    if (A % B == 0 || B % A == 0) {
        cout << "Sao Multiplos" << endl;
    } else {
        cout << "Não sao Multiplos" << endl;
    }

    return 0;
}