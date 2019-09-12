using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora objCalculadora1 = new Calculadora();

            Console.WriteLine("Digite o primeiro valor");
            objCalculadora1.Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            objCalculadora1.Numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma das seguintes operações");
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            objCalculadora1.Operacao = Convert.ToInt32(Console.ReadLine());

            switch(objCalculadora1.Operacao)
            {
                case 1:
                    
                    Console.WriteLine("O resultado eh: " + objCalculadora1.Somar());
                    break;
                case 2:
                    
                    Console.WriteLine("O resultado eh: " + objCalculadora1.Subtrair());
                    break;
                case 3:
                    
                    Console.WriteLine("O resultado eh: " + objCalculadora1.Multiplicar());
                    break;
                case 4:
                    
                    Console.WriteLine("O resultado eh: " + objCalculadora1.Dividir());
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
