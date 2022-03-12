using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Geral
    {
        private string nome;
        protected double t1, cfinal;
        public Geral (string no,double t,double c)
        {
            nome = no;
            t1 = t;
            cfinal = c;
        }
        public string getno
        {
            get { return nome; }
            set { nome = value; }
        }
        public virtual double gett
        {
            get { return t1=Math.Round(t1, MidpointRounding.AwayFromZero); }
            set { t1 = value; }
        }
        public double getc
        {
            get { return cfinal; }
            set {cfinal = value; }
        }
        public override string ToString()
        {
            cfinal = t1;
            return nome;
        }
    }
}
