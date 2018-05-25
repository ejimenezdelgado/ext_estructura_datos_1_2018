using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades;

namespace Libreria.Controlador
{
    public class ControladorLibro
    {
        public void Agregar(Libro libro)
        {
            Program.libros.Add(libro);
        }

        public void Editar(Libro libro)
        {
            Libro editar = null;
            foreach (var item in Program.libros)
            {
                if (item.Id == libro.Id)
                {
                    editar = item;
                    break;
                }
            }
            int index = Program.libros.IndexOf(editar);
            Program.libros[index] = libro;
        }
        public void Eliminar(Libro libro)
        {
            Libro eliminar = null;
            foreach (var item in Program.libros)
            {
                if (item.Id == libro.Id)
                {
                    eliminar = item;
                    break;
                }
            }
            Program.libros.Remove(eliminar);
        }
        public List<Libro> Todos()
        {
            return Program.libros;
        }
    }
}
