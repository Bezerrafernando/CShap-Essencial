// See https://aka.ms/new-console-template for more information
Console.WriteLine();

INota1 p = new Exibir();
p.Classificacao();
interface INota1
{
    void Classificacao();
}
interface INota2
{
    void Classificacao();
}
class Exibir : INota1, INota2
{
    //public void Classificacao()
    void INota1.Classificacao()
    {
        Console.WriteLine("Classificacao INota1");
    }
    public void Classificacao()
    {
        Console.WriteLine("Classificacao INota2");
    }
}
