using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Circulo : Centro
    {
        private double raio;
        public Circulo(int x, int y, double R) : base(x, y)
        { raio = R; }
        public double Area()
        { return Math.Round(Math.PI * Math.Pow(raio, 2), 2); }
    }
}
