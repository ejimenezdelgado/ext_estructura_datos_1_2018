using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int cantidad=0;
            int n=0;
            float largo=0;
            string linea="";
            Console.Write("Cuantas piezar procesará:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese la medida de la pieza:");
                linea = Console.ReadLine();
                largo = float.Parse(linea);
                if (largo >= 1.20 && largo <= 1.30)
                {
                    cantidad = cantidad + 1;
                }
                x = x + 1;
            }
            Console.Write("La cantidad de piezas aptas son:");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}
