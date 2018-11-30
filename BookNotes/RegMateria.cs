using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNotes
{
    public class RegMateria
    {
        public Int32 Id { get; set; }
        public string Materia { get; set; }

        public RegMateria() { }

        public RegMateria (Int32 pId, string pMateria)
        {
            this.Id = pId;
            this.Materia= pMateria;
        }
    }
}
