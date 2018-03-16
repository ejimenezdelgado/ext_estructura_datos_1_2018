using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int final = 10;
            int suma = 0;
            while (x <= final)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Digite un numero ");
                string linea = Console.ReadLine();
                int valor = int.Parse(linea);
                suma = suma+valor;
                Console.WriteLine("El numero es: "+x);
                Console.WriteLine("La suma va : "+ suma);
                x = x + 1;
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El promedio es: " + suma/x);
            Console.ReadKey();
        }
    }
}
