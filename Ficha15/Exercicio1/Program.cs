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
            string nome,apelido;
            Console.WriteLine("Digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o apelido");
            apelido = Console.ReadLine();
            ApelidoNome pessoa = new ApelidoNome ( nome, apelido);

        }
    }
}
