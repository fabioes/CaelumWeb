
using System.ComponentModel.DataAnnotations;

namespace Caelumweb.ViewModels
{
    public class AlunoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo Nome é obrigatório")]
        [MinLength(3,ErrorMessage = "O Campo Nome deve ter no mínimo 3 caractéres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Cpf é obrigatório")]
        [MaxLength(15,ErrorMessage = "O Campo Cpf deve ter no máximo 15 caractéres")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O Campo Endereco é obrigatório")]
        [MaxLength(200,ErrorMessage = "O Campo Endereco deve ter no máximo 200 caractéres")]
        public string Endereco { get; set; }
    }
}
