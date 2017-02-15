
using System.ComponentModel.DataAnnotations;

namespace Caelumweb.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O Campo Usuário é obrigatório")]
        public string Username { get; set; }
        [Required(ErrorMessage = "O Campo Senha é obrigatório"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "O Campo Confirmar Senha é obrigatório"), DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
