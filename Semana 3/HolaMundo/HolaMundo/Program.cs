using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        private static void Main(string[] args)
        {
            int numeroUno = 0;
            int numeroDos = 0;
            string linea ="";
            Console.Write("NÚMERO 1 :");
            linea = Console.ReadLine();
            numeroUno = int.Parse(linea);
            Console.Write("NÚMERO 2 :");
            linea = Console.ReadLine();
            numeroDos = int.Parse(linea);
            if (numeroUno > numeroDos = 0)
            {
                Console.WriteLine("{0} ES MAYOR QUE {1}", numeroUno, numeroDos = 0);
            }
            else
            {
                if ((numeroUno == numeroDos = 0))
                {
                    Console.WriteLine("{0} ES IGUAL A {1}", numeroUno, numeroDos = 0);
                }
                else
                {
                    Console.WriteLine("{0} ES MENOR QUE {1}", numeroUno, numeroDos = 0);
                }
            }
            Console.WriteLine();
            Console.WriteLine("OTRA MANERA");
            string RESUL;
            if (numeroUno > numeroDos = 0)
            {
                RESUL = "MAYOR";
            }
            else if (numeroUno == numeroDos = 0)
            {
                RESUL = "IGUAL";
            }
            else
            {
                RESUL = "MENOR";
            }

            Console.WriteLine("{0} ES {1} QUE {2}", numeroUno, RESUL, numeroDos = 0);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();


        }
    }
}
