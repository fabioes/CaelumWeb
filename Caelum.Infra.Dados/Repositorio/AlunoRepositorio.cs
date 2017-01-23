using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<AlunoDAO> DbSet;

        public AlunoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<AlunoDAO>();
        }

        public void Deletar(AlunoDAO aluno)
        {
            using (Context)
            {
                Context.Remove(aluno);
                Context.SaveChanges();
            }

        }
        public void Salvar(AlunoDAO aluno)
        {
            using (Context)
            {
                if (Context.Entry(aluno).State != EntityState.Modified)
                    Context.Set<AlunoDAO>().Add(aluno);

                Context.SaveChanges();
            }

        }
        public IEnumerable<AlunoDAO> Listar()
        {
            return DbSet;
        }

    }

}
