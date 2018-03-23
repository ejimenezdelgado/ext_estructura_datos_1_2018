using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al mejor sistemita decimal :p");
            Console.WriteLine("Digite el numero binario mop");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;
            int sumatoria = 0;
            int digito = 0;
            while (contador <=9)
            {
                digito= numero % 10;
                sumatoria = sumatoria+int.Parse(Math.Pow((digito * 2), contador)+"");
                contador = contador + 1;
                numero = numero / 10;
            }
            Console.WriteLine("El numero es "+ sumatoria);
            Console.ReadLine();
        }
    }
}
