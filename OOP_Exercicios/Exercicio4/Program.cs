using System;

class Program
{
    static void Main()
    {
        Pessoa[] pessoas = new Pessoa[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();
            pessoas[i] = new Pessoa(nome);
        }
        // Exibir os dados na tela utilizando o método ToString()
        Console.WriteLine("\nDados das pessoas:");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(pessoa.ToString());
        }
    }
}