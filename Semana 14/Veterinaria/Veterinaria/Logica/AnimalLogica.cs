using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Entidades;

namespace Veterinaria.Logica
{
    public class AnimalLogica
    {
        public AnimalLogica()
        {

        }

        public Animal AgregarAnimal(List<Animal> animales, string nombre, float peso, List<Diagnostico> diagnosticos)
        {
            Animal oAnimal = new Animal(animales.Count + 1, nombre, peso);
            foreach (var item in diagnosticos)
            {
                oAnimal.diagnosticos.Add(item);
            }
            return oAnimal;
        }
    }
}
