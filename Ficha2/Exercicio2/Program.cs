using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, i = 0;
            Console.WriteLine("Digite um número.");
            num = (Convert.ToDouble(Console.ReadLine()));
            while (i < 30)
            {
                Console.WriteLine(++num);
                i++;
            }
            Console.ReadKey();
        }
    }
}
