using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma=0, num=0, n10=0, n20=0, n100=0,i=0;
            do
            {
                i++;
                Console.WriteLine("Digite o {0} número.", i);
                num = Convert.ToDouble(Console.ReadLine());
                soma = soma + num;
                if (num >100)
                {
                    n100++;
                    n20++;
                    n10++;

                }
                else if (num>20)
                {
                    n20++;
                    n10++;
                }
                else if (num > 10)
                {
                   
                    n10++;
                }

            } while (i < 40);
            Console.WriteLine("Somatório: {0}", soma);
            Console.WriteLine("Números maiores que 10: {0}", n10);
            Console.WriteLine("Números maiores que 20: {0}", n20);
            Console.WriteLine("Números maiores que 100: {0}", n100);
            Console.ReadKey();

        }

    }
}
