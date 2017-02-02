using System;
using System.ComponentModel.DataAnnotations;

namespace Caelum.Infra.Dados
{
    public class AlunoCursoDTO
    {
        [Key]
        public int Id { get; set; }
        public Curso Aluno { get; set; }
        public Curso Curso { get; set; }
        public bool Completo { get; set; }
        public int PercentualCompleto { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
