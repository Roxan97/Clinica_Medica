using System;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepoDb;
using Clinica_Medica.Configuracion;

namespace Clinica_Medica.Repositorios
{
    public class RepositorioGenerico<T> where T : class
    {
        // CONSULTAR TODOS
        public async Task<List<T>> ObtenerTodosAsync()
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                var datos = await conexion.QueryAllAsync<T>();
                return datos.ToList();
            }
        }

        // CONSULTAR POR ID
        public async Task<T> ObtenerPorIdAsync(int id)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                var datos = await conexion.QueryAsync<T>(id);
                return datos.FirstOrDefault();
            }
        }

        // INSERTAR
        public async Task<int> InsertarAsync(T entidad)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                return await conexion.InsertAsync<T, int>(entidad);
            }
        }

        // ACTUALIZAR
        public async Task<int> ActualizarAsync(T entidad)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                return await conexion.UpdateAsync<T>(entidad);
            }
        }

        // ELIMINAR
        public async Task<int> EliminarAsync(int id)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                return await conexion.DeleteAsync<T>(id);
            }
        }
    }
}
