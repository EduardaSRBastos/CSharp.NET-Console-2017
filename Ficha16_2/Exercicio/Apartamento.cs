using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Apartamento : Propriedade
    {
        private string tipo;
        private int area;
        public Apartamento(string pro, int ni,string tip,int areas): base (pro,ni)
        {
            tipo = tip;
            area = areas;
        }
        public int areass
            {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
            }
    }
}
