using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            case1:
            int op = 0,flag=0,i=0,qntd=0;
            string turma;
            int[] idade = new int[30];
            string[] ida = new string[30];
            Console.WriteLine("");
            Console.WriteLine("            Menu");
            Console.WriteLine("1 – Entrada de Dados\n2 – Listar Alunos dada uma idade\n3 – Listar os Alunos que iniciam o Nome por uma dada Letra\n4 – Sair");
            Console.WriteLine("");
            Console.Write("Digite a opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    flag = 1;
                    case2:
                    Console.WriteLine("Quantidade de alunos:");
                    qntd = Convert.ToInt32(Console.ReadLine());
                    if (qntd>30)
                    {
                        Console.WriteLine("A lista de alunos tem no máximo 30 nomes e respectivos dados.");
                        Console.WriteLine("");
                        goto case2;
                    }
                    for(i=0;i<=qntd-1;i++)
                        {                       
                        Console.WriteLine("Digite o nome do aluno");
                        ida[i] = Console.ReadLine();
                        Console.WriteLine("Digite a turma do aluno");
                        turma = Console.ReadLine();
                        Console.WriteLine("Digite a idade do aluno");
                        idade[i] = Convert.ToInt32(Console.ReadLine());  
                                                             
                    }
                    goto case1;                                     
                case 2:
                    if (flag==0)
                    {
                        Console.WriteLine("Deve digitar a opção 1 primeiro.");
                        goto case1;
                    }
                    idades(ref idade, ref qntd, ref ida);             
                    
                  
                    break;
            }
            Console.ReadKey();
        }
        static int idades(ref int[] idade,ref int qntd, ref string[] ida)
        {
            int idad = 0;
            Console.WriteLine("Digite uma idade.");
            idad = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=qntd;i++)
            {
                if (idad == idade[i])
                {
                    Console.WriteLine("Alunos com a idade {0}: {1}", idade, ida[i]);
                }
            }
            
            return idad;
        }
    }
}
