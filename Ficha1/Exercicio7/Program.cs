using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0, soma=0;
            do
            {
                Console.WriteLine("Digite um número.");
                num = Convert.ToDouble(Console.ReadLine() );
                soma = soma + num;
            }
            while (soma < 5000);
            Console.WriteLine("O somatório dos números digitados é: {0}", soma);
            Console.ReadKey();
        }
    }
}
