using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Interfaces_Exercicio
{
    public interface ISalvar
    {
        void Salvar();
        void Compactar()
        {
            Console.WriteLine("Compactando arquivos");
        }
    }
}