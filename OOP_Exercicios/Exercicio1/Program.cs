using System;

interface IVeiculo
{
    void Dirigir();
    bool Abastecer(int quantidadeGasolina);
}

class Carro : IVeiculo
{
    private int quantidadeGasolina;

    public Carro(int quantidadeInicialGasolina)
    {
        quantidadeGasolina = quantidadeInicialGasolina;
    }

    public void Dirigir()
    {
        if (quantidadeGasolina > 0)
        {
            Console.WriteLine("Dirigindo o carro...");
        }
        else
        {
            Console.WriteLine("Sem gasolina...");
        }
    }

    public bool Abastecer(int quantidadeGasolina)
    {
        if (quantidadeGasolina < 0)
        {
            Console.WriteLine("Erro: A quantidade de gasolina a abastecer não pode ser negativa.");
            return false;
        }

        this.quantidadeGasolina += quantidadeGasolina;
        Console.WriteLine($"Abastecimento concluído. Quantidade de gasolina atual: {this.quantidadeGasolina}");
        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a quantidade inicial de gasolina do carro:");
        int quantidadeInicialGasolina = int.Parse(Console.ReadLine());

        Carro carro = new Carro(quantidadeInicialGasolina);

        Console.WriteLine("Informe a quantidade de gasolina para abastecer:");
        int quantidadeParaAbastecer = int.Parse(Console.ReadLine());

        carro.Abastecer(quantidadeParaAbastecer);
        carro.Dirigir();
    }
}