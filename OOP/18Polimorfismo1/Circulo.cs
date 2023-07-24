using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18Polimorfismo1
{
    public class Circulo : Figura
    {
        public override void Desenhar(){
            Console.WriteLine("Desenhando um circulo...");
        }
    }
}