using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18Polimorfismo1
{
    public class Triangulo : Figura
    {
        public override void Desenhar(){
            Console.WriteLine("Desenhado um triangulo...");
            base.Desenhar();
        }
    }
}