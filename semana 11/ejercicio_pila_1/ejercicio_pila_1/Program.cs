using System;
using System.Collections;

namespace ejercicio_pila_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de numeros a ingresar");
            int cantidad=int.Parse(Console.ReadLine());
            Stack miPila = new Stack();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el numero");
                int numero = int.Parse(Console.ReadLine());
                miPila.Push(numero);
            }
            int suma = 0;
            for (int i = 0; i < cantidad; i++)
            {
                suma = suma + int.Parse(miPila.Pop()+"");
            }
            Console.WriteLine("La suma "+ suma);
            Console.ReadLine();
        }
    }
}
