using System.Data.SqlClient;

namespace Modelo
{
    public class Conexion
    {
        public static SqlConnection GetConexion()
        {
            SqlConnection SqlConexion;
            string server = "localhost";
            string database = "Codex";
            string user = "sa";
            string password = "123456";

            try
            {
                SqlConexion = new SqlConnection("server=" + server +
                                                ";uid=" + user +
                                                ";pwd=" + password +
                                                ";database=" + database);
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
