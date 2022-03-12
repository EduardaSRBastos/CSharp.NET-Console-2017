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
            
            int[] vetor = new int[11];
            Console.WriteLine("Digite um número.");
            vetor[5] = Convert.ToInt32(Console.ReadLine());

            int c = 5;
            
            for (int i =0 ; i != 11; i++)
            {
                
                vetor[i] = vetor[5]-c;
                Console.WriteLine("Vetor na posição {0}: {1}.", i, vetor[i]);
                c = c - 1;
            }
           
            Console.ReadKey();
        }
    }
}
