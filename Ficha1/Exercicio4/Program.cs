using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i=0,par;
            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 1)
                par= num+1;
            else
                par = num + 2;
            do
            {
                Console.WriteLine(par);
                par = par + 2;
                i++;
            } while (i < 10);
            Console.ReadKey();
        }
    }
}
