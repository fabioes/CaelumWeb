using System.ComponentModel.DataAnnotations;

namespace CaelumWeb.ViewModels
{
    public class CursoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
