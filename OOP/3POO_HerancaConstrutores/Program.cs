// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine();

var aluno = new Aluno("Dbezerra");

class Pessoa
{
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}
class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
}