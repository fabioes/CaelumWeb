using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class AlunoCursoRepositorio : IAlunoCursoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<AlunoCursoDTO> DbSet;

        public AlunoCursoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<AlunoCursoDTO>();
        }

        public void Deletar(AlunoCursoDTO alunoCurso)
        {
            using (Context)
            {
                Context.Remove(alunoCurso);
                Context.SaveChanges();
            }
        }

        public IEnumerable<AlunoCursoDTO> Listar()
        {
            return DbSet;
        }

        public void Salvar(AlunoCursoDTO alunoCurso)
        {
            using (Context)
            {
                if (Context.Entry(alunoCurso).State != EntityState.Modified)
                    Context.Set<AlunoCursoDTO>().Add(alunoCurso);

                Context.SaveChanges();
            }
        }
    }
}
