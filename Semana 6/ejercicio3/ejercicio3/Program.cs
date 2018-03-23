using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al mejor sistemita binario :D");
            Console.WriteLine("Digite el numerazo menecazo");
            int numero = int.Parse(Console.ReadLine());
            while (numero >= 1)
            {
                Console.WriteLine((numero%2) +"holis");
                numero = numero/2;
            }
            Console.ReadLine();
        }
    }
}
