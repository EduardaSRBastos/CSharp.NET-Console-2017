using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, s = 0, i=1;
            Console.WriteLine("Digite um número.");
            n = Convert.ToDouble(Console.ReadLine());
            while (n-i!=0)
            {
                s = s + n - i;
                i++;
            }
            Console.WriteLine("S= {0}",s);
            Console.ReadKey();
        }
        

    }
}
