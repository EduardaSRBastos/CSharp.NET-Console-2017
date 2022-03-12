using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
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
                A[i].SomaNotas();
            }
            Console.WriteLine("Nome dos Alunos Aprovados:");
            for (i = 0; i < N; i++)
            {
                if(A[i].aprovado()== "Aluno Aprovado.")
                { Console.WriteLine("{0}", A[i].PNome); }              
            }
            Console.WriteLine("Classificações Finais: {0}", EstudanteInf.CalculaMediaClassFinal());
            Console.Write("Número de alunos que obtiveram nota positiva em pelo menos um teste: {0}", EstudanteInf.LerPositivas());            
            Console.ReadKey();
        }
    }
}
