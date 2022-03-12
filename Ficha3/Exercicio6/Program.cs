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
            int n;
            double s = 0;
            Console.WriteLine("Digite um número.");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=n;i++)
            {
                s = s + n /(double) i;
            }
            Console.WriteLine("Somatório: {0}.", s);
            Console.ReadKey();
        }
    }
}
