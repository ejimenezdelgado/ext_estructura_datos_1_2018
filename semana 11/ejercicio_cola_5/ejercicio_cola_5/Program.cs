using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_cola_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de la fila 1");
            int cantidad1 = int.Parse(Console.ReadLine());
            Queue miPila1 = new Queue();
            for (int i = 0; i < cantidad1; i++)
            {
                Console.WriteLine("Digite los años persona "+ i+1);
                int numero = int.Parse(Console.ReadLine());
                miPila1.Enqueue(numero);
            }

            Console.WriteLine("Digite la cantidad de la fila 2");
            int cantidad2 = int.Parse(Console.ReadLine());
            Queue miPila2 = new Queue();
            for (int i = 0; i < cantidad2; i++)
            {
                Console.WriteLine("Digite los años persona " + i + 1);
                int numero = int.Parse(Console.ReadLine());
                miPila2.Enqueue(numero);
            }

            Queue miPila3 = new Queue();

            for (int i = 0; i < cantidad1; i++)
            {
                int numero = int.Parse(miPila1.Dequeue()+"");
                if (numero >= 18)
                {
                    miPila3.Enqueue(numero);
                }
            }

            for (int i = 0; i < cantidad2; i++)
            {
                int numero = int.Parse(miPila2.Dequeue() + "");
                if (numero >= 18)
                {
                    miPila3.Enqueue(numero);
                }
            }

            for (int i = 0; i <=miPila3.Count; i++)
            {
                Console.WriteLine("Entro el señor@ : " + miPila3.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
