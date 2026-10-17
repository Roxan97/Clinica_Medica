using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Medica.Modelos
{
   public class Doctores
    {
        public int IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdEspecialidad { get; set; }
        public bool activo { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_modificacion { get; set; }
    }
}
