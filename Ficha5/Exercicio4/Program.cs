using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = new int[4, 6];
            int s = 0;
            Console.WriteLine("Introduza um número:");
            s = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 6; j++)
                {

                    m1[i, j] = (6 - i) - j;

                }
            }

            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine("Coluna{0}", j + 1);
                for (int i = 0; i < 4; i++)
                {

                    Console.WriteLine("{0}", m1[i, j]);

                }
            }
            Console.ReadKey();
        }
    }
}
