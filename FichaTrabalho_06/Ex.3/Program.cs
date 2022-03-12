using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int r;

            Console.WriteLine("Insira o valor de A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de C");
            c = Convert.ToInt32(Console.ReadLine());

            r = calculo(a, b, c);
            Console.WriteLine(r);

            Console.ReadKey();
        }

        static int calculo (int a, int b, int c)
        {
            int r;
            r = (b * b) - (4 * a * c);
            return r;
        }
    }
}
