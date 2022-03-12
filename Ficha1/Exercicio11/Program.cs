using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0, maior, menor,i=0;

            i++;
                Console.WriteLine("Digite o {0}º número.", i);
                num = Convert.ToDouble(Console.ReadLine());
                maior=num;
                menor=num;
           
            do
                {
                    i++;
                    Console.WriteLine("Digite o {0}º número.", i);
                    num = Convert.ToDouble(Console.ReadLine());
                    
                    if (num < menor)
                {
                    menor=num;
                }
                else if (num > maior)
                {
                    maior = num;
                }
                } while (i < 30);
                Console.WriteLine("Maior número: {0}", maior);
            Console.WriteLine("Menor número: {0}", menor);
            Console.ReadKey();
        }
    }
}
