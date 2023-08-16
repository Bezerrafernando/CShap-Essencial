/* Dado um array de inteiros expresso da seguinte forma
int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
Exiba na janela do console os numeros do array e solicite via teclado ao usuário para informar o valor de um índice
do array para obter o seu respectivo valor.
Realize o tratamento de exceções filtrando as exceções IndexOutOfRangeException e ArgumentNullException */

try
{
    int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
    int index = 99;

    Console.WriteLine("Dado um array de número inteiros contendo os seguintes valores:");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write(numeros[i] + " ");
    }
    Console.WriteLine("\n\nInforme o índece do arry para obter um valor:");
    index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nO número na posição" + index + " é " + numeros[index]);
}
catch (Exception e) when (e is IndexOutOfRangeException || e is ArgumentNullException)
{
    Console.WriteLine("\nErro:" + e.Message);
}
/* Uma cláusula try-catch é usada para capturar exceções que podem ser lançadas por essa instrução.
Uma cláusula when é adicionada à cláusula catch para filtrar as exceções que serão capturadas.
Neste caso, estamos interessados em capturar exceções do tipo IndexOutOfRangeException ou
ArgumentNullException, que podem ser lançadas quando o índice é inválido ou o array é nulo, respectivamente.
Se uma exceção IndexOutOfRangeException ou ArgumentNullException for lançada, a cláusula when capturará a
exceção e exibirá uma mensagem de erro na tela. Se outra exceção for lançada, ela não será capturada e o programa
encerrará.
Para testar este exercício, tente alterar o valor do índice index para um valor dentro dos limites do array, defina o
array como nulo ou adicione mais filtros de exceção para serem capturados pela cláusula when.
Veja como o programa trata cada situação e se a mensagem apropriada é exibida na tela. */