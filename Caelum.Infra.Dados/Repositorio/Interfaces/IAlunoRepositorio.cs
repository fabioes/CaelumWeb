using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        IEnumerable<AlunoDAO> Listar();
        void Salvar(AlunoDAO aluno);
        void Deletar(AlunoDAO aluno);
    }
}
