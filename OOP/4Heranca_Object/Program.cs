// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine();

Nada nada = new();

public class Nada
{
}
public struct Struct1 { }
public class Classe1 { }
public class Classe2 { }
public class ClasseDerivada : Classe1 { } // Classe2 não suporta heranças multipla
