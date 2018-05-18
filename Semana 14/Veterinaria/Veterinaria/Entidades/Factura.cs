using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    public class Factura
    {
        public int id;
        public DateTime fecha;
        public float total;
        public Cliente cliente;
        public string descripcion;
        public List<Diagnostico> diagnosticos;

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
