using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Controllers.DAL;

namespace Controllers
{
    public class ProfessorController
    {
        Contexto contexto = new Contexto();

        public void Inserir(Professor novoProf)
        {
            contexto.Professores.Add(novoProf);
            contexto.SaveChanges();
        }

        public List<Professor> ListarTodosProf()
        {
            return contexto.Professores.ToList();
        }


        public Professor BuscarMatricula(string cpf)
        {
            //usando LINQ
            var professor = from p in contexto.Professores
                        where p.CPF == cpf
                        select p;

            return (Professor)professor;
        }

        public Professor BuscarNome(string nome)
        {
            //usando LINQ
            var professor = from p in contexto.Professores
                        where p.Nome == nome
                        select p;

            return (Professor)professor;
        }

        public Professor BuscarPorID(int idProf)
        {
            return contexto.Professores.Find(idProf); //Pesquisa por chave primaria
        }

        public void Atualizar(Professor professor)
        {
            contexto.Entry(professor).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idProf)
        {
            Professor professor = BuscarPorID(idProf);
            contexto.Professores.Remove(professor);
            contexto.SaveChanges();
        }

    }
}
