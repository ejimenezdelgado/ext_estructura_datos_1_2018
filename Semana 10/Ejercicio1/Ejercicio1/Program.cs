using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("El mejor sistemita");
            int cantidad = 0;
            Console.WriteLine("Digite la cantidad de numero");
            cantidad =Int32.Parse(Console.ReadLine());
            int digitado = 0;
            int suma = 0;
            int[] numeritos = new int[cantidad]; 
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite la cantidad de numero");
                digitado = Int32.Parse(Console.ReadLine());
                numeritos[i] = digitado;
            }
            for (int i = 0; i < cantidad; i++)
            {
                suma = suma + numeritos[i];
            }
            Console.WriteLine("La sumatoria es"+ suma);
            Console.ReadLine();
        }
    }
}
