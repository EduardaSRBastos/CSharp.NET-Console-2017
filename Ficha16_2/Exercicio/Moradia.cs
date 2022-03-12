using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Moradia : Propriedade
    {
        private string local;
        private char cat;
        public Moradia(string pro,int ni,string loca):base (pro,ni)
        {
            local = loca;
            cat = cats();
        }
        public char cats()
        {
            cat = ' ';
           switch(local)
            {
                case "Lisboa":
                    {
                        cat = 'A';
                        break;
                    }
                case "Porto":
                    {
                        cat = 'B';
                        break;
                    }
                case "Coimbra":
                    {
                        cat = 'C';
                        break;
                    }
                case "Braga":
                    {
                        cat = 'D';
                        break;
                    }
            }
            return cat;
        }
        public double rendaMensal()
        {
            double renda=0;
            switch (cat)
            {
                case 'A':
                case 'B':
                    renda = 1000;
                    break;
                case 'C':
                    renda = 600;
                    break;
                case 'D':
                    renda = 450;
                    break;
            }
            return renda;
        }
    }
}
