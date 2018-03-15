using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto = 0;
            int residuo = 0;
            Console.WriteLine("Bienvenidos al mejor cajero del mundo");
            Console.WriteLine("Digite el monto en euros");
            monto = int.Parse(Console.ReadLine());

            if (monto >= 500)
            {
                Console.WriteLine(monto/500 + " billetes de 500");
                residuo = monto%500;
            }
            else
            {
                residuo = monto;
            }
            if (residuo >= 200)
            { 
                Console.WriteLine(residuo / 200 + " billetes de 200");
                residuo = residuo % 200;
            }
            Console.ReadLine();
        }
    }
}
