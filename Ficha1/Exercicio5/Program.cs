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
            int i=1, num,cont=0,soma=0,media;
            do
            {
                Console.WriteLine("Digite o {0} número.", i);
                num = Convert.ToInt32(Console.ReadLine());
                i++;
                cont++;
                soma = soma + num;
            } while (cont < 20);
            media = soma / 20;
            Console.WriteLine("Média é= {0}.", media);
            Console.ReadKey();
        }
    }
}
