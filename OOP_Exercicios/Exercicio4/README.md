Crie um programa que solicite ao usuário os nomes de três pessoas e os armazene em uma
matriz de objetos do tipo Pessoa.
Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo
string, um construtor que receba o nome como parâmetro e sobrescreva o método
ToString().
Finalize o programa lendo as pessoas e executando o método ToString() na tela.

Explicação:
1. A classe `Pessoa` é criada com uma propriedade `Nome` do tipo string.
2. O construtor da classe `Pessoa` é definido para receber o nome como parâmetro e atribuí-lo à propriedade `Nome`.
3. O método `ToString()` é sobrescrito para retornar uma string formatada com o nome da pessoa.
4. No método `Main()`, criamos um array `pessoas` que armazenará os objetos do tipo `Pessoa`.
5. Utilizamos um loop `for` para solicitar ao usuário os nomes das três pessoas e, em seguida, criar objetos `Pessoa` com os nomes informados e armazená-los na matriz `pessoas`.
6. Por fim, utilizamos outro loop `foreach` para exibir os dados das pessoas na tela, chamando o método `ToString()` sobrescrito para cada objeto `Pessoa`.

Ao executar o programa, ele solicitará os nomes das três pessoas e, em seguida, mostrará os dados das pessoas na tela, conforme foram inseridos.