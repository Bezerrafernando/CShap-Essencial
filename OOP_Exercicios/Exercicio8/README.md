Na linguagem C# podemos criar um objeto da classe derivada a partir da sua classe base ? Explique e de um
exemplo de código.

Resposta : Não.

Quando criamos um objeto de uma classe, sua referência é armazenada na memória Stack , o objeto é armazenado na
memória Heap e o endereço do objeto é atribuído à referência da classe.

Dado o código : `Filha ofilha = new Filha();`

- `Filha` é a classe
- `ofilha` é o objeto da classe , seno uma referência à classe `Filha` criada na memória Stack
- `new Filha();` vai criar o objeto do tipo `Filha` na memória Heap e o endereço dele é atribuído à referência do objeto

Ao tentar criar um objeto da classe derivada a partir da classe base teremos uma chamada cíclica entre o construtor da
classe Filha e a classe Pai causando um estouro da pilha (memória Stack). (veja exemplo de código a seguir)


`Observação`

O processo será encerrado devido a um StackOverflowException.
Ao criar uma instância da classe Filha() o seu construtor será
chamado, e, como classe Filha herda da classe Pai, a classe Filha vai
executar a classe Pai onde temos o código para criar a instância da
classe filha a partir da classe base.
Ao fazer isso será chamado o construtor da classe Filha novamente
que vai retornar para a classe Pai e o processo vai se repetir até
que não exista mais memória para ser alocada na Stack ocorrendo
um erro de Stack Overflow.

`Stack overflow.`
Repeat 12050 times:
--------------------------------
   at Filha..ctor()
   at Pai..ctor()
--------------------------------
   at Filha..ctor()
   at Program.<Main>$(System.String[])