using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        
        static void Main(string[] args)
        {            
            int[] numeros = {1,2,3,4,5,6};            
            for (int i=0; i <= 5; i++)
            {
                numeros[i] = dado(numeros[i]);
                
                Console.WriteLine("O número {0} saiu: {1}", i+1, numeros[i]);
            }
            Console.ReadKey();


        }
        static int dado(int vezes)
        {
            int c = 0;
            int[] random = new int[300];
            Random rnd = new Random();
            for (int i = 0; i<= 299; i++)
            {
                random[i] = rnd.Next(1, 7);
                if (vezes==random[i])
                {
                    c++;
                }
            }
            return c;
        }
    }
}
