using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0, i=0;
            do
            {
                Console.WriteLine("Digite um número.");
                num = Convert.ToDouble(Console.ReadLine());
                i++;
            } while (num != 0);
            Console.WriteLine("Foram digitados {0} números.", i);
            Console.ReadKey();
        }
    }
}
