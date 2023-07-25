Crie um programa que implemente uma interface IVeiculo com dois métodos, um para Dirigir
do tipo void e outro para Abastecer do tipo bool que possui um parâmetro do tipo int com a
quantidade de gasolina a abastecer.(defina isso como uma propriedade)

Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a
quantidade inicial de gasolina do carro e implemente os métodos Dirigir e Abastecer do carro.

O método Dirigir deve exibir na tela ”Dirigindo o carro..”, se a gasolina for maior que 0, caso
contrário deve exibir “Sem gasolina...”, e o método Abastecer deve aumentar a gasolina do
carro e retornar true.

Para testar, crie um objeto do tipo Carro com 0 de gasolina inicial e solicite ao usuário a
informação de uma quantidade de gasolina para abastecer via teclado e por fim execute o
método Dirigir do carro.


Explicação:

1. Primeiro, definimos a interface IVeiculo, com os métodos Dirigir() (sem retorno - void) e Abastecer(int quantidade) (com retorno bool).

2. Em seguida, criamos a classe Carro, que implementa a interface IVeiculo. A classe possui um campo privado gasolina para armazenar a quantidade de gasolina do carro.

3. O construtor da classe Carro é utilizado para definir a quantidade inicial de gasolina do carro.

4. No método Dirigir(), verificamos se a quantidade de gasolina é maior que 0. Se for, exibimos a mensagem "Dirigindo o carro..."; caso contrário, exibimos "Sem gasolina...".

5. O método Abastecer(int quantidade) é responsável por aumentar a quantidade de gasolina do carro em quantidade.

6. No método Main, solicitamos ao usuário a quantidade de gasolina para abastecer via teclado, criamos um objeto meuCarro da classe Carro com 0 de gasolina inicial, abastecemos o carro com a quantidade fornecida pelo usuário e, por fim, executamos o método Dirigir() do carro.