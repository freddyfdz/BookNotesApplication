using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookNotes
{
    class PeticionesDB
    {
        public static int Autentificar(string pNomUsuario, string pPassword)
        {
            int resultado = -1;
            SqlConnection conn = DbConnect.ObtenerConexion();
            SqlCommand comando = new SqlCommand(string.Format("Select * From USUARIOS Where NomUsuario = '{0}' and PassWord = '{1}'", pNomUsuario, pPassword), conn);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;

            }

            conn.Close();
            return resultado;
        }
    }
}
