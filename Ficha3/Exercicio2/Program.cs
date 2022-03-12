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
            int num,i=1,tab;
           
                Console.WriteLine("Escolha um número de 1 a 10");
                num = Convert.ToInt32(Console.ReadLine());
              
                while (num <=0)
                {
                    Console.WriteLine("Não digitou um número de 1 a 10.");
                    Console.WriteLine("Escolha um número de 1 a 10.");
                    num = Convert.ToInt32(Console.ReadLine());
                }
    
                while (num > 10)
                {
                    Console.WriteLine("Não digitou um número de 1 a 10.");
                    Console.WriteLine("Escolha um número de 1 a 10");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine(" ");
            for (tab = 0; tab < (num*10); i++)
            {
                tab = num;
                tab = tab  * i;
                
                Console.WriteLine(tab);
            }
                Console.ReadKey();
        }
    }
}
