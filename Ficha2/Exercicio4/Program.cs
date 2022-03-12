using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            char enter;
            int vog, dgn, cpt, oct;
            vog = 0; dgn = 0; cpt = 0; oct = 0;
            Console.Write("Insira um caracter. Quando premir espaço acabará.");
            enter = Convert.ToChar(Console.ReadLine());
            enter = Char.ToLower(enter);

            while (enter != ' ')
            {

                switch (enter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vog++;
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        dgn++;
                        break;
                    case ':':
                    case '.':
                    case ',':
                    case ';':
                    case '!':
                    case '?':
                        cpt++;
                        break;
                    default:
                        oct++;
                        break;
                }
                Console.Write("Insira um caracter. Quando premir espaço acabará.");
                enter = Convert.ToChar(Console.ReadLine());
                enter = Char.ToLower(enter);
            }
            Console.WriteLine("Há {0} vogais, {1} digitos, {2} pontuação, {3} outros.", vog, dgn, cpt, oct);
            Console.ReadKey();
        }
    }
}
