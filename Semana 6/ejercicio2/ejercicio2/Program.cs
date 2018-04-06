using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al mejor sistema capicua");
            Console.WriteLine("Digite un numero");
            int numero = int.Parse(Console.ReadLine());
            string numeroInverso = "";
            int numerotemporal = numero;
            while (numerotemporal>9)
            {
                numeroInverso =  numeroInverso + "" + numerotemporal % 10;
                numerotemporal = numerotemporal/10;
            }
            numeroInverso =  numeroInverso + "" + numerotemporal;
            Console.WriteLine("El numero inverso es"+ numeroInverso);
            if (int.Parse(numeroInverso) == numero)
            {
                Console.WriteLine("El numero si es =)");
            }
            else
            {
                Console.WriteLine("Esta malin");
            }
            Console.ReadLine();
        }
    }
}
