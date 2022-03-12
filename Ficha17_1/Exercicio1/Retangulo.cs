using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Retangulo:Quadrado 
    {
        private double largura;
   public Retangulo(double larg,double comprimento):base(comprimento)
        {
            largura = larg;
        }
        public override double areaa()
        {
            double area = 0;
            area += largura * comprimento;
            return area;
        }
        public string dimensoes()
        {
            string dimensao = "dimensões "+largura + "x" + comprimento + "=" + areaa();
              return dimensao;  
        }
    }
}
