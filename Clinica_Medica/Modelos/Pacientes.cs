using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace Clinica_Medica.Modelos
{
    public class Pacientes
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int IdGenero { get; set; }
        public int IdEspecialidad { get; set; }
        public bool activo { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_modificacion { get; set; }
    }
}

