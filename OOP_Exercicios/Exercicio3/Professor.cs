using System;

public class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    {
        Nome = nome;
    }
    public void Explicar()
    {
        Console.WriteLine($"{Nome} Explicando...");
    }
}