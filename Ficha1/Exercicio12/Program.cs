using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n=0, s = 0,i=0;
            Console.WriteLine("Digite o número.");
            n = Convert.ToDouble(Console.ReadLine());
            do
            {
                i++;
                s = s + n / i;
            } while (i < 20);
            Console.WriteLine("O valor de S é: {0}.", s);
            Console.ReadKey();
        }
        
    }
}
