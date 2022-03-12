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
            double  i = 1;
            while (i < 21)
            {
                
                Console.WriteLine("{0}º número positivo.", i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
