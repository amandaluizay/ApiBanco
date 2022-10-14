using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Validations
{
    public class CategoriaValidation : AbstractValidator<ContaBancaria>
    {
        public CategoriaValidation()
        {
            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(11).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Agencia)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(5).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.ContaCorrente)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(10).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Senha6dig)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(6).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");
        }
    }
}
