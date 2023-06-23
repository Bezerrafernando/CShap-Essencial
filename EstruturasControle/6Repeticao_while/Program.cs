class Program
{
    static void Main(string[] agrs)
    {
        Console.Clear();
        Exemplo3();
    }
    static void Exemplo1()
    {
        var i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine($"i={i}");
            i++;
        }
        System.Console.WriteLine("Fin do processamento");
    }
    static void Exemplo2()
    {
        var j = 10;
        while (j > 0)
        {
            System.Console.WriteLine($"j={j}");
            j--;
        }
        System.Console.WriteLine("fim do processamento");
    }
    static void Exemplo3()
    {
        int numero;
        int contador = 1;
        System.Console.WriteLine("Digite um numero maior que zero(0):\t");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 0){
            System.Console.WriteLine($"\n###tabuado do {numero}####\n");
            while(contador < 11){
                System.Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                contador++;
            }
        }
        else{
            System.Console.WriteLine("\nNumero deve ser maior que zero");
        }
    }
}