using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,mai;
            int idade=0, maior=0, i = 0;

            Console.WriteLine("Digite o nome do {0}º aluno.", ++i);
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do {0}º aluno.", i);
            idade = Convert.ToInt32(Console.ReadLine());
            maior = idade;
            mai = nome;
            while (i<15)
                {
                Console.WriteLine("Digite o nome do {0}º aluno.", ++i);
                nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do {0}º aluno.", i);
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade>maior)
                {
                    maior = idade;
                    mai = nome;
                }
                
            }
            Console.WriteLine("O aluno com maior idade é: {0}", mai);
            Console.ReadKey();
        }
    }
}
