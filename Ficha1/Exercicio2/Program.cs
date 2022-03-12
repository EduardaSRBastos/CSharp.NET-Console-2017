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
            int num = 1,i=0;
            do
            {
               
                Console.WriteLine(num);
                num=num +1;
                i++;
            } while (i< 20);
            Console.ReadKey();
        }
    }
}
