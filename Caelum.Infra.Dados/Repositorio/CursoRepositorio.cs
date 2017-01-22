using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class CursoRepositorio : ICursoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<Curso> DbSet;

        public CursoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<Curso>();
        }
        public void Deletar(Curso curso)
        {
            using (Context)
            {
                Context.Remove(curso);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Curso> Listar()
        {
            return DbSet;
        }

        public void Salvar(Curso curso)
        {
            using (Context)
            {
                if (Context.Entry(curso).State != EntityState.Modified)
                    Context.Set<Curso>().Add(curso);

                Context.SaveChanges();
            }
        }
    }
}
