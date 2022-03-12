using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            double res=0.0;
            string temp;


            Console.WriteLine("Escolha a temperatura a converter para:");
            temp = Console.ReadLine();
            Console.WriteLine("Escolha o valor da temperatura:");
            val = Convert.ToInt32(Console.ReadLine());

            switch (temp)
                {
                case "C":
                    {
                        res = Calc_Temp_C (val);
                    }
                    break;

                case "F":
                    {
                        res = Calc_Temp_F(val);
                    }
                    break;
                }

            Console.WriteLine("O valor da conversão é: {0}", res);
            Console.ReadKey();
        }
        static double Calc_Temp_C (int val)
        {
            double r;

            r = (double)5 * (val - 32) / 9;

            return r;
        }
        static double Calc_Temp_F(int val)
        {
            double r;

            r = (double)(9 * val / 5) + 32;

            return r;
        }
    }
}
