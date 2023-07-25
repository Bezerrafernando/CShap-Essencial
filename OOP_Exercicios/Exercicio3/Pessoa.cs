using System;

public class Pessoa
{

    protected string Nome { get; set; }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public override string ToString()
    {
        return "Olá! Meu nome é " + Nome;
    }

}