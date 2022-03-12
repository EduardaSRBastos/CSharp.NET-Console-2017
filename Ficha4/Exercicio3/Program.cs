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
            int[] vetor = new int[20];
            for (int i = 1; i != 20; i++)
            {
                Console.WriteLine("Digite o {0}º número.", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                
            }
           
            
            for (int i = 1; i != 21; i++)
            { 
                 Console.Write(" {0} ",vetor[i]);

        }
            Console.WriteLine("");
            Array.Reverse(vetor);
            for (int i = 1; i != 21; i++)
            {
                Console.Write(" {0} ", vetor[i]);

            }
            Console.ReadKey();
        }
    }
}
