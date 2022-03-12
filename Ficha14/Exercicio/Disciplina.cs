using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Disciplina
    {
        string desig;
        static int NumAlunos, SomaNotas;
        int notas;

        public Disciplina(string Desig, int numAlunos, int somaNotas, int Notas)
            {
            desig = Desig;
            NumAlunos = numAlunos;
            SomaNotas = somaNotas;
            notas = Notas;
            }
        public double media()
        {
            
            return notas;
        }
    }
}
