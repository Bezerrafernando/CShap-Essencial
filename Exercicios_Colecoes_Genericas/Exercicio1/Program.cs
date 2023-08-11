// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Teste teste = new Teste();
teste.MetodoTeste<string>("Usando Generics -> ");
teste.MetodoTeste<float>(4.2f);
Console.ReadKey();
public class Teste
{
    public void MetodoTeste<T>(T arg)
    {
        Console.Write(arg);
    }
}
