using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 9, 5, 7, 2, 6, 10, 77, 19, 79, 27, 40, 69, 100 };

            int aux = 0;
            int menor, pos_menor;
            

         
            for (int i = 0; i <= vetor.Length - 2; i++)
            {
                menor = vetor[i];
                pos_menor = i;
                for (int j = i+1; j <= vetor.Length - 1 ; j++)
                {
                    if (menor > vetor[j])
                    {
                        menor = vetor[j];
                        pos_menor = j;
                    }
                }

                if (pos_menor != i)
                {
                    aux = vetor[i];
                    vetor[i] = vetor[pos_menor];
                    vetor[pos_menor] = aux;
                }

            }

            //testar ordenação
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine(vetor[k]);
            }

            Console.ReadKey();
        }
    }
}
