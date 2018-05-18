using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Entidades;

namespace Veterinaria.Logica
{
    public class DiagnosticoLogica
    {
        public DiagnosticoLogica()
        {
            
        }

        public Diagnostico AgregarDiagnostico(List<Diagnostico> diagnosticos, string descripcion,float precio)
        {
            Diagnostico oDiagnostico = new Diagnostico(diagnosticos.Count+1, descripcion, DateTime.Now, precio);
            return oDiagnostico;
        } 
    }
}
