class Jogo {
    public string Nome = "Valorant";
    public List<Partida> Partidas = new List<Partida>();
    public void IniciarPartida(Partida p) => Partidas.Add(p);
}
class Partida {
    public int Rodadas = 0;
    public Mapa Mapa = null!;
    public Equipe Atacante = null!, Defensora = null!;
    public void Iniciar() => Console.WriteLine("Partida iniciada");
}
class Equipe {
    public string Nome = "";
    public List<Jogador> Jogadores = new List<Jogador>();
    public void AdicionarJogador(Jogador j) => Jogadores.Add(j);
}
class Jogador {
    public string Nickname = "";
    public Agente Agente = null!;
    public List<Arma> Armas = new List<Arma>();
    public void EscolherAgente(Agente a) => Agente = a;
}
class Agente {
    public string Nome = "", Funcao = "";
    public List<Habilidade> Habilidades = new List<Habilidade>();
    public void UsarHabilidade() => Console.WriteLine("Habilidade usada");
}
class Habilidade {
    public string Nome = "";
    public int Custo = 0;
    public void Usar() => Console.WriteLine(Nome);
}
class Arma {
    public string Nome = "";
    public int Dano = 0;
    public void Disparar() => Console.WriteLine(Nome);
}
class Mapa { public string Nome = ""; public void Exibir() => Console.WriteLine(Nome); }
class Program {
    static void Main() {
        Console.WriteLine("DIAGRAMA DE CLASSES - VALORANT");
        Console.WriteLine("Jogo (1) -- (0..*) Partida -- (1) Mapa");
        Console.WriteLine("Partida (1) -- (1) Equipe atacante e defensora");
        Console.WriteLine("Equipe (1) -- (5) Jogadores -- (1) Agente");
        Console.WriteLine("Jogador (1) -- (0..*) Armas");
        Console.WriteLine("Agente (1) -- (0..*) Habilidades");
    }
}
