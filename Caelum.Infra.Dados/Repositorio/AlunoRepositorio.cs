using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<AlunoDTO> DbSet;

        public AlunoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<AlunoDTO>();
        }

        public void Deletar(AlunoDTO aluno)
        {
            using (Context)
            {
                Context.Remove(aluno);
                Context.SaveChanges();
            }

        }
        public void Salvar(AlunoDTO aluno)
        {
            using (Context)
            {
                if (Context.Entry(aluno).State != EntityState.Modified)
                    Context.Set<AlunoDTO>().Add(aluno);

                Context.SaveChanges();
            }

        }
        public IEnumerable<AlunoDTO> Listar()
        {
            return DbSet;
        }
        public AlunoDTO ListarPorId(int idAluno)
        {
            return DbSet.Find(idAluno);
        }
    }

}
