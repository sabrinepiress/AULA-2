using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Controllers.DAL;

namespace Controllers
{
    public class DisciplinaController
    {
        Contexto contexto = new Contexto();

        public void Inserir(Disciplina novaDisc)
        {
            contexto.Disciplinas.Add(novaDisc);
            contexto.SaveChanges();
        }

        public List<Disciplina> ListarTodosDisc()
        {
            return contexto.Disciplinas.ToList();
        }


        public Disciplina BuscarDisc(string titulo)
        {
            //usando LINQ
            var disciplina = from d in contexto.Disciplinas
                             where d.Titulo == titulo
                             select d;

            return (Disciplina)disciplina;
        }

        public Disciplina BuscarPorID(int idDisc)
        {
            return contexto.Disciplinas.Find(idDisc); //Pesquisa por chave primaria
        }

        public void Atualizar(Disciplina disciplinas)
        {
            contexto.Entry(disciplinas).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idDisc)
        {
            Disciplina disciplina = BuscarPorID(idDisc);
            contexto.Disciplinas.Remove(disciplina);
            contexto.SaveChanges();
        }

    }
}

