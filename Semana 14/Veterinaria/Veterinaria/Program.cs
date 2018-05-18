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

            Cliente oCliente = new Cliente(clientes.Count+1,"Carlos");
            FacturaLogica oFacturaLogica=new FacturaLogica();
            oFacturaLogica.AgregarFactura(facturas, oCliente,null,"Pago efectivo");
        }
    }
}
