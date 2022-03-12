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
            string nome;
            DataCronologica datanasc;
            int d, m, a;
            Console.WriteLine("Digite o nome.");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o dia de nascimento.");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mês de nascimento.");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano de nascimento.");
            a = Convert.ToInt32(Console.ReadLine());
            datanasc = new DataCronologica(d, m, a);
            Amigo b = new Amigo(datanasc, nome);

            Console.WriteLine("Digite o nome.");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o dia de nascimento.");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mês de nascimento.");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano de nascimento.");
            a = Convert.ToInt32(Console.ReadLine());
            datanasc = new DataCronologica(d, m, a);
            Amigo c = new Amigo(datanasc, nome);
            Console.WriteLine("Em {0}, \n{1} tem {2} anos.\n Até hoje já viveu {3} dias.",DateTime.Now,b,datanasc.idade(),datanasc.idade(a));
            Console.WriteLine("Em {0}, \n{1} tem {2} anos.\n Até hoje já viveu {3} dias.", DateTime.Now, c, datanasc.idade(), datanasc.idade(a));
            Console.ReadKey();
        }
    }
}
