using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    interface ICursoRepositorio
    {
        IEnumerable<Curso> Listar();
        void Salvar(Curso curso);
        void Deletar(Curso curso);
    }
}
