using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface ICursoRepositorio
    {
        IEnumerable<CursoDTO> Listar();
        void Salvar(CursoDTO curso);
        void Deletar(CursoDTO curso);
        void AtivarDesativarCurso(int id, bool ativo);
    }
}
