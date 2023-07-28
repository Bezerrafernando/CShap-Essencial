using System;

// Classe abstrata Database
public abstract class Database
{
    // Método abstrato que será implementado pelas classes derivadas
    public abstract void Configurar();

    // Método abstrato de Conectar
    public abstract void Conectar();
}
// Classe SQLServer que herda de Database
public class SQLServer : Database
{
    public override void Configurar()
    {
        Console.WriteLine("Configurando o banco de dados SQL Server...");
    }
    public override void Conectar()
    {
        Console.WriteLine("Conectando ao SQL Server...");
    }
}
class Program
{
    static void Main()
    {
        // Criando uma instância da classe SQLServer
        SQLServer sqlServer = new SQLServer();

        // Chamando o método Configurar da classe SQLServer
        sqlServer.Configurar();

        // Chamando o método Conectar da classe SQLServer
        sqlServer.Conectar();
    }
}