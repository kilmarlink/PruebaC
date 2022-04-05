using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionDB
    {
        private static string Conn = @"Server=PC\SQLEXPRESS;Database=PREGUNTAS_RESPUESTAS;Trusted_Connection=True;";
        
        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }
    }
}
