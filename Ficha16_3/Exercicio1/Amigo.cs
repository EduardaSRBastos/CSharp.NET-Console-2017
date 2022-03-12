using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Amigo:Pessoa
    {
        private DataCronologica DataNasc;
        public Amigo(DataCronologica data,string n):base(n)
        {
            DataNasc = data;
        }
        public DataCronologica geta
        {
            get
            { return DataNasc; }
            set { DataNasc = value; }
        }
    }
}
