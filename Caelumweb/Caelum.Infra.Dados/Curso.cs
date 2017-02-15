
using System.ComponentModel.DataAnnotations;

namespace Caelum.Infra.Dados
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
