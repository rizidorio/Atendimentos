using System.ComponentModel.DataAnnotations;

namespace AplicacaoWeb.Models
{
    public class FormaPagamento
    {
        [Required(ErrorMessage = "Código é obrigatório.")]
        [StringLength(6, ErrorMessage = "Código deve ter no máximo 6 caracteres.")]
        [RegularExpression(@"^[FP\d]{6}$", ErrorMessage = "Código inválido.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}
