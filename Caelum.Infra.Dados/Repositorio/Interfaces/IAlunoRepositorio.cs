using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        IEnumerable<AlunoDTO> Listar();
        void Salvar(AlunoDTO aluno);
        void Deletar(AlunoDTO aluno);
    }
}
