// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Filha ofilha = new Filha();

class Pai
{
    Filha ofilha = new Filha();
    public Pai()
    {
        System.Console.WriteLine("Construtor Pai");
    }
}
class Filha : Pai
{
    public Filha()
    {
        System.Console.WriteLine("Construtor Filha");
    }
}