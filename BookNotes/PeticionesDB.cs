using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static int NewMateria (RegMateria pMaterias)
        {
            int retorno = 0;
            using (SqlConnection Conn = DbConnect.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Materias (idMateria, NombreMateria) values ('{0}','{1}')", pMaterias.Id,pMaterias.Materia),Conn);
                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Agregar(RegUser pUsuario)
        {

            int retorno = 0;
            using (SqlConnection Conn = DbConnect.ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Insert Into Persona (Nombre, Apellidos,Telefono, Correo) values ('{0}','{1}','{2}','{3}')", pUsuario.Nombres, pUsuario.Apellidos, pUsuario.Id, pUsuario.Rol), Conn);
                retorno = comando.ExecuteNonQuery();

            }
            return retorno;
        }

        public void LlenarRoles(ComboBox CbRoles)
        {
            try
            {
                SqlConnection Conn = DbConnect.ObtenerConexion();
                SqlCommand comando = new SqlCommand(string.Format("Select * from Rol"), Conn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CbRoles.Items.Add(reader["NombreRol"].ToString());
                }
                CbRoles.SelectedIndex = 0;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible realizar la consulta: " + ex.ToString());
            }
        }
        public void LlenarCursos(ComboBox CbCursos)
        {
            try
            {
                SqlConnection Conn = DbConnect.ObtenerConexion();
                SqlCommand comando = new SqlCommand(string.Format("Select * from Curso"), Conn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CbCursos.Items.Add(reader["NombreCurso"].ToString());
                }
                CbCursos.SelectedIndex = 1;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible realizar la consulta: " + ex.ToString());
            }
        }

        public void LlenarMaterias(CheckedListBox ChbMaterias)
        {
            try
            {
                SqlConnection Conn = DbConnect.ObtenerConexion();
                SqlCommand comando = new SqlCommand(string.Format("Select * from Materias"), Conn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    ChbMaterias.Items.Add(reader["NombreMatera"].ToString());
                }
                ChbMaterias.SelectedIndex = 1;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible realizar la consulta: " + ex.ToString());
            }
        }
    }
}