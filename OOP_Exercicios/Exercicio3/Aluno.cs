using System;

public class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
    }
    public void Estudar()
    {
        Console.WriteLine($"{Nome} Estudando...");
    }
}