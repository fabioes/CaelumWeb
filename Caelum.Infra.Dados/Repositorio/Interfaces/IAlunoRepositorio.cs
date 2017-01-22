using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    interface IAlunoRepositorio
    {
        IEnumerable<Aluno> Listar();
        void Salvar(Aluno aluno);
        void Deletar(Aluno aluno);
    }
}
