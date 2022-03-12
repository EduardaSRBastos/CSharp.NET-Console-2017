using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class RaizQuad
    {
        public RaizQuad()
        { }
        public int raizquadrada(int n)
        {
            return (int)Math.Sqrt(n);
        }      
        public double raizquadrada(double n, int qntd)
        {
            return Math.Round(Math.Sqrt(n), qntd);
        }
        public double raizquadrada(double n)
        {
            return Math.Round(Math.Sqrt(n), 2);
        }
    }
}
