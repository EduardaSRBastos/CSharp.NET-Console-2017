using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0.5;
            Circulo[] novo = new Circulo[5];
            int x=0, y=0;
            Console.WriteLine("Coordenadas do centro: {0},{1} e área do círculo: {2}.", x, y, novo);
            for (int i=0;i<=4;i++)
            {
                x++;
                y++;
                r = r * 2;
                Console.WriteLine("Coordenadas do centro: {0},{1} e área do círculo: {2}.", x, y, novo);
            }
        }
    }
}
