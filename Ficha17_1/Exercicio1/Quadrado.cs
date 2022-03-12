using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Quadrado
    {
        protected double comprimento;

        public Quadrado(double comp)
        {
            comprimento = comp;
        }
        public double acess
        {
            get
            { return comprimento; }
            set
            { comprimento = value; }
        }
        public virtual double areaa()
        {
           double area = 0;
            area+= comprimento * comprimento;
            return area;
        }
    }
}
