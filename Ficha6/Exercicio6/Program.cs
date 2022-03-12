using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0,num=0;
            double pro = 0;

            int[] s = new int[7];
            do
            {
                i++;
                System.Threading.Thread.Sleep(50);
                num = dados();
                Console.ForegroundColor = (ConsoleColor) num;
                Console.Write("{0} ", num);
                s[num]++;                       
                              
            }                   
            while (i < 300);
            Console.ResetColor();
            Console.WriteLine("");
            for (num = 1; num < 7; num++)
            {
                pro += s[num] / (double)300;

                Console.WriteLine("O número {0} saiu: {1}. {2}", num, s[num],pro);
                pro = 0;             
            }
            Console.WriteLine("Probabilidade: 1/6=0,1666666666(6)");
            //blackcat8
            Console.ReadKey();
        }
        static int dados()
        {
            int dado;

            Random rnd=new Random();
             dado = rnd.Next(1, 7);
          
            return dado;
        }
    }
}
