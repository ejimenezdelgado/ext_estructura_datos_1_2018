using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    public class Factura
    {
        private int id;
        private DateTime fecha;
        private float total;
        private Cliente cliente;
        private string descripcion;
        private List<Diagnostico> diagnosticos;

        public Factura(int id, DateTime fecha,float total,Cliente cliente,string descripcion)
        {
            this.id = id;
            this.fecha = fecha;
            this.total= total;
            this.cliente=cliente;
            this.descripcion = descripcion;
            this.diagnosticos=new List<Diagnostico>();

        }
    }
}
