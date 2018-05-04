using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_cola_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de hipopotamo");
            int cantidad = int.Parse(Console.ReadLine());
            Queue miPila = new Queue();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el peso del hipopotamo");
                float numero = float.Parse(Console.ReadLine());
                miPila.Enqueue(numero);
            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("El peso es de : "+miPila.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
