﻿using System.ComponentModel.DataAnnotations;

namespace Banco.ApiCore.ViewModel
{
    public class ContaBancaria
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Agencia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ContaCorrente { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Senha8dig { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha6dig { get; set; }

    }
}
