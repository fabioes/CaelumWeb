using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class AlunoCursoRepositorio : IAlunoCursoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<AlunoCurso> DbSet;

        public AlunoCursoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<AlunoCurso>();
        }

        public void Deletar(AlunoCurso alunoCurso)
        {
            using (Context)
            {
                Context.Remove(alunoCurso);
                Context.SaveChanges();
            }
        }

        public IEnumerable<AlunoCurso> Listar()
        {
            return DbSet;
        }

        public void Salvar(AlunoCurso alunoCurso)
        {
            using (Context)
            {
                if (Context.Entry(alunoCurso).State != EntityState.Modified)
                    Context.Set<AlunoCurso>().Add(alunoCurso);

                Context.SaveChanges();
            }
        }
    }
}
