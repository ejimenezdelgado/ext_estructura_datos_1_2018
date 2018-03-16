using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.Write("Digite un numero donde sea finalizar el rango");
            string linea = Console.ReadLine();
            int valor = int.Parse(linea);
            while (x <= valor)
            {
                Console.WriteLine(x);
                Console.WriteLine("-");
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
