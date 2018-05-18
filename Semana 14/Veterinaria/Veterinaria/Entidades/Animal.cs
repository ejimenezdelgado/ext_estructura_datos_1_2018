using System.Collections.Generic;

namespace Veterinaria.Entidades
{
    public class Animal
    {
        private int id;
        private string nombre;
        private float peso;
        private List<Diagnostico> diagnosticos;


        public Animal(int id, string nombre,float peso)
        {
            this.id = id;
            this.nombre = nombre;
            this.peso = peso;
            this.diagnosticos = new List<Diagnostico>();
        }

    }
}
