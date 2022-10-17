using System.ComponentModel.DataAnnotations;

namespace Banco.ApiCore.ViewModel
{
    public class ContaBancariaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "Invalido", MinimumLength = 1)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(4, ErrorMessage = "O campo {0} precisa ter 6 caracteres", MinimumLength = 4)]
        public string Agencia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(4, ErrorMessage = "O campo {0} precisa ter 6 caracteres", MinimumLength = 4)]
        public string ContaCorrente { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter 8 caracteres", MinimumLength = 8)]
        public int Senha8dig { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(6, ErrorMessage = "O campo {0} precisa ter 6 caracteres", MinimumLength = 6)]
        public string Senha6dig { get; set; }

    }
}
