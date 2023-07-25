Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação
orientada a objetos. 
Para começar, crie uma classe chamada LivroFotos com um atributo privado numPaginas do
tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
páginas do álbum de fotos.
O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
construtor adicional, com o qual podemos especificar o número de páginas que queremos
no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
64 páginas.
Por fim, execute as seguintes ações:
- Criar um álbum de fotos padrão e exibir o número de páginas
- Criar um álbum de fotos com 24 páginas e exibir o número de páginas
- Criar um álbum de fotos grande e exibir o número de páginas

Explicação:

1. A classe `LivroFotos` é criada com o atributo privado `numPaginas` e um construtor padrão que define o álbum com 16 páginas. Além disso, há um construtor adicional que permite especificar o número de páginas desejadas para o álbum.
2. O método `GetNumeroPaginas()` é público e retorna o número de páginas do álbum.
3. A classe `SuperLivroFotos` é criada como uma subclasse de `LivroFotos` e usa o construtor padrão da classe base para criar um álbum com 64 páginas.
4. No método `Main`, são criados três álbuns de fotos:
   - `albumPadrao`: Álbum com 16 páginas (construtor padrão).
   - `album24Paginas`: Álbum com 24 páginas.
   - `albumGrande`: Álbum com 64 páginas (usando a classe `SuperLivroFotos`).

O programa exibirá o número de páginas de cada álbum criado. Certifique-se de executar o código em um ambiente de desenvolvimento C# (como Visual Studio) ou use uma plataforma online de execução de código C# para ver a saída do programa.