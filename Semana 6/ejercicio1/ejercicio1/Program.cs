using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al mejor sistema del mundo");
            Console.WriteLine("Digite el numero 1");
            int numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero 2");
            int numero2= int.Parse(Console.ReadLine());
            /*Variables para el contador y la sumatoria*/
            int contador1 = 1;
            int contador2 = 1;
            int sumatoriaNumero1 = 0;
            int sumatoriaNumero2 = 0;
            //Ciclos para obterner los divisores de los numeros 
            while (contador1 <= numero1)
            {
                if (numero1%contador1 == 0)
                {
                    sumatoriaNumero1 = sumatoriaNumero1 + contador1;
                }
                contador1 = contador1 + 1;
            }

            while (contador2 <= numero2)
            {
                if (numero2 % contador2 == 0)
                {
                    sumatoriaNumero2 = sumatoriaNumero2 + contador2;
                }
                contador2 = contador2 + 1;
            }
            if (sumatoriaNumero1 == sumatoriaNumero2)
            {
                Console.WriteLine("Son numeritos amigos");
            }
            else
            {
                Console.WriteLine("No son numeritos amigos :( ");
            }
            Console.ReadLine();
        }
    }
}
