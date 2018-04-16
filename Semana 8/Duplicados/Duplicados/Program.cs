using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicados
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            string[] palabras;
            string[] duplicado;
            int[] vecesRepetido;
            Console.WriteLine("Bienvenidos al mejor programa de duplicados");
            Console.WriteLine("Digite la cantidad de palabras a insertar");
            cantidad = int.Parse(Console.ReadLine());
            palabras = new string[cantidad];
            duplicado = new string[cantidad];
            vecesRepetido = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite la palabras numero " + (i + 1));
                palabras[i] = Console.ReadLine();
            }

            for (int i = 0; i < cantidad; i++)
            {
                EsDuplicado(palabras, palabras[i], duplicado, vecesRepetido);
            }
            for (int i = 0; i < duplicado.Length; i++)
            {
                if (duplicado[i] != null)
                {
                    Console.WriteLine(duplicado[i] + " : " + vecesRepetido[i]);
                }
            }
            Console.ReadLine();
        }
        
        public static void EsDuplicado(string[] palabras, string palabra, string[] duplicados, int[] vecesRepetido)
        {
            int cantidad = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabra == palabras[i])
                {
                    cantidad = cantidad + 1;
                }
            }
            if (cantidad > 1)
            {
                for (int i = 0; i < duplicados.Length; i++)
                {
                    if (duplicados[i] != palabra)
                    {
                        if (duplicados[i] == null)
                        {
                            duplicados[i] = palabra;
                            vecesRepetido[i] = cantidad;
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }        
    }
}
