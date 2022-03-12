using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = new int[500];
           
            FileStream file = new FileStream(@"E:\school\11ºAno\TP\Exercícios\Ficha8\numeros.txt", FileMode.Open, FileAccess.Read);
            FileStream filepar = new FileStream(@"E:\school\11ºAno\TP\Exercícios\Ficha8\numerosPares.txt", FileMode.Open, FileAccess.Write);
            FileStream fileimpar = new FileStream(@"E:\school\11ºAno\TP\Exercícios\Ficha8\numerosImpares.txt", FileMode.Open, FileAccess.Write);
            BinaryReader br = new BinaryReader(file);
            Console.WriteLine(br.ReadInt32());

            Console.WriteLine("Saindo");
            Console.ReadKey();
            System.Threading.Thread.Sleep(200);
        }
    }
}
