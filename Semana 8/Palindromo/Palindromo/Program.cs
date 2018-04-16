using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            string[] letras;
            string temporal = "";
            string temporalAlRevez = "";
            Console.WriteLine("Bienvenidos al mejor programa de palindromo");
            Console.WriteLine("Digite la cantidad de letras que tiene la palabra");
            cantidad = int.Parse(Console.ReadLine());
            letras = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite la siguiente letra ");
                letras[i] = Console.ReadLine();
            }

            for (int i = 0; i < letras.Length; i++)
            {
                temporal = temporal + letras[i];
            }
            for (int i = letras.Length-1; i >=0; i--)
            {
                temporalAlRevez = temporalAlRevez + letras[i];
            }
            if (temporal== temporalAlRevez)
            {
                Console.WriteLine("Es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }
            Console.ReadLine();
        }
    }
}
