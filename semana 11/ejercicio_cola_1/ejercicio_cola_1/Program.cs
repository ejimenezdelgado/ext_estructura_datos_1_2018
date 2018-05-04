using System;
using System.Collections;

namespace ejercicio_cola_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de numeros a ingresar");
            int cantidad = int.Parse(Console.ReadLine());
            Queue miPila = new Queue();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el numero");
                int numero = int.Parse(Console.ReadLine());
                miPila.Enqueue(numero);
            }
            int suma = 0;
            for (int i = 0; i < cantidad; i++)
            {
                suma = suma + int.Parse(miPila.Dequeue() + "");
            }
            Console.WriteLine("La suma " + suma);
            Console.ReadLine();
        }
    }
}
