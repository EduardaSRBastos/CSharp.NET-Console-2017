using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0,media=0,soma=0;
            int[] vetor = new int[20];
            for (int i = 1; i != 11; i++)
            {
                Console.WriteLine("Digite o {0}º número.", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + vetor[i];
            }
            Console.WriteLine("1- Leitura de 10 números.");
            Console.WriteLine("2- Mostra elementos.");
            Console.WriteLine("3- Inverte valores lidos.");
            Console.WriteLine("4- Média dos elementos lidos.");
            Console.WriteLine("5- Fim.");
            Console.WriteLine("Entre com uma opção:");
            num =Convert.ToInt32(Console.ReadLine());
            if (num==1)
            {
                for (int i = 1; i != 11; i++)
                {
                    Console.WriteLine("Digite o {0}º número.", i);
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                    soma = soma + vetor[i];

                }
                

            }
            Console.WriteLine("");
            Console.WriteLine("1- Leitura de 10 números.");
            Console.WriteLine("2- Mostra elementos.");
            Console.WriteLine("3- Inverte valores lidos.");
            Console.WriteLine("4- Média dos elementos lidos.");
            Console.WriteLine("5- Fim.");
            Console.WriteLine("Entre com uma opção:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num==2)
            {
                for (int i = 1; i != 11; i++)
                {
                    Console.Write(" {0} ", vetor[i]);

                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("1- Leitura de 10 números.");
            Console.WriteLine("2- Mostra elementos.");
            Console.WriteLine("3- Inverte valores lidos.");
            Console.WriteLine("4- Média dos elementos lidos.");
            Console.WriteLine("5- Fim.");
            Console.WriteLine("Entre com uma opção:");
            num = Convert.ToInt32(Console.ReadLine());
             if (num == 3)
                {
                Array.Reverse(vetor);
                for (int i = 1; i != 11; i++)
                {
                    Console.Write(" {0} ", vetor[i]);

                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("1- Leitura de 10 números.");
            Console.WriteLine("2- Mostra elementos.");
            Console.WriteLine("3- Inverte valores lidos.");
            Console.WriteLine("4- Média dos elementos lidos.");
            Console.WriteLine("5- Fim.");
            Console.WriteLine("Entre com uma opção:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 4)
            {
                media = media + (soma / 2);
                
            }
            Console.WriteLine("Média: {0}", media);
            Console.WriteLine("");
            Console.WriteLine("1- Leitura de 10 números.");
            Console.WriteLine("2- Mostra elementos.");
            Console.WriteLine("3- Inverte valores lidos.");
            Console.WriteLine("4- Média dos elementos lidos.");
            Console.WriteLine("5- Fim.");
            Console.WriteLine("Entre com uma opção:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 5)
            {
                Environment.Exit(0);
                Console.WriteLine("Sair.");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Não digitou um número de 1 a 5.");
                Console.WriteLine("");
                Console.WriteLine("1- Leitura de 10 números.");
                Console.WriteLine("2- Mostra elementos.");
                Console.WriteLine("3- Inverte valores lidos.");
                Console.WriteLine("4- Média dos elementos lidos.");
                Console.WriteLine("5- Fim.");
                Console.WriteLine("Entre com uma opção:");
                num = Convert.ToInt32(Console.ReadLine());
            }  
                 
        }
    }
}
