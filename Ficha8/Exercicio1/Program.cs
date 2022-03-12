using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {                             
            int[] seq = new int[500];
            int i = 0;      
            FileStream fs =new FileStream(@"E:\school\11ºAno\TP\Exercícios\Ficha8\numeros.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(fs);
            do
            {
                i++;               
                Console.WriteLine("Digite uma sequência de números. O zero termina a sequência.");
                seq[i] = Convert.ToInt32(Console.ReadLine());
                if (seq[i]==0)
                {
                    writer.Close();
                }
                else
                    {                    
                    writer.Write(seq[i]);
                    writer.Write(" ");
                }                                          
            }
            while (seq[i] != 0);
            Console.WriteLine("Saindo");
            System.Threading.Thread.Sleep(200);            
        }
    }
}
