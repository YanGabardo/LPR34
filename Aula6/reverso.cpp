#include <iostream>

using namespace std;

int reverterNumero(int n) {
    int reverso = 0;
    while (n > 0) {
        reverso = reverso * 10 + (n % 10);
        n /= 10;
    }
    return reverso;
}

int main() {
    int num;
    cin >> num;
    cout << reverterNumero(num) << endl;
    return 0;
}