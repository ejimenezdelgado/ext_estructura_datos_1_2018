using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Entidades;

namespace Veterinaria.Logica
{
    public class FacturaLogica
    {
        public FacturaLogica()
        {
            
        }

        public Factura AgregarFactura(List<Factura> listaFacturas, Cliente cliente, List<Diagnostico> diagnosticos, string descripcion)
        {
            float precio = 0;
            foreach (var item in diagnosticos)
            {
                precio += item.precio;
            }
            Factura factura = new Factura(listaFacturas.Count+1,DateTime.Now, precio, cliente, descripcion);
            foreach (var item in diagnosticos)
            {
                factura.diagnosticos.Add(item);
            }
            return factura;
        } 

    }
}
