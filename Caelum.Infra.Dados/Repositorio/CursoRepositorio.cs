using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio
{
    public class CursoRepositorio : ICursoRepositorio
    {
        protected readonly DbContext Context;
        protected DbSet<CursoDTO> DbSet;

        public CursoRepositorio(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<CursoDTO>();
        }
        public void Deletar(CursoDTO curso)
        {
            using (Context)
            {
                Context.Remove(curso);
                Context.SaveChanges();
            }
        }

        public IEnumerable<CursoDTO> Listar()
        {
            return DbSet;
        }

        public void Salvar(CursoDTO curso)
        {
            using (Context)
            {
                if (Context.Entry(curso).State != EntityState.Modified)
                    Context.Set<CursoDTO>().Add(curso);

                Context.SaveChanges();
            }
        }
        public void AtivarDesativarCurso(int id, bool ativo)
        {
            using (Context)
            {
                CursoDTO dto = new CursoDTO();
                dto.Id = id;
                dto.Ativo = ativo;

                Context.SaveChanges();
            }
        }
    }
}
