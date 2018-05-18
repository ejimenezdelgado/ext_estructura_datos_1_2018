using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    public class Cliente
    {
        public int id;
        public string nombre;
        public List<Animal> animales;

        public Cliente(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            this.animales = new List<Animal>();

        }
    }
}
