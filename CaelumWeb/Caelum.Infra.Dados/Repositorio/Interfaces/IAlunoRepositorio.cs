using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        IEnumerable<Aluno> Listar();
        Aluno ListarPorId(int idAluno);
        void Salvar(Aluno aluno);
        void Deletar(Aluno aluno);
    }
}
