using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface IAlunoCursoRepositorio
    {
        IEnumerable<AlunoCursoDTO> Listar();
        void Salvar(AlunoCursoDTO alunoCurso);
        void Deletar(AlunoCursoDTO alunoCurso);
    }
}
