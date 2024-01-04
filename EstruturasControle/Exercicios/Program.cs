class Program
{
    static void Main(string[] agrs)
    {
        Console.Clear();
        // Alterar numero do (exercicio?) para testar
        Exercicio2();
    }

    /* 1- Escreva um programa para receber 3 números inteiros 
    e a seguir calcular e exibir qual deles é o maior */

    static void Exercicio1()
    {
        int num1, num2, num3;

        Console.Write("\nEncontre o maior numero dentre 3 número:\n");

        Console.Write("Digite Primeiro Número:\t");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite Segundo Número:\t");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite Terceiro Número:\t");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
                Console.Write($"O primeiro número {num1} é o maior.");
            else
                Console.Write($"O terceiro número{num3} é o maior.");
        }
        else if (num2 > num3)
            Console.Write($"O segundo número {num2} é o maior.");
        else
            Console.Write($"O terceiro numero {num3} é o maior.");
    }
        /*  2 - Escreva um programa para calcular a raiz da equação quadrática : ax^2 +bx + x = 0
        - Considere a, b e c números inteiros apenas
        - Para calcular as raízes use a fórmula de Báskara : x = (-b +- sqrt(delta))/2.a delta = b^2 -4.a.c
        - Solicite a entrada de a , b e c e informe se existe ou não raiz real
        Dica: Utilize os recursos da classe Math e use a instrução if-elseif 
        */
    static void Exercicio2() 
    { 
        int a, b, c;
        double d, x1, x2;

        Console.Write("Cálculo da equação do segundo grau :\n");

        Console.Write("Informe o valor de a:\t");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de b:\t");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de c:\t");
        c = Convert.ToInt32(Console.ReadLine());

        d = b * b - 4 * a * c;

        if (d == 0)
        {
            Console.WriteLine($"Primeira raiz são iguais.");
            x1 = -b / (2.0 * a);
            x2 = x1;
            Console.WriteLine($"Primeira raiz x1 = {x1}");
            Console.WriteLine($"Segunda raiz x2 = {x2}");
        }
        else if (d > 0)
        {
            System.Console.WriteLine("Ambas as raízes são reais e diferentes");
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            System.Console.WriteLine($"Primeira raiz x1 = {x1}");
            System.Console.WriteLine($"Segunda raiz x2 = {x2}");
        }
        else
            System.Console.WriteLine("As raízes são imaginárias;\n Sem solução para os números reais. \n\n");
    }
    static void Exercicio3()
    {
        // Usando o loop for
        System.Console.WriteLine("###Usando o loop for###");
        int i, soma = 0;
        System.Console.WriteLine("Os 10 primeiros números são :");
        for (i = 1; i <= 10; i++)
        {
            soma = soma + i;
            System.Console.WriteLine($"{i}");
        }
        System.Console.WriteLine($"A soma dos número é: {soma}\n");
        System.Console.WriteLine("Continuar aperte enter...\n");
        Console.ReadKey();

        //Usando loop while
        System.Console.WriteLine("###Usando loop while ###\n");

        int j = 1, soma2 = 0;
        System.Console.WriteLine("Os 10 primeiros números são :");

        while (j <= 10)
        {
            soma2 = soma2 + j;
            System.Console.WriteLine(j);
            j++;
        }
        System.Console.WriteLine($"A soma2 dos número é: {soma2}\n");
        System.Console.WriteLine("Continuar aperte enter...\n");
        Console.ReadKey();

        // Usando loop do-while
        System.Console.WriteLine("###Usando loop do-while###\n");
        int w = 1, soma3 = 0;
        System.Console.WriteLine("Os 10 primeiros números são :");

        do
        {
            soma3 = soma3 + w;
            System.Console.WriteLine(w);
            w++;
        }
        while (w <= 10);
        System.Console.WriteLine($"A soma2 dos número é: {soma3}\n");
        System.Console.WriteLine("Continuar aperte enter...\n");
        Console.ReadKey();
    }
    static void Exercicio4()
    {
        // Use os loop while e for e para sair a instrução break
        while (true)
        {
            int numero1;
            int contador = 1;
            System.Console.WriteLine("Digite um numero maior que zero('999' sair): \t");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == 999)
                break;
            if (numero1 > 0)
            {
                System.Console.WriteLine($"### Tabuada do {numero1} ####");
                while (contador < 11)
                {
                    System.Console.WriteLine($"{numero1} * {contador} = {numero1 * contador}");
                    contador++;
                }
            }
            else
            {
                System.Console.WriteLine("Número deve ser maior que zero!!");
            }
        }
    }
    static void Exercicio5()
    {
        string resposta;
        bool condicao = true;
        System.Console.WriteLine("Qual a instrução para sair de um loop ?");
        System.Console.WriteLine("a. qui");
        System.Console.WriteLine("b. continue");
        System.Console.WriteLine("c. break");
        System.Console.WriteLine("d. exit");

        while (condicao)
        {
            System.Console.WriteLine("Qual a opção corret ? (Tecle x para sair)");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "c")
            {
                System.Console.WriteLine("Resposta Correta!");
                condicao = false;
            }
            else if (resposta == "x")
            {
                System.Console.WriteLine("Programa encerrado..");
                condicao = false;
            }
            else
            {
                System.Console.WriteLine("Resposta Incorreta");
            }
        }
    }
    static void Exercicio6()
    {
        System.Console.WriteLine("###Exemplo3 a seguir...###\n");
        // Implementando 2 em cada passo
        for (int i = 10; i < 20; i += 2)
        {
            if (i == 16)
                continue;
            System.Console.WriteLine($"i = {i}");
        }
        Console.ReadKey();
        // Implementando 2 em cada passo
        System.Console.WriteLine("###Exemplo2 a seguir...###\n");
        for (int i = 10; i <= 20; i++)
        {
            if (i % 2 == 1)
                continue;
            if (i == 16)
                continue;
            System.Console.WriteLine($"i = {i}");
        }
        Console.ReadKey();
        // Com loop infinito
        System.Console.WriteLine("###Exemplo3 a seguir...###\n");
        for (int i = 10; ; i += 2)
        {
            if (1 == 16)
                continue;
            if (i > 20)
                break;
            System.Console.WriteLine($"i = {i}");
        }
        System.Console.WriteLine("Finalizando exemplos....");
    }
    static void Exercicio7()
    {
        int i, j, linhas;

        System.Console.WriteLine("Informe o número de linhas: ");
        linhas = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= linhas; i++)
        {
            for (j = 1; j <= i; j++)

                Console.Write("*");
            Console.Write("\n");
        }
    }
    static void Exercicio8()
    {
        // Fatorial
        int k, f = 1, num;
        Console.WriteLine("Cálculo do fatorial de um número:");
        Console.Write("\nInforme o número inteiro maior que zero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (k = 1; k <= num; k++)
            f = f * k;
        System.Console.WriteLine($"O fatorial de {num} é {f}\n");
    }
    static void Exercicio9()
    {
        // loop do-while
        int numero2 = 2;
        do
        {
            int multiplicador1 = 1;
            do
            {
                Console.WriteLine($"{numero2}*{multiplicador1} = {numero2 * multiplicador1}");
                multiplicador1++;
            }
            while (multiplicador1 <= 10);
            Console.WriteLine(" ");
            numero2++;
        } while (numero2 <= 10);
        Console.ReadKey();
    }
    static void Exercicio10()
    {
        // Notas de alunos
        while (true)
        {
            Console.WriteLine("Informe a nota do aluno(99 sair...) ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 99)
                break;
            Console.WriteLine("Resultado da Avaliação: ");
            switch (x)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;
                case 9:
                    Console.WriteLine("A+");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 6:
                    Console.WriteLine("C");
                    break;
                case 5:
                    Console.WriteLine("E");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
    static void Exercicio11()
    {
        // operações de adição, subtração, multiplicação e divisão
        int num2, num3;
        string operando;
        float resposta;

        Console.WriteLine("Informe o primeiro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o operando(+,-,/,*):");
        operando = Console.ReadLine();

        Console.WriteLine("Informe o segundo número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        switch(operando){
            case"-":
            resposta = num2 - num3;
            break;
            case"+":
            resposta = num2 + num3;
            break;
            case"/":
            resposta = (float)num2 / num3;
            break;
            case"*":
            resposta = num2 * num3;
            break;
            default:
            resposta = 0;
            break;
        }
        System.Console.WriteLine($"{num2} {operando} {num2}={resposta}");
        Console.ReadKey();
    }
}