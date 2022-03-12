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
            string res;
            double ff = 0;            
            Console.WriteLine("Deseja a temperatura em Celsius ou Farenheit.");
            res = Console.ReadLine();
            switch (res)
            {
                case "Celsius":
                    Console.WriteLine("Digite a temperatura.");
                    ff = Convert.ToDouble(Console.ReadLine());
                    celsius(ref ff);
                    
                    break;
            }
            Console.ReadKey();     
        }
        static double celsius(ref double f)
        {
            f=(9 * (5 * (f - 32) / 9) / 5) + 32;
            return f;
        }
    }
}
