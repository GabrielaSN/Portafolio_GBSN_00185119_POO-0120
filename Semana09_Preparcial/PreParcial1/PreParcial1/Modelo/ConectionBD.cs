using System.Data;
using Npgsql;

namespace PreParcial1.Modelo
{
    public class ConectionBD
    {
     private static string CadenaConexion = 
         "Server=host;Port=1234;User Id=postgres;Password=gbsn;Database=bakery";
     
     
     public static DataTable realizarConsulta(string sql)
     {
         NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
         DataSet ds = new DataSet();
                 
         conn.Open();
         NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
         da.Fill(ds);
         conn.Close();
                 
         return ds.Tables[0];
        }
                
        public static void realizarAccion(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
                 
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
                
    }
                
    }