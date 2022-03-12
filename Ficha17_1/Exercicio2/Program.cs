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
            double t1, t2,cf;
            string nomea,nomeb;
            Console.Write("Digite o seu nome: ");
            nomea =Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            t1 = Convert.ToDouble(Console.ReadLine());      
            cf = t1;
            Geral aluno1 = new Geral(nomea, t1,cf);
            Console.Write("Digite o seu nome: ");
            nomeb = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            t1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            t2 = Convert.ToDouble(Console.ReadLine());
            cf = t1;
            Informatica aluno2 = new Informatica(nomeb, t1, cf, t2);
            Console.WriteLine("Regime Geral:");
            Console.WriteLine("{0} obteve {1} valores.", nomea, cf);
            Console.WriteLine("Regime específico para Informatica:");
            Console.WriteLine("{0} obteve {1} valores.", nomeb, aluno2.med());
            Console.ReadKey();
        }
    }
}
