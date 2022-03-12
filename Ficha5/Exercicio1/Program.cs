using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, s = 0;
            int[,] array2D = new int[4, 4];
            Console.WriteLine("Introduza um numero");
            array2D[0, 0] = Convert.ToInt32(Console.ReadLine());
            maior = array2D[0, 0];
            s = maior;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j == 0)
                        j = 1;
                    Console.WriteLine("Introduza um numero");
                    array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                    s += array2D[i, j];
                    if (array2D[i, j] > maior)
                    {
                        maior = array2D[i, j];
                    }

                }
            }

            Console.WriteLine("O maior numero é {0} e a soma dos numeros é {1} e a média é {3}", maior, s, s / (double)16);
            Console.ReadKey();
        }
    }
}
