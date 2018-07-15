using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Aluno
        {
        [Key]
        public int AlunoID { get; set; }

        public string Nome { get; set; }
        public int Matricula { get; set; }

        }
}
