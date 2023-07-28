Dado o código ao lado explique qual vai ser o resultado da
sua execução e o que deve ser feito para corrigir o código
caso isso seja necessário
Como a classe `Exibir` esta implementando as duas interfaces e
como as interfaces possuem a definição de um método com o
mesmo nome vai haver uma ambiguidade sobre qual dos
métodos invocar na classe.
Se duas interfaces tiverem o mesmo contrato, a
implementação da classe precisa de um identificador de
interface e isso é feito realizando a implementação explícita de
interface conforme mostrado a seguir:

class Exibir : INota1, INota2
{
    void INota1.Classificacao()
    {
        Console.WriteLine("Classificacao INota1");
    }
    void INota2.Classificacao()
    {
        Console.WriteLine("Classificacao INota2");
    }
}