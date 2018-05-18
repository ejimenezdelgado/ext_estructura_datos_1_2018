using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Entidades;
using Veterinaria.Logica;

namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes=new List<Cliente>();
            List<Animal> animales = new List<Animal>();
            List<Diagnostico> diagnosticos = new List<Diagnostico>();
            List<Factura> facturas = new List<Factura>();
            
            FacturaLogica oFacturaLogica=new FacturaLogica();
            AnimalLogica oAnimalLogica = new AnimalLogica();
            DiagnosticoLogica oDiagnosticoLogica = new DiagnosticoLogica();
            ClienteLogica oClienteLogica = new ClienteLogica();

            Cliente oCliente;
            Animal oAnimal;
            Diagnostico oDiagnostico;
            Factura oFactura;

            Random oRandom=new Random(23231);

            for (int i = 0; i < 100; i++)
            {
                diagnosticos.Add(
                    oDiagnosticoLogica.AgregarDiagnostico(diagnosticos, "Dianostico " + i, float.Parse((oRandom.NextDouble() * 100.0 - (100.0 / 2.0)).ToString())));
            }


            for (int i = 0; i < 100; i++)
            {
                try
                {
                    animales.Add(oAnimalLogica.AgregarAnimal(animales, "Animal" + i, float.Parse((oRandom.NextDouble() * 100.0 - (100.0 / 2.0)).ToString()), diagnosticos.GetRange(oRandom.Next(1, 100), oRandom.Next(1, 100))));
                }
                catch (Exception)
                {
                    i--;
                }
                
            }

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    clientes.Add(oClienteLogica.AgregarCliente(clientes, "Factura" + i, animales.GetRange(oRandom.Next(1, 100), oRandom.Next(1, 100))));
                }
                catch (Exception)
                {
                    i--;
                }
            }

            for (int i = 0; i < oRandom.Next(1, 100); i++)
            {
                try
                {
                    facturas.Add(oFacturaLogica.AgregarFactura(facturas, clientes.ElementAt(oRandom.Next(1, 100)), diagnosticos.GetRange(oRandom.Next(1, 100), oRandom.Next(1, 100)),"Descripcion"+i));
                }
                catch (Exception)
                {
                    i--;
                }
            }

            foreach (var item in clientes)
            {
                Console.WriteLine(item.id + " - "+ item.nombre);
                foreach (var item2 in item.animales)
                {
                    Console.WriteLine(item2.id + " - " + item2.nombre + " - " + item2.peso);
                }
            }
            Console.ReadLine();

        }
    }
}
