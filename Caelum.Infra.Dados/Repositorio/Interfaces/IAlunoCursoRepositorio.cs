using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface IAlunoCursoRepositorio
    {
        IEnumerable<AlunoCurso> Listar();
        void Salvar(AlunoCurso alunoCurso);
        void Deletar(AlunoCurso alunoCurso);
    }
}
