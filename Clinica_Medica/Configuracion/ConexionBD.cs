using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Clinica_Medica.Configuracion
{
    public static class ConexionBD
    {
        private static readonly string cadenaConexion =
            @"Server=ROXANA\SQLEXPRESS;Database=ClinicaMedica2;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

