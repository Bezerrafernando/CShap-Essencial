
try
{
    int saldo = 00;
    int valorSaque = 100;
    if (valorSaque > valorSaque)
    {
        throw new SaldoInsuficienteException("O saldo é insuficiente para este saque");
    }
    saldo -= valorSaque;
    Console.WriteLine("Saque efetuado com sucesso. Novo saldo:" + saldo);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Erro:" + e.Message);
}
class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }
    public SaldoInsuficienteException(string message) : base(message) { }
    public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException) { }
}
/* Neste exercício, uma variável saldo é inicializada com um valor de 0, representando o saldo de uma conta bancária.
Em seguida, uma variável valorSaque é definida com um valor de 100, que é maior que o saldo atual.
Uma verificação é realizada para verificar se o valor do saque é maior que o saldo. Se for, uma exceção personalizada
SaldoInsuficienteException é lançada com a mensagem "O saldo é insuficiente para este saque."
Uma cláusula try-catch é usada para capturar essa exceção personalizada e exibir uma mensagem de erro na tela.
A exceção personalizada SaldoInsuficienteException é definida como uma classe separada que herda da classe base
Exception. Ela contém três construtores: um construtor sem argumentos, um construtor que recebe uma mensagem
como argumento e um construtor que recebe uma mensagem e uma exceção interna como argumentos.
Para testar este exercício, tente alterar o valor da variável valorSaque para um valor menor que o saldo, adicione
mais verificações ou exceções personalizadas, ou defina a variável saldo como nula. Veja como o programa trata cada
situação e se a mensagem apropriada é exibida na tela. */