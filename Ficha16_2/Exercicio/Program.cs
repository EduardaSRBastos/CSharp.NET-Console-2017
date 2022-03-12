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
            string pro= "J & P", loca="Porto";
            int ni = 50090050;
            string prop = "G & H", tipo = "T2";
            int area = 120, nif = 50080060;
            Apartamento novo=new Apartamento(prop,nif,tipo,area);
            Moradia novas = new Moradia(pro,ni,loca);
        }
    }
}
