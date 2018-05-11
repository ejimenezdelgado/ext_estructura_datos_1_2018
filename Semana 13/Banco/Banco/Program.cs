using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cuenta[] cuentas;
            Console.WriteLine("Cuantas cuentas van a ingresar");
            int cantidad = Int32.Parse(Console.ReadLine());
            cuentas=new Cuenta[cantidad];
            bool bandera = false;
            while (bandera==false)
            {
                Console.WriteLine("1. Agregar cuenta");
                Console.WriteLine("2. Realizar deposito");
                Console.WriteLine("3. Realizar retiro");
                Console.WriteLine("4. Imprimir cuenta");
                Console.WriteLine("5. Salir");

                int opcion = Int32.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Digite el usuario");
                    int usuario = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite el saldo inicial");
                    float saldo = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite la observacion");
                    string observacion = Console.ReadLine();

                    Console.WriteLine("Digite 1. Debito/2. Credito");
                    int tipoCuenta = int.Parse(Console.ReadLine());

                    if (tipoCuenta == 1)
                    {
                        Cuenta oCuenta = new Cuenta(usuario, saldo, observacion,TipoCuenta.debito);
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (cuentas[i] == null)
                            {
                                cuentas[i] = oCuenta;
                            }
                            break;
                        }
                    }
                    else
                    {
                        Cuenta oCuenta = new Cuenta(usuario, saldo, observacion, TipoCuenta.credito);
                    }
                    
                }

            }
        }
    }
}
