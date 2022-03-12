using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class EstudanteInf
    {
        private string Nome;
        private double Teste1;
        private double Teste2;
        public string PNome
        {
            get
            {
                return Nome;
            }
            set
            {
                Nome = value;
            }
        }
        public double PTeste1
        {
            get
            {
                return Teste1;
            }
            set
            {
                Teste1 = value;
            }
        }
        public double PTeste2
        {
            get
            {
                return Teste2;
            }
            set
            {
                Teste2 = value;
            }
        }
        public EstudanteInf()
        {
            Nome = "";
            Teste1 = 0;
            Teste2 = 0;
        }
        public EstudanteInf(string nome, double teste1, double teste2)
        {
            Nome = nome;
            Teste1 = teste1;
            Teste2 = teste2;
        }
        public double ClassFinal()
        {
            return ((Teste1 + Teste2) / 2);
        }
    }
}
