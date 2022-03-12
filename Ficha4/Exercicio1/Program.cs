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

            int  i=0;
            double[] num = new double[20];
           while(i<20)
            {
                Console.WriteLine("Digite o {0}º número real.",++i );
                num[i-1] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("3ºelemento lido: {0}", num[2]);
            Console.WriteLine("8ºelemento lido mais o 18º: {0}", num[7]+num[17]);
            Console.WriteLine("Resultado do último menos o primeiro: {0}", num[19]-num[0]);
            Console.ReadKey();
        }
    }
}
