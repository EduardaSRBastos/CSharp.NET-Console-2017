using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int i = 0;
            Console.WriteLine("Digite o nome.");
            name = Console.ReadLine();
            Console.WriteLine ();
            do
            {
               
                Console.WriteLine(name);
                i ++;
            } while (i < 3);
            Console.ReadKey();
        }
    }
}
