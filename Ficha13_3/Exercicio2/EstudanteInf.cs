using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class EstudanteInf
    {
        private string Nome;
        private double Teste1;
        private double Teste2;
        private string apro;       
        private static int Nalunos=0;
        private static double SomatorioCL=0;
        private static int Npositivas = 0;

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
        public string aprovado()
        {
            if (ClassFinal() >= 10)
            {
                apro=("Aluno Aprovado.");
            }
            else if (ClassFinal() < 10 && ClassFinal() >= 8)
            {
                apro=("Aluno Admitido a Exame Oral.");
            }
            else if (ClassFinal() < 8)
            {
               apro= ("Aluno Reprovado.");
            }
            return apro;   
        }
        public double ClassFinal()
        {
            return ((Teste1 + Teste2) / 2);
        }
        public void SomaNotas()
        {
            EstudanteInf.SomatorioCL = EstudanteInf.SomatorioCL + ClassFinal();
            EstudanteInf.Nalunos++;           
        }
        public static double CalculaMediaClassFinal()
        {
            return Math.Round(EstudanteInf.SomatorioCL /(double) EstudanteInf.Nalunos, 2, MidpointRounding.AwayFromZero);
        }
        public void IncPositivas()
        {
            if ((Teste1 >= 10) | (Teste2 >= 10))
            { Npositivas++; }        
        }
        public static int LerPositivas()
        {
            return Npositivas;
        }
    }
}
