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
           
            bool flag=false;
            int op,i=0;
            int[] num = new int[22];
            int[] maior = new int[22];
            Console.WriteLine("       Menu");
            Console.WriteLine(" 1-Leitura de 20valores\n 2-Ordenação decrescente\n 3-Mostrar valores\n 4-Sair");
            Console.WriteLine("");          
            do
            {
                Console.WriteLine("Digite a opção");
                op = Convert.ToInt32(Console.ReadLine());               
                switch (op)
                {
                    case 1:
                        flag = true;
                        leitura(i,num);
                        break;
                    case 2:
                        if(flag==false)
                        {
                            Console.WriteLine("Deve digitar a opção 1 primeiro.");
                            Console.WriteLine("");
                            break;
                        }
                        orden(i,num,maior);
                        Console.WriteLine("");
                        break;
                    case 3:
                        if (flag == false)
                        {
                            Console.WriteLine("Deve digitar a opção 1 primeiro.");
                            Console.WriteLine("");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Não digitou uma opção válida.");
                        Console.WriteLine("");
                        continue;
                }
            }
            while (op != 4);
            Console.WriteLine("Saindo");
            Console.WriteLine("");
        }
        static int leitura(int i, int[] num)
        {         
            for (i=1;i<21;i++)
            {
                Console.WriteLine("Digite o {0} valor.",i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            return num[i];
        }
        static int orden(int i,int[] num,int[] maior)
        {
            maior[0] = num[0];
            for (i = 1; i < 21; i++)
            {
                if (num[i] >= maior[i])
                {
                    maior[i] = num[i];                   
                }                
            }
            for (i = 1; i < 21; i++)
            {
                Console.Write(maior[i]);
            }
             return maior[i-1];
        } 
                   
    }
}
