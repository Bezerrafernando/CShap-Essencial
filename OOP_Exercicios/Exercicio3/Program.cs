class Program
{
    public static void Main(string[] args)
    {
        int total = 3;
        Pessoa[] pessoas = new Pessoa[total];
        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("Informe o nome do Professor");
                pessoas[i] = new Professor(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Informe o nome do Aluno");
                pessoas[i] = new Aluno(Console.ReadLine());
            }
        }
        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                Console.Write("Professor... ");
                ((Professor)pessoas[i]).Explicar();
            }
            else
            {
                Console.Write("Aluno... ");
                ((Aluno)pessoas[i]).Estudar();
            }
        }
    }
}
