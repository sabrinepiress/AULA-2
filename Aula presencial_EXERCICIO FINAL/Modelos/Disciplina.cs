using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Disciplina
    {
        [Key]
        public int idDisc { get; set; }
        public string Titulo { get; set; }
        public string Codigo { get; set; }
    }
}
