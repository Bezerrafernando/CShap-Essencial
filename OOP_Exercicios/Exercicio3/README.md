Crie um programa que solicite ao usuário três nomes de pessoas e os armazene em
uma matriz de objetos do tipo Pessoa. Haverá duas pessoas do tipo Aluno e uma
pessoa do tipo Professor.
Para isso, crie uma classe Pessoa que possua uma propriedade Nome do tipo string, um
construtor que receba o nome como parâmetro e sobrescreva o método ToString().
Então crie mais duas classes que herdam da classe Pessoa, elas serão chamadas de
Aluno e Professor. A classe Aluno possui um método Estudar que escreve pelo console
que o aluno está estudando. A classe Professor terá um método Explicar que grava no
console que o professor está explicando.
Lembre-se de também criar dois construtores nas classes filhas que chamam o
construtor pai da classe Pessoa.
Termine o programa lendo as pessoas (o professor e os alunos) e execute os métodos
Explicar e Estudar.

Explicação:

1. Crie a classe base Pessoa
2. Crie a classe Aluno, que herda de Pessoa
3. Crie a classe Professor, que também herda de Pessoa
4. No programa principal, crie um método para ler os nomes e instanciar os objetos:
Neste programa, criamos as classes Pessoa, Aluno e Professor. O usuário pode inserir os nomes das três pessoas, e em seguida, a matriz de objetos é criada. O método Explicar é chamado para o professor e o método Estudar é chamado para os alunos.