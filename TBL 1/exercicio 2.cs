using System;

class Pessoa
{
    public string Nome;
}

class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Jhose";

        Pessoa p2 = p1;
        p2.Nome = "Maria";

        Console.WriteLine("Questão 2 – Tipos de Referência");
        Console.WriteLine($"Nome de p1: {p1.Nome}");
    }
}
