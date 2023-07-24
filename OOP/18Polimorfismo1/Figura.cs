using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18Polimorfismo1
{
    public class Figura
    {
       public virtual void Desenhar(){
        Console.WriteLine("Executando Desenhar na classe base");
       } 
    }
}