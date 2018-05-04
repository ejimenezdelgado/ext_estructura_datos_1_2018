using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_pila_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de numeros a ingresar");
            int cantidad = int.Parse(Console.ReadLine());
            Stack miPila = new Stack();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el numero");
                int numero = int.Parse(Console.ReadLine());
                if (numero%2 == 0)
                {
                    miPila.Push(numero);
                }
                else
                {
                    Console.WriteLine(numero);
                }
            }
            for (int i = 0; i <= miPila.Count; i++)
            {
                Console.WriteLine(miPila.Pop());
            }
            Console.ReadLine();
        }
    }
}
