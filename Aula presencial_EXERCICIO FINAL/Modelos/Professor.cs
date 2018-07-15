using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Professor
    {
        [Key]
        public int idProf { get; set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Disciplina { get; set; }
    }
}
