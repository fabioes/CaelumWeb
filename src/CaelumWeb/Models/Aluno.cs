using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CaelumWeb.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(11, ErrorMessage = "Este campo deve ter no mínimo 11 caractéres")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<Curso> Curso { get; set; }
    }
}
