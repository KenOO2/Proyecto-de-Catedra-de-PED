using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class Conexion
    {
        public static SqlConnection GetConexion()
        {
            SqlConnection SqlConexion;
            string server = "localhost  ";
            string database = "Codex";
            string user = "sa";
            string password = "123456";
            
            try
            {
                SqlConexion = new SqlConnection($"Server={server}; Database={database}; Integrated Security=True");
                SqlConexion.Open();
                return SqlConexion;
            }
            catch (Exception)
            {
                return SqlConexion = null;
            }
        }

    }
}
