using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudUsuarios
{
    public class BDCon : IDisposable
    {
        private SqlConnection conectar;

        public void AbrirConexion()
        {
            conectar = new SqlConnection("Data Source=DESKTOP-TH3DH38\\PAULO;Initial catalog=usuarios;integrated security=True;");
            conectar.Open();
        }

        public void CerrarConexion()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Close();
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return conectar;
        }
        public void Dispose()
        {
            CerrarConexion();
        }
    }
}
