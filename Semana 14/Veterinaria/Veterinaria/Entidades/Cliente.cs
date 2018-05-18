using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private List<Animal> animales;

        public Cliente(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            this.animales = new List<Animal>();

        }
    }
}
