using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double resultpos = 0.0;
            double resultpos2 = 0.0;
            bool conf;
            Console.Write("Insira três valores para uma equação: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            conf = nulo(a);
            if (conf == false)
            {
                do
                {
                    Console.WriteLine("Insira um valor diferente de 0 para a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                } while (a != 0);
            }
            else
            {
                resultpos = delta(a, b, c);
                resultpos2 = delta2(a, b, c);
                if (resultpos == 0.0 && resultpos2 == 0.0)
                {
                    Console.WriteLine("x+iy; Ainda não demos esta matéria...");
                }
                else
                {
                    if (resultpos2 != 0.0)
                    {
                        Console.WriteLine("O resultado da equação é: {0}", resultpos2);
                    }
                    else
                    {
                        Console.WriteLine("O resultado da equação é: {0}", resultpos);
                    }
                }
            }
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
        static bool nulo(int AAAAA)
        {
            if (AAAAA != 0)
                return true;
            else
                return false;
        }


        static double delta(int x, int y, int z)
        {
            double res = ((y * y) - (4 * x * z));
            double res2 = ((y * y) - (4 * x * z));
            res = Math.Sqrt(res);
            res = (-y + res) / 2 * x;

            if (res > 0)
            {
                return res;

            }
            else
            {
                return 0.0;
            }

        }
        static double delta2(int x, int y, int z)
        {

            double res2 = ((y * y) - (4 * x * z));
            res2 = Math.Sqrt(res2);
            res2 = (-y - res2) / 2 * x;

            if (res2 > 0)
            {
                return res2;

            }
            else
            {
                return 0.0;
            }
        }


    }
}
