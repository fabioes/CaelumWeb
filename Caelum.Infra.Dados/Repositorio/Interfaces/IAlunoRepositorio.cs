using System.Collections.Generic;

namespace Caelum.Infra.Dados.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        IEnumerable<AlunoDTO> Listar();
        AlunoDTO ListarPorId(int idAluno);
        void Salvar(AlunoDTO aluno);
        void Deletar(AlunoDTO aluno);
    }
}
