using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public int Operacao { get; set; }
        public double Somar()
        {
            return Numero1 + Numero2;
        }
        public double Subtrair()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public double Dividir()
        {
            return Numero1 / Numero2;
        }

    }
}
