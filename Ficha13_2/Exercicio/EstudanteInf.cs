using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class EstudanteInf
    {
         private string nome;
        private double teste1, teste2;
        //método construtor:
        public EstudanteInf(string nomeAluno,double t1, double t2)
        {
            nome = nomeAluno;
            teste1 = t1;
            teste2 = t2;
        }
        public EstudanteInf()
        {}
        public double ClassFinal()
        {
            double media;
            media= (teste1 + teste2)/2;
            return media;
        }
        public string GetNome()
        {
            return nome;
        }
        public void setNome(string Nome)
        {
            nome = Nome;
        }
        public void setTeste1(double Teste1)
        {
            teste1=Teste1;
        }
        public void setTeste2(double Teste2)
        {
            teste2 = Teste2;
        }
        public double LerTeste1()
        {
            return teste1;
        }
        public double LerTeste2()
        {
            return teste2;
        }
        public void MostrarDados()
        {
            Console.WriteLine("Nome do aluno: {0}", nome);
            Console.WriteLine("Nota do teste 1: {0}", teste1);
            Console.WriteLine("Nota do teste 2: {0}", teste2);
        }
        public string imprimir()
        {
            string imprime= "A nota do teste 1 é: " + Convert.ToString(teste1) + "; a nota do teste 2 é: " + Convert.ToString(teste2) + "; a nota final dos testes é: "+ Convert.ToString(((teste1+teste2)/ 2))+ " e o aluno chama-se: " + nome;
            return imprime;
        }
    }
}
