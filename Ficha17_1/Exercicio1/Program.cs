using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura;
            int i = 0;
            do
            {
                Console.Write("Comprimento do lado: ");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Console.Write("Largura: ");
                largura = Convert.ToDouble(Console.ReadLine());
                Quadrado no = new Quadrado(comprimento);
                Retangulo ni = new Retangulo(largura, comprimento);
                Console.WriteLine("Área do quadrado com lado {0} = {1}", comprimento, no.areaa());
                Console.WriteLine("Área do retângulo com {0}", ni.dimensoes());
                Console.ReadKey();
                i++; 
            } while (i < 10);
        }
    }
}
