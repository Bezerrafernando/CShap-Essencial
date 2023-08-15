/* Escreva um programa que solicite ao usuário a informação da idade e do nome via teclado que deverão ser
armazenados nas variáveis idade do tipo int e nome do tipo string.

A seguir realize o tratamento de erro e lançando as exceções considerando as seguintes condições:

a- Se a idade é negativa, uma exceção ArgumentException é lançada com a mensagem "A idade não pode ser
negativa."

b - Se a idade é zero, uma exceção NotImplementedException é lançada com a mensagem "A idade ainda não foi
definida."

c- Se o nome é nulo, uma exceção NullReferenceException é lançada com a mensagem "O nome não pode ser nulo." */
int idade = 0;
string nome = null;
try
{
    Console.WriteLine("Informe a sua idade");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade < 0)

    {
        throw new ArgumentException("A idade não pode ser negativa.");
    }
    if (idade == 0)
    {
        throw new NotImplementedException("A idade ainda não foi definida.");
    }
    Console.WriteLine("Informe o seu nome");
    nome = Console.ReadLine();
    if (nome == null)
    {
        throw new NullReferenceException("O nome não pode ser nulo.");
    }
}
catch (ArgumentException e)
{
    Console.WriteLine("Erro de argumento: " + e.Message);
}
catch (NotImplementedException e)
{
    Console.WriteLine("Erro de implementação: " + e.Message);
}
catch (NullReferenceException e)
{
    Console.WriteLine("Erro de referência nula: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Erro inesperado: " + e.Message);
}