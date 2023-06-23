class Program
{
    static void Main(string[] agrs)
    {
        Console.Clear();
        Exemplo4();
    }
    static void Exemplo1()
    {
        // loop for seções opcionais
        for (int i = 0, j = 0; i + j <= 20; i++, j++)
        {
            Console.WriteLine($"i= {i} e i={j}");
        }

        Console.WriteLine("\nFim do processamento...");
        Console.ReadKey();
    }
    static void Exemplo2()
    {
        // loop for seções opcionais
        int b = 1;
        for (; b <= 10;)
        {
            Console.WriteLine($"b = {b}");
            b++;
        }
        Console.ReadKey();
    }
    static void Exemplo3()
    {
        // loop infinito
        int j = 1;
        for (; ; )
        {
            System.Console.WriteLine($"j = {j}");
            j++;
        }
        Console.ReadKey();
    }
    static void Exemplo4()
    {
        // loop for aninhado
        for (int x = 0; x < 5; x++)
        {
            for(int y=0; y<5; y++){
                Console.Write($"({x},{y})");
            }
            System.Console.WriteLine();
        }
            System.Console.WriteLine("\nFim do processamento");
    }
}