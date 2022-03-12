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
            int[] v1 = new int[5];
            int[] v2 = new int[5];
            int[] v3 = new int[5];
            int[] v4 = new int[5];
            int[,] m1 = new int[5, 4];
            int[,] m2 = new int[5, 4];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 4; j++)
                {
                    Console.WriteLine("Digite o número na posição: {0},{1} na matriz m1", i, j);
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite o número na posição: {0},{1} na matriz m2", i, j);
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; i++)
            {               
                {
                    v1[i] = m1[i, 0] + m2[i, 0];
                    Console.WriteLine("v1 {0}: {1}", i, v1[i]);
                   
                }
            }
            for (int i = 0; i < 5; i++)
            {
                {
                    v2[i] = m1[i, 1] + m2[i, 1];
                    Console.WriteLine("v2 {0}: {1}", i, v2[i]);

                }
            }
            for (int i = 0; i < 5; i++)
            {
                {
                    v3[i] = m1[i, 1] + m2[i, 1];
                    Console.WriteLine("v3 {0}: {1}", i, v3[i]);

                }
            }
            for (int i = 0; i < 5; i++)
            {
                {
                    v4[i] = m1[i, 1] + m2[i, 1];
                    Console.WriteLine("v4 {0}: {1}", i, v4[i]);

                }
            }
            Console.ReadKey();
        }
    }
}

