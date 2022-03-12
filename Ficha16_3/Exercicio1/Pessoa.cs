using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Pessoa
    {
        private string nome;

        public Pessoa(string n)
        {
            nome = n;
        }
        public string pNome
        {
            get
            { return nome; }
            set
            { nome = value; }
        }
    }
}
