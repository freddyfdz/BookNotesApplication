using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookNotes
{
    class DbConnect
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(@"Data source = FREDDYFDZ\SQLEXPRESS; Initial Catalog = BOOKNOTES; Integrated Security= true ");
            conn.Open();
            return conn;
        }
    }
}
