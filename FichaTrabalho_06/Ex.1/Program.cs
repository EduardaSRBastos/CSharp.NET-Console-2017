using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool r;
            Console.WriteLine("Insira um valor");
            n = Convert.ToInt32(Console.ReadLine());

            r = valor(n);

            if (r == true)
                Console.WriteLine("Positivo");
            
            else
                Console.WriteLine("Negativo");

            Console.ReadKey();
        }

      
        static bool valor(int n)
        {
            bool r;
            if (n > 0)
            {
                r = true;
                
            }
            else

            {
                r = false;
                
            }
            return r;
        }
        
    }
}
