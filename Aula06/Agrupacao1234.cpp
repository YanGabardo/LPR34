#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime>

using namespace std;

void exercicio1() {
    int total, num, qtdPares = 0;
    double somaPares = 0;

    cout << "Quantidade: ";
    cin >> total;

    for (int i = 0; i < total; i++) {
        cout << i + 1 << "o numero: ";
        cin >> num;
        if (num % 2 == 0) {
            somaPares += num;
            qtdPares++;
        }
    }

    if (qtdPares > 0) {
        cout << "Media: " << (somaPares / qtdPares) << endl;
    } else {
        cout << "0" << endl;
    }
}

void exercicio3() {
    long long numero, quadrado;
    int soma = 0;

    cout << "Digite um numero: ";
    cin >> numero;
    quadrado = numero * numero;

    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    cout << "Soma dos digitos do quadrado: " << soma << endl;
}

void exercicio4() {
    double horasPorDia;
    const int META = 1000;

    cout << "Horas de treinamento por dia: ";
    cin >> horasPorDia;

    double horasSemana = horasPorDia * 5;
    double totalDias = META / horasPorDia;
    double totalSemanas = META / horasSemana;
    double totalMeses = totalSemanas / 4.5;

    cout << fixed << setprecision(2);
    cout << "Treinamento Jedi" << endl;
    cout << "Horas por semana (seg a sex): " << horasSemana << "h" << endl;
    cout << "Dias necessarios: " << totalDias << endl;
    cout << "Semanas necessarias: " << totalSemanas << endl;
    cout << "Meses necessarios: " << totalMeses << endl;
}

int main() {
    int opcao;

    do {
        cout << "\n--- MENU DE EXERCICIOS ---" << endl;
        cout << "1. Media de Pares (Ex 1)" << endl;
        cout << "3. Soma Digitos do Quadrado (Ex 3)" << endl;
        cout << "4. Treinamento Jedi (Ex 4)" << endl;
        cout << "0. Sair" << endl;
        cout << "Escolha: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                exercicio1();
                break;
            case 3:
                exercicio3();
                break;
            case 4:
                exercicio4();
                break;
            case 0:
                cout << "Saindo..." << endl;
                break;
            default:
                cout << "Opcao invalida!" << endl;
        }
    } while (opcao != 0);

    return 0;
}