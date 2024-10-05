using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudUsuarios
{
    public class DAO
    {
        public static int Agregar(Usuarios usuario)
        {
            int retorno = 0;

            // Crear instancia de la clase de conexión
            using (BDCon bdCon = new BDCon())
            {
                bdCon.AbrirConexion();
                SqlConnection conexion = bdCon.ObtenerConexion();

                // Usar la conexión ya abierta
                using (SqlCommand cmd = new SqlCommand("INSERT INTO usuarios (usuario, passwd, estado, tipousuario) VALUES (@usuario, @passwd, @estado, @tipo_usuario)", conexion))
                {
                    // Definir los parámetros
                    cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@passwd", usuario.Passwd);
                    cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                    cmd.Parameters.AddWithValue("@tipo_usuario", usuario.Tipo_usuario);

                    // Ejecutar el comando
                    retorno = cmd.ExecuteNonQuery();
                }

                // La conexión se cierra automáticamente al salir del bloque using
            }

            return retorno;
        }
    }
}
