using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x<=100)
            {
                Console.WriteLine(x);
                Console.WriteLine("-");
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
