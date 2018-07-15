using Modelos;
using System.Data.Entity;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn") 
        {
        }
        public DbSet<Aluno> Alunos { get; set; } // tBalunos
        public DbSet<Professor> Professores { get; set; } // tBprofessor
        public DbSet<Disciplina> Disciplinas { get; set; } // tBdisciplinas
    }
}
