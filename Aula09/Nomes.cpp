#include <iostream>
#include <vector>
#include <string>

int main() {
    std::vector<std::string> nomes; // lista para armazenar nomes
    int quantidadeNomes;

    std::cout << "Digite a quantidade de nomes que deseja cadastrar: ";
    std::cin >> quantidadeNomes;
    std::cin.ignore(); // limpa o buffer do teclado

    // loop para cadastrar nomes
    for (int i = 0; i < quantidadeNomes; ++i) {
        std::string nome;
        std::cout << "Digite o nome do aluno " << (i + 1) << ": ";
        std::getline(std::cin, nome);
        nomes.push_back(nome); // adiciona o nome à lista
    }

    // exibe os nomes cadastrados 
    for (int tamanho = 1; tamanho <= 100; ++tamanho) { // assumindo que o tamanho máximo do nome é 100
        bool encontrouNome = false;
        for (const auto& nome : nomes) {
            if (nome.length() == tamanho) {
                std::cout << nome << " "; // exibe o nome na mesma linha
                encontrouNome = true;
            }
        }
        if (encontrouNome) {
            std::cout << std::endl; // quebra de linha após exibir todos os nomes de um determinado tamanho
        }
    }

    return 0;
}