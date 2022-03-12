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
        EstudanteInf Estudante;
        string nome;
        double teste1, teste2;
            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do Teste 1");
            teste1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do Teste 2");
            teste2 = Convert.ToDouble(Console.ReadLine());
            Estudante = new EstudanteInf(nome, teste1, teste2);
            Console.WriteLine("Classificação final: {0}", Estudante.ClassFinal());
            EstudanteInf Estudante2 = new EstudanteInf();
            Console.WriteLine(Estudante.imprimir());
            Console.ReadKey();
        }
    }
}
