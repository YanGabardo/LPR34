#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, float> notasAlunos; // dicionário para armazenar notas dos alunos
    string nomeAluno;
    float nota;

    // loop para cadastrar notas de alunos
    while (true) {
        cout << "Digite o nome do aluno (ou 'sair' para encerrar): ";
        getline(cin, nomeAluno);

        if (nomeAluno == "sair") {
            break; // encerra o loop se o usuário digitar 'sair'
        }

        cout << "Digite a nota do aluno: ";
        cin >> nota;
        cin.ignore(); 

        // adiciona ou atualiza a nota do aluno no dicionário
        notasAlunos[nomeAluno] = nota;
    }

    // exibe as notas cadastradas, a maior nota, a menor nota e a média das notas
    if (!notasAlunos.empty()) {
        float maiorNota = -1.0;
        float menorNota = 11.0;
        float somaNotas = 0.0;

        cout << "\nNotas cadastradas:\n";
        for (const auto& aluno : notasAlunos) {
            cout << "Aluno: " << aluno.first << ", Nota: " << aluno.second << endl;

            // atualiza a maior e menor nota
            if (aluno.second > maiorNota) {
                maiorNota = aluno.second;
            }
            if (aluno.second < menorNota) {
                menorNota = aluno.second;
            }

            somaNotas += aluno.second; // acumula a soma das notas
        }

        float mediaNotas = somaNotas / notasAlunos.size(); // calcula a média das notas

        cout << "\nMaior nota: " << maiorNota << endl;
        cout << "Menor nota: " << menorNota << endl;
    }

    return 0;
}