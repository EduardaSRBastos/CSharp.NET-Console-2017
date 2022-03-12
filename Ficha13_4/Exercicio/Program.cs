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
            ContaCorrente C1 = new ContaCorrente(100,'D');
            C1.ImpressaoTransESaldo();
            ContaCorrente C2 = new ContaCorrente(50, 'L');
            C2.ImpressaoTransESaldo();
            ContaCorrente C3 = new ContaCorrente(1000, 'D');
            C3.ImpressaoTransESaldo();
            ContaCorrente C4 = new ContaCorrente(500, 'L');
            C3.ImpressaoTransESaldo();
            Console.ReadKey();
        }
    }
}
