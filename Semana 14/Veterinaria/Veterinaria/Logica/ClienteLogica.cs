using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Entidades;

namespace Veterinaria.Logica
{
    public class ClienteLogica
    {
        public ClienteLogica()
        {

        }

        public Cliente AgregarCliente(List<Cliente> clientes, string nombre, List<Animal> animales)
        {
            Cliente oCliente = new Cliente(clientes.Count + 1, nombre);
            foreach (var item in animales)
            {
                oCliente.animales.Add(item);
            }
            return oCliente;
        }
    }
}
