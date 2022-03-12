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
            int num,i=0;
            Console.WriteLine("Digite um número.");
            num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            do
            {
                num++;
                Console.WriteLine(num);
                
                i++;
            } while (i < 20);
            Console.ReadKey();
        }
    }
}
