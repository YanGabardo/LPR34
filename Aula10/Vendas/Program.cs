using System;

class Produto {
    public string Nome = "";
    public double Preco = 0;
}
class Pedido {
    public Produto Produto = new Produto();
    public int Quantidade = 0;
    public double CalcularTotal() => Produto.Preco * Quantidade;
}
class Program {
    static void Main() {
        Produto produto = new Produto { Nome = "Teclado", Preco = 100 };
        Pedido pedido = new Pedido { Produto = produto, Quantidade = 2 };
        Console.WriteLine($"Produto: {pedido.Produto.Nome}");
        Console.WriteLine($"Quantidade: {pedido.Quantidade}");
        Console.WriteLine($"Total: R$ {pedido.CalcularTotal():F2}");
    }
}
