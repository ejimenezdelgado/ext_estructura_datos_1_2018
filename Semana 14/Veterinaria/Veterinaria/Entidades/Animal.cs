using System.Collections.Generic;

namespace Veterinaria.Entidades
{
    public class Animal
    {
        public int id;
        public string nombre;
        public float peso;
        public List<Diagnostico> diagnosticos;


        public Animal(int id, string nombre,float peso)
        {
            this.id = id;
            this.nombre = nombre;
            this.peso = peso;
            this.diagnosticos = new List<Diagnostico>();

        }

    }
}
