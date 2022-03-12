using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i,mais;
            Console.WriteLine("Digite um número.");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            for ( i = 1; i < 31; i++)
            {
                mais = num;
                mais = mais + i;
                Console.WriteLine(mais);
            }
            Console.ReadKey();
        }
    }
}
