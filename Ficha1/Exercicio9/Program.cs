using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0,impar=0, i=0,par=0;
            do
            {
                Console.WriteLine("Digite um número.");
                num = Convert.ToDouble(Console.ReadLine());
                i++;
                if (num % 2 == 1)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            } while (i < 30);
            Console.WriteLine("Números pares: {0}", par);
            Console.WriteLine("Números ímpares: {0}", impar);
            Console.ReadKey();
        }
    }
}
