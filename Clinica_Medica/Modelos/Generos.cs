using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clinica_Medica.Modelos
{
    [Map("dbo.Generos")]
    public class Generos
    {
        [Primary]
        public int IdGenero { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_modificacion { get; set; }
    }
}

