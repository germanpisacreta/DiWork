using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Persistencia
{
    public class Conexiones
    {
        public SqlConnection AbrirConnection(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }


        public SqlTransaction AbrirTransactionCommited(SqlConnection conn)
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            return conn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted, "conn");

        }

        
    }
}
