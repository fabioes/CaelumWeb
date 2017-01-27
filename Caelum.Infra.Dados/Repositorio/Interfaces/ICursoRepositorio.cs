using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface ICursoRepositorio
    {
        IEnumerable<Curso> Listar();
        void Salvar(Curso curso);
        void Deletar(Curso curso);
        void AtivarDesativarCurso(int id, bool ativo);
    }
}
