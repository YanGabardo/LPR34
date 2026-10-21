#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double horasPorDia;
    double horasSemana = 0;
    const int META = 1000;

    cout << "Horas de treinamento por dia: ";
    cin >> horasPorDia;

    for (int i = 1; i <= 5; i++) {
        horasSemana += horasPorDia;
    }

    //valor total de dias para atingir a meta
    double totalDias = META / horasPorDia; 
    double totalSemanas = META / horasSemana;
    double totalMeses = totalSemanas / 4.5;

    cout << fixed << setprecision(2);
    cout << "Treinamento Jedi" << endl;
    cout << "Horas por semana (seg a sex): " << horasSemana << "h" << endl;
    cout << "Dias necessarios: " << totalDias << endl;
    cout << "Semanas necessarias: " << totalSemanas << endl;
    cout << "Mesess necessarios: " << totalMeses << endl;

    return 0;
}