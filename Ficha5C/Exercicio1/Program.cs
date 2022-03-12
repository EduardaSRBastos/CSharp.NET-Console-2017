using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static int[,] m;
        static void Main(string[] args)
        {
            int dim, op, flag;
            
            flag = 0;
            
           
            do
            {
                
                Console.WriteLine("Digite a dimensão da matriz Quadrada: ");
                dim = Convert.ToInt32(Console.ReadLine());
                //valida dimensão
                if (dim < 2)
                {
                    Console.WriteLine("Dimensão da matriz Quadrada deve ser no mínimo 2\n-Prima uma tecla para continuar =>");
                    Console.ReadKey();
                    continue;
                }
                m = new int[dim, dim];
            } while (dim <= 1);
            Console.Clear();
            do
            {
                Console.WriteLine(" MENU");
                Console.WriteLine("1 -Ler Matriz Quadrada");
                Console.WriteLine("2 - Mostrar matriz");
                Console.WriteLine("3 - Diagonal Principal");
                Console.WriteLine("4 - Media");
                Console.WriteLine("5 - Maior");
                Console.WriteLine("6 - Sair");
                Console.Write("Digite uma opção:");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                Console.WriteLine("Digite um valor para a posição[ " + i + " , " + j + " ]");
                                m[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        flag = 1;
                        break;
                    case 2:
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve primeiro ler dados para a Matriz");
                            Console.ReadKey();
                            break;
                        }
                        for (int l = 0; l < dim; l++)
                        {
                            for (int c = 0; c < dim; c++)
                            {
                                Console.Write("{0} ", m[l, c]);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve primeiro ler dados para a Matriz");
                            Console.ReadKey();
                            break;
                        }
                        for (int l = 0; l < dim; l++)
                        {
                            Console.WriteLine(m[l, l]);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve primeiro ler dados para a Matriz");
                            Console.ReadKey();
                            break;
                        }
                        double media = 0;
                        for (int l = 0; l < dim; l++)
                        {
                            for (int c = 0; c < dim; c++)
                            {
                                media = media + m[l, c];
                            }
                        }
                        media = media / (dim * 2);
                        Console.WriteLine("A média da matriz é:{0} ", media);
                        Console.ReadKey();
                        break;
                    case 5:
                        int maior = m[0, 0];
                        if (flag == 0)
                        {
                            Console.WriteLine("Deve primeiro ler dados para a Matriz");
                            Console.ReadKey();
                            break;
                        }
                        for (int l = 0; l < dim; l++)
                        {
                            for (int c = 0; c < dim; c++)
                            {
                                if (m[l, c] > maior)
                                {
                                    maior = m[l, c];
                                }
                            }
                        }
                        Console.WriteLine("O maior elemento da matriz é: {0}", maior);
                        Console.ReadKey();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Esta não é uma opção válida");
                        Console.ReadKey();
                        break;
                }
            } while (op != 6);
        }
    }     
}
