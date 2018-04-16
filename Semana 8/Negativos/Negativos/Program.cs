using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int[] numeros;
            Console.WriteLine("Bienvenidos al mejor programa de duplicados");
            Console.WriteLine("Digite la cantidad de numeros a insertar");
            cantidad = int.Parse(Console.ReadLine());
            numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el numero " + (i + 1));
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i]<0)
                {
                    numeros[i] = 0;
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadLine();
        }
    }
}
