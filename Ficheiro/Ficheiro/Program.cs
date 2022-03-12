using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz1234567890";           
            string user, pass, encrypt= string.Empty,zed = string.Empty;
            string converted = string.Empty;
            try
            {
                //mudar localização:
                FileStream file = new FileStream(@"I:\school\11ºAno\TP\Exercícios\Ficheiro\programa.txt", FileMode.Append, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(file);
                Console.Write("Digite o nome de utilizador: ");
                user = Console.ReadLine();
                writer.Write(Environment.NewLine + "Utilizador:");
                byte[] binario = Encoding.ASCII.GetBytes(user);
                for (int i = 0; i < binario.Length; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        converted += (binario[i] & 0x80) > 0 ? "1" : "0";
                        binario[i] <<= 1;
                    }
                }
                writer.Write(converted);
                Console.Write("Digite a password:");
                pass = Console.ReadLine();
                writer.Write(Environment.NewLine + "Pass: ");          
                for (int i = 0; i < pass.Length; i++)
                {                   
                    int pos = alfabeto.IndexOf(pass[i]);
                    pos++;
                    encrypt = Convert.ToString(alfabeto[pos]);
                    writer.Write(encrypt);
                    value = System.Convert.ToInt32(alfabeto[pos]);
                    zed = String.Format("{0:X}", value);                   
                    writer.Write(zed);               
                }      
                writer.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
