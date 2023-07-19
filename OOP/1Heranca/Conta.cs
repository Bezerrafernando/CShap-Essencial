using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta
    {
        public int contador;
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public decimal GetSaldo()
        {
            return Saldo;
        }
    }
}
