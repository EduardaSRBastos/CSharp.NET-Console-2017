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
            Disciplina[] B=new Disciplina[31];
            int notas = 0;
            string Desig;
           int numAlunos=31, int somaNotas;
            for (int i = 0; i <= 31; i++)
            {
                Console.WriteLine("Intoduza a nota de IEBD");
                notas += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Intoduza a nota de TP");
                notas += Convert.ToInt32(Console.ReadLine());
                B[i] = new Disciplina(desig,numAlunos,somaNotas,notas);
            }

            
        }
    }
}
