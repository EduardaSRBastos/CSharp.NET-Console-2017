using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Propriedade
    {
        private string prop;
        private int nif;
        public Propriedade(string props,int nifs)
        {
            prop = props;
            nif = nifs;
        }
        public double rendamin(int area)
        {
            double renda;
            const double P1= 0.2;
            const double P2 = 0.3;
            if (area < 50)
            {
                renda = 100;
            }
            else if (area < 100)
            {
                renda = 100 + P1 * area;
            }
            else
            {
                renda = 100 + P2 * area;
            }         
            return renda;
        }
        public override string ToString()
        {
            return prop +": "+nif+".";
        }
    }
}
