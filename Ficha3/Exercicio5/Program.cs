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
            int idade,maior=0,num,i=0;
            Console.WriteLine("Digite o número de alunos.");
            num = Convert.ToInt32(Console.ReadLine());
         
          
            for (int l=0;l!=num;l++)
            {
                Console.WriteLine("Digite a idade.");
                idade= Convert.ToInt32(Console.ReadLine());

                if (idade >= maior)
                {
                    i = 0;
                    maior = idade;
                    i++;
                }
                else if (idade == maior)
                    i++;

            }
            Console.WriteLine("Idade Maior: {0}", maior);
            Console.WriteLine("Quantidade de Alunos com a maior idade: {0}", i);
            Console.ReadKey();

        }
    }
}
