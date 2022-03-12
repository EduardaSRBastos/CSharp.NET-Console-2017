using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ContaCorrente
    {
        private char transacao;
        private double valor;
        static double saldo = 0.0;
        static int num_trans;
        public ContaCorrente(double s, char t)
        {
            valor = s;
            transacao = t;
            NumTransESaldo();
        }
        public void NumTransESaldo()
        {
            num_trans++;
            if (transacao == 'D')
            { saldo = saldo + valor; }
            else if (transacao == 'L')
            { saldo = saldo - valor; }
        }
        public void ImpressaoTransESaldo()
        {
            Console.WriteLine(num_trans);
            Console.WriteLine(saldo);
        }
    }
}
