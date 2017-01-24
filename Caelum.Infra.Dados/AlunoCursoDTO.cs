using System;
using System.ComponentModel.DataAnnotations;

namespace Caelum.Infra.Dados
{
    public class AlunoCursoDTO
    {
        [Key]
        public int Id { get; set; }
        public CursoDTO Aluno { get; set; }
        public CursoDTO Curso { get; set; }
        public bool Completo { get; set; }
        public int PercentualCompleto { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
