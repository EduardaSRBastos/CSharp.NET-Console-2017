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
            int tam, mat, op ,maio=0,flag=0;
            double s = 0, med = 0;
            Console.WriteLine("Digite a quantidade de linhas e colunas.");
            tam = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[tam, tam];
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("----------------------------------------Menu----------------------------------------");
                Console.WriteLine(" 1- Ler Matriz Quadrada.\n 2- Ver Matriz.\n 3- Diagonal Principal.\n 4- Média.\n 5- Maior.\n 6- Sair...");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite a opção:");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        mat = ler(ref tam, ref matriz, ref s);
                        flag = 1;
                        break;
                    case 2:
                        {
                            if (flag == 0)
                            {
                                Console.WriteLine("Deve digitar a opção '1' primeiro.");
                               break;
                            }
                        }
                        mat = ver(ref tam, ref matriz);
                        break;
                    case 3:
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve digitar a opção '1' primeiro.");
                            break;
                        }
                        mat = dia(ref tam, ref matriz);
                        break;
                    case 4:
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve digitar a opção '1' primeiro.");
                            break;
                        }
                        mat = meda(ref tam, ref matriz, ref med, ref s);
                        break;
                    case 5:
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve digitar a opção '1' primeiro.");
                            break;
                        }
                        mat = maior(ref tam, ref matriz, ref maio);
                        break;
                    default:
                        Console.WriteLine("Não digitou a opção correta.");
                        break;
                }                 
                }
                while (op != 6) ;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saindo...");
            Console.ResetColor();
            System.Threading.Thread.Sleep(300);
            Environment.Exit(0);
            //blackcat8

        }
        static int ler(ref int tam, ref int[,] matriz, ref double s)
        {
            int[,] matri = new int[tam, tam];
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.WriteLine("Digite um valor para a posição ({0},{1})", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    s += matriz[i, j];
                }
            }
            return tam;
        }
        static int ver(ref int tam, ref int[,] matriz)
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < tam; i++)
            {
                Console.Write(" {0} ", matriz[i, 0]);
            }
            Console.WriteLine("");
            for (int j = 0; j < tam; j++)
                {
                    
                    Console.Write( " {0} ", matriz[0,j]);
                }
            
            Console.WriteLine("");
            return matriz[tam - 1, tam - 1];
        }
        static int dia(ref int tam, ref int[,] matriz)
        {
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    i = j;
                    Console.WriteLine("Diagonal principal na posição ({0},{1}): {2}", i, j, matriz[i, j]);
                }
            }
            return matriz[tam - 1, tam - 1];
        }
        static int meda(ref int tam, ref int[,] matriz, ref double med, ref double s)
        {
            med = 0;

            med = med + s / (tam * tam);
            Console.WriteLine("Média: {0}", med);

            return matriz[tam - 1, tam - 1];
        }
        static int maior(ref int tam, ref int[,] matriz, ref int maior)
        {
            maior = matriz[0, 0];
            for (int i = 1; i < tam; i++)
            {
                for (int j = 1; j < tam; j++)
                {
                    if (matriz[i, j] >= maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }
            Console.WriteLine("O maior valor inserido é: {0}", maior);
            return maior;
        }
    }
}
