#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <map>
#include <limits>
// definição da struct Piloto
struct Piloto {
    std::string nome;
    std::string equipe;
    int pontuacao;
};

//funções
void CadastrarPiloto(std::vector<Piloto>& lista);
void ExibirRanking(std::vector<Piloto> lista); // Passagem por cópia para ordenar sem alterar a lista original
void CalcularPontuacaoMedia(const std::vector<Piloto>& lista);
void ExibirMelhorEquipe(const std::vector<Piloto>& list);

int main() {
    std::vector<Piloto> competidores;
    int opcao;

    std::cout << "Gerenciamento" << std::endl;

    do {
        std::cout << "\nMenu" << std::endl;
        std::cout << "1. Cadastrar Piloto (Maximo 10)" << std::endl;
        std::cout << "2. Exibir Ranking dos Pilotos" << std::endl;
        std::cout << "3. Calcular Pontuacao Media" << std::endl;
        std::cout << "4. Exibir Melhor Equipe" << std::endl;
        std::cout << "5. Sair" << std::endl;
        std::cout << "Escolha uma opcao: ";
        std::cin >> opcao;

        // limpar o buffer do teclado
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

        switch (opcao) {
            case 1:
                if (competidores.size() < 10) {
                    CadastrarPiloto(competidores);
                } else {
                    std::cout << "\n[Erro] Limite de 10 pilotos atingido!" << std::endl;
                }
                break;
            case 2:
                if (competidores.empty()) {
                    std::cout << "\nNenhum piloto cadastrado ainda." << std::endl;
                } else {
                    ExibirRanking(competidores);
                }
                break;
            case 3:
                if (competidores.empty()) {
                    std::cout << "\nNenhum piloto cadastrado para calcular a media." << std::endl;
                } else {
                    CalcularPontuacaoMedia(competidores);
                }
                break;
            case 4:
                if (competidores.empty()) {
                    std::cout << "\nNenhum piloto cadastrado para avaliar as equipes." << std::endl;
                } else {
                    ExibirMelhorEquipe(competidores);
                }
                break;
            case 5:
                std::cout << "\nSaindo do programa." << std::endl;
                break;
            default:
                std::cout << "\nOpcao invalida, Tente novamente." << std::endl;
        }
    } while (opcao != 5);

    return 0;
}

// função para cadastrar um novo piloto na lista
void CadastrarPiloto(std::vector<Piloto>& lista) {
    Piloto novoPiloto;
    
    std::cout << "\n--- Cadastro de Piloto (" << lista.size() + 1 << "/10) ---" << std::endl;
    std::cout << "Nome do piloto: ";
    std::getline(std::cin, novoPiloto.nome);
    
    std::cout << "Equipe do piloto: ";
    std::getline(std::cin, novoPiloto.equipe);
    
    std::cout << "Pontuacao do piloto: ";
    std::cin >> novoPiloto.pontuacao;
    
    lista.push_back(novoPiloto);
    std::cout << "Piloto cadastrado com sucesso." << std::endl;
}

// função para exibir o ranking do maior para o menor pontuador
void ExibirRanking(std::vector<Piloto> lista) {
    // ordena a lista de forma decrescente com base na pontuação
    std::sort(lista.begin(), lista.end(), [](const Piloto& a, const Piloto& b) {
        return a.pontuacao > b.pontuacao;
    });

    std::cout << "\nRanking dos Pilotos" << std::endl;
    for (size_t i = 0; i < lista.size(); ++i) {
        std::cout << i + 1 << "o Lugar: " << lista[i].nome 
                  << " | Equipe: " << lista[i].equipe 
                  << " | Pontos: " << lista[i].pontuacao << std::endl;
    }
}

// função para calcular e exibir a pontuação média dos pilotos cadastrados
void CalcularPontuacaoMedia(const std::vector<Piloto>& lista) {
    double soma = 0;
    for (const auto& piloto : lista) {
        soma += piloto.pontuacao;
    }
    double media = soma / lista.size();
    
    std::cout << "\nPontuacao Media dos pilotos cadastrados: " << media << " pontos." << std::endl;
}

// função para calcular e exibir a equipe que acumulou mais pontos
void ExibirMelhorEquipe(const std::vector<Piloto>& lista) {
    // estrutura para acumular os pontos de cada equipe
    std::map<std::string, int> pontosPorEquipe;

    for (const auto& piloto : lista) {
        pontosPorEquipe[piloto.equipe] += piloto.pontuacao;
    }

    std::string melhorEquipe = "";
    int maiorPontuacao = -1;

    for (const auto& par : pontosPorEquipe) {
        if (par.second > maiorPontuacao) {
            maiorPontuacao = par.second;
            melhorEquipe = par.first;
        }
    }

    std::cout << "\nMelhor Equipe" << std::endl;
    std::cout << "Equipe: " << melhorEquipe << std::endl;
    std::cout << "Pontuacao Acumulada: " << maiorPontuacao << " pontos." << std::endl;
}