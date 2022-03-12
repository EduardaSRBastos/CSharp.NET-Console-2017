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
            int[,] m3 = new int[10, 5];
            int[,] m1 = new int[10, 5];
            int[,] m2 = new int[10, 5];

            for (int i=0; i <10;i++)
            {
                for (int j=0;i < 5;j++)
                {
                    Console.WriteLine("Digite o número na posição: {0},{1} na matriz m1", i,j);
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                    m3[i,j]= m1[i, j];
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; i < 5; j++)
                {
                    Console.WriteLine("Digite o número na posição: {0},{1} na matriz m2", i, j);
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                    m3[i,j] += m2[i, j];
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; i < 5; j++)
                {
                    Console.WriteLine("Matriz soma (m3): {0}", m3[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
