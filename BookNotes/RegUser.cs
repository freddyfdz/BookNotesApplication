using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNotes
{
    public class RegUser
    {
        public string Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NomUsuario { get; set; }
        public string Rol { get; set; }
        public string Curso { get; set; }
        public string Materias { get; set; }
        public string Password { get; set; }

        public RegUser() { }

        public RegUser(string pId, string pNombres, string pApellidos, string pRol, string pCurso, string pNomUser, string pMaterias)
        {
            this.Id = pId;
            this.Nombres = pNombres;
            this.Apellidos = pApellidos;
            this.Rol = pRol;
            this.NomUsuario = pNomUser;
            this.Curso = pCurso;
            this.Materias = pMaterias;
            this.Password = pId;
        }
    }
}
