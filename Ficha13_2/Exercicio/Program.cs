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
            int i, n;                    
            string nome;
            double teste1, teste2;           
            Console.WriteLine("Digite o número de alunos.");
            n = Convert.ToInt32(Console.ReadLine());
            EstudanteInf[] A = new EstudanteInf[n];
            for (i=0;i<n;i++)
            {
                A[i] = new EstudanteInf();
                Console.WriteLine("Digite o nome do aluno {0}", ++i);
                --i;
                nome = Console.ReadLine();
                A[i].setNome(nome);
                Console.WriteLine("Digite o valor do Teste 1");
                teste1 = Convert.ToDouble(Console.ReadLine());
                A[i].setTeste1(teste1);
                Console.WriteLine("Digite o valor do Teste 2");
                teste2 = Convert.ToDouble(Console.ReadLine());
                A[i].setTeste2(teste2);
            }
            Console.WriteLine("Aluno; Teste1; Teste2; Classificação");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(A[i].GetNome() +"; " +A[i].LerTeste1() + "; " + A[i].LerTeste2() + "; " + A[i].ClassFinal());
            }
                Console.ReadKey();
        }
    }
}
