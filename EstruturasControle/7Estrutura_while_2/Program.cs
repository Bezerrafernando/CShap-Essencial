class Program
{
    static void Main(string[] agrs)
    {
        Console.Clear();
        Exemplo01();
    }
    static void Exemplo01()
    {
        bool continua = true;
        // lop infinito
        while (continua)
        {
            Console.WriteLine("Informe um numero inteiro/; (para sair tecle 999)");

            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 999)
            {
                continua = false;
            }
            if (numero % 2 == 0)
                Console.WriteLine($"{numero}é PAR");
            else
                Console.WriteLine($"{numero}é IMPAR");
        }
        Console.WriteLine("Fim do processamento...");
        Console.ReadKey();
    }
    static void Exemplo02()
    {
        // loop alinhado
        int x = 0;
        while (x < 5)
        {
            int y = 0;
            while (y < 5)
            {
                Console.Write($"({x},{y}) ");
                y++;
            }
            x++;
            Console.WriteLine();
        }

        Console.WriteLine("Fim do processamento...");
        Console.ReadKey();
    }
}