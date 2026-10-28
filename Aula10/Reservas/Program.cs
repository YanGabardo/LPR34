using System;
using System.Collections.Generic;

class Cliente
{
    private readonly List<Reserva> _reservas = new();

    public string Nome { get; set; } = string.Empty;
    public IReadOnlyList<Reserva> Reservas => _reservas.AsReadOnly();

    public void AdicionarReserva(Reserva reserva)
    {
        ArgumentNullException.ThrowIfNull(reserva);

        if (reserva.Cliente is not null && reserva.Cliente != this)
        {
            throw new InvalidOperationException("Esta reserva já pertence a outro cliente.");
        }

        if (!_reservas.Contains(reserva))
        {
            _reservas.Add(reserva);
            reserva.Cliente = this;
        }
    }

    public void ListarReservas()
    {
        Console.WriteLine($"Reservas de {Nome}:");

        if (_reservas.Count == 0)
        {
            Console.WriteLine("Nenhuma reserva cadastrada.");
            return;
        }

        foreach (Reserva reserva in _reservas)
        {
            Console.WriteLine($"- {reserva.Descricao}");
        }
    }
}

class Reserva
{
    public string Descricao { get; set; } = string.Empty;
    public Cliente? Cliente { get; internal set; }
}

class Program
{
    static void Main()
    {
        Cliente cliente = new() { Nome = "Ana" };

        Reserva reserva1 = new() { Descricao = "Jantar para duas pessoas" };
        Reserva reserva2 = new() { Descricao = "Hospedagem de uma noite" };

        cliente.AdicionarReserva(reserva1);
        cliente.AdicionarReserva(reserva2);

        cliente.ListarReservas();
    }
}
