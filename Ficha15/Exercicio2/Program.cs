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
            int qntd;
            double n;
            Console.WriteLine("Digite um número.");
            n = Convert.ToDouble(Console.ReadLine());
            RaizQuad s = new RaizQuad();
            if(n!= )
            Console.Write("Digite a quantidade de decimais:");
            qntd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Raiz quadrada de {0}: {1}.",n, s.raizquadrada(n,qntd));
            Console.ReadKey();
        }
    }
}
