/* Escreva um program onde o usuário é solicitado a informar um valor via teclado e armazenar o valor na
variável entrada do tipo string onde tem que verificar 3 condições diferentes:
a- Se a entrada é nula, uma exceção NullReferenceException é lançada com a mensagem "A entrada não pode ser
nula."
b-Se a entrada está vazia, uma exceção ArgumentException é lançada com a mensagem "A entrada não pode estar
vazia."
c-Se a entrada passar nas verificações anteriores, a entrada é exibida na tela.
Realize o tratamento de erro para essas condições usando o bloco try-cath-finally */

try
{
    string input = Console.ReadLine();
    if (input == null)
    {
        throw new NullReferenceException("A entranda não pode ser nula.");
    }
    if (input.Length == 0)
    {
        throw new ArgumentException("A entrada não pode estar vazia.");
    }
    Console.WriteLine("A entrada é: " + input);
}
catch (NullReferenceException e)
{
    Console.WriteLine("Erro:" + e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine("Erro inesperado" + e.Message);
}
finally
{
    Console.WriteLine("O programa foi concluído.");
}