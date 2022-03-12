using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Informatica:Geral
    {
        double  t2,media;
        public Informatica(string no, double t, double c,double te2):base(no,t,c)
        {        
            t2 = te2;
        }
        public double get2
        {
            get { return Math.Round(t2); }
            set { t2 = value; }
        }
        public double med()
        {
            media += (t1 + t2) / 2;
            media=Math.Round(media, MidpointRounding.AwayFromZero);
            return media;
        }
    }
}
