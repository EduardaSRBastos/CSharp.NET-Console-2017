using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double soma = 0, media = 0, teo, pra,i=0;
            do
            {
                Console.WriteLine("Digite a nota do teste teórico.");
                teo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a nota do teste prático.");
                pra = Convert.ToDouble(Console.ReadLine());

                soma = soma + teo+pra;               
                media = soma / 2;
                i++;
                Console.WriteLine("A média é: {0}", media);
                if (media < 9.5)
                {
                    Console.WriteLine("O aluno {0} não foi aprovado.",i);
                }
                else if (media >= 9.5)
                {
                    Console.WriteLine("O aluno {0} foi aprovado.",i);
                }
                soma = 0;
                media = 0;
            } while (i < 30);
            Console.ReadKey();
        }
    }
}
