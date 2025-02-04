using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Email)
               .EmailAddress().WithMessage("E-mail invalido.")
               .NotEmpty().WithMessage("Por favor informe o email.")
               .NotNull().WithMessage("Por favor informe o email.")
               .MaximumLength(100).WithMessage("Email pode ter no máximo 100 caracteres.");

            RuleFor(c => c.Senha)
            .MinimumLength(8).WithMessage("O comprimento da sua senha deve ser de pelo menos 8 caracteres.")
            .MaximumLength(45).WithMessage("O comprimento da sua senha deve ser no máximo 45 caracteres.")
            .Matches(@"[A-Z]+").WithMessage("Sua senha deve conter pelo menos uma letra maiúscula.")
            .Matches(@"[a-z]+").WithMessage("Sua senha deve conter pelo menos uma letra minúscula.")
            .Matches(@"[0-9]+").WithMessage("Sua senha deve conter pelo menos um número.")
            .Matches(@"[\!\?\*\.\@]+").WithMessage("Sua senha deve conter pelo menos um dos seguintes caracteres: (!?@*.).")
            .NotEmpty().WithMessage("Por favor informe a senha.")
            .NotNull().WithMessage("Por favor informe a senha.");
        }
    }
}