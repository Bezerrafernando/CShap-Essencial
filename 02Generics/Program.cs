// See https://aka.ms/new-console-template for more information

ClasseGenerica<int> intObj = new ClasseGenerica<int>();

//adiciona valores inteiros na coleção
intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);

Console.WriteLine("Classe classeGenerica<M> de objetos int");
//Exibir valores 
for (int i = 0; i < 5; i++)

    Console.WriteLine(intObj[i]);
Console.ReadKey();

public class ClasseGenerica<T>
{
    //definição de 5 elementos
    T[] obj = new T[5];
    int contador = 0;
    //adcionar elementos
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador++] = item;
        }
        contador++;
    }
    //indexador para a interação foreach
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }

}