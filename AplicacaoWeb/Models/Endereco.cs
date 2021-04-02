using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWeb.Models
{
    public class Endereco
    {
        [Required(ErrorMessage = "CEP é obrigatório.")]
        [RegularExpression(@"^\d{8}$")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatório.")]
        [StringLength(80, ErrorMessage = "Tamanho máximo do campo é de 80 caracteres.")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório.")]
        [StringLength(80, ErrorMessage = "Tamanho máximo do campo é de 50 caracteres.")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório.")]
        [StringLength(80, ErrorMessage = "Tamanho máximo do campo é de 50 caracteres.")]
        [Display(Name = "Cidade")]
        public string Localidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório.")]
        [StringLength(80, ErrorMessage = "Tamanho máximo do campo é de 02 caracteres.")]
        [Display(Name = "Estado")]
        public string Uf { get; set; }
    }
}
