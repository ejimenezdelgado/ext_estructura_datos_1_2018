using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int auxiliar = 0;
            int numeroDecimal = 0;
            int unidad = 0;
            string linea = "";
            /*Imprimir en consola*/
            Console.WriteLine("INGRESE NÚMERO " +
                              "DE DOS CIFRAS :");
            /*Solicitar en consola*/
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            numeroDecimal = numero / 10;
            unidad = numero % 10;
            auxiliar = (unidad * 10) + numeroDecimal;
            Console.WriteLine("NÚMERO INVERTIDO ES: "
                + auxiliar);
            Console.WriteLine("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
