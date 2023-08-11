// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercício 2");

Generic<String> g = new Generic<String>();
g.Campo = "Exercício Generics";
Console.WriteLine(g.Campo);
Console.ReadKey();
public class Generic<T>
{
 public T? Campo;
}