using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<Aluno> DbSet;

        public AlunoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<Aluno>();
        }

        public void Deletar(Aluno aluno)
        {
            using (Context)
            {
                Context.Remove(aluno);
                Context.SaveChanges();
            }

        }
        public void Salvar(Aluno aluno)
        {
            using (Context)
            {
                if (Context.Entry(aluno).State != EntityState.Modified)
                    Context.Set<Aluno>().Add(aluno);

                Context.SaveChanges();
            }

        }
        public IEnumerable<Aluno> Listar()
        {
            return DbSet;
        }

    }

}
