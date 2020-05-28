
using System.Data;
using Npgsql;

namespace SourceCode
{
    public static class ConexionBD
    { private static string host = "127.0.0.1",
                  dataBase = "AplicacionParcial02",
                  userId = "postgres",
                  password = "alberto20";

        
        
        private static string sConnection = 
            $"Server={host};Port=5432; User Id={userId};Password={password};Database={dataBase}";
                                                        // $"sslmode=Require;Trust Server Certificate=true";


        public static DataTable realizarConsulta(string sql)
        {
            NpgsqlConnection connection= new NpgsqlConnection(sConnection);
            DataSet dataSet= new DataSet();
            
            connection.Open();
            NpgsqlDataAdapter dataAdapter= new NpgsqlDataAdapter(sql,connection);
            dataAdapter.Fill(dataSet);
            connection.Close();

            return dataSet.Tables[0];
        }

        public static void realizarEvento(string sql)
        {
            NpgsqlConnection connection= new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}