//codigo com POO
using System;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

//Contrutor 1
    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
 
}

class Program
{
    
        Produto p1 = new Produto("TV", 900.00, 10);
        Produto p2 = new Produto("Notebook", 1200.00, 5);
        
    
}