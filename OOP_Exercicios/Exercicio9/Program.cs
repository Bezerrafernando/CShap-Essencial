// See https://aka.ms/new-console-template for more information
MastroCreditCard cartao = new MastroCreditCard();
cartao.ValidarCartao();
cartao.IniciarTransacao();
cartao.StatusTransacao();
interface ICartaoCredito
{
    void ValidarCartao();
}
interface ITransacao
{
    void IniciarTransacao();
}
class MastroCreditCard : ICartaoCredito, ITransacao
{
    public void ValidarCartao()
    {
        Console.WriteLine("Validando cartão...");
    }
    public void IniciarTransacao()
    {
        Console.WriteLine("Iniciando transação...");
    }
    public void StatusTransacao()
    {
        Console.WriteLine("Transação Completada");
    }
}
