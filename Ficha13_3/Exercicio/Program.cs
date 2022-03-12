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
            string nome;
            double teste1, teste2;
            int i, N;
            EstudanteInf[] A;

            Console.Write("Entre com o Número de alunos: ");
            N = Convert.ToInt32(Console.ReadLine());
            A = new EstudanteInf[N];
            for (i = 0; i < N; i++)
            {
                A[i] = new EstudanteInf();
                Console.Write("Nome do aluno:");
                nome = Console.ReadLine();
                Console.Write("Teste1:");
                teste1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Teste2:");
                teste2 = Convert.ToDouble(Console.ReadLine());
                A[i].PNome = nome;
                A[i].PTeste1 = teste1;
                A[i].PTeste2 = teste2;
            }
            Console.WriteLine("Nome          Teste 1     Teste 2   Classificação");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("{0}   -   {1}      -     {2}    -  {3}", A[i].PNome, A[i].PTeste1, A[i].PTeste2, A[i].ClassFinal());
            }
            Console.ReadKey();
        }
    }
}

