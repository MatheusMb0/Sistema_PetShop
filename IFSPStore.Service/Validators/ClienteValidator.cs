using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por Favor informe o nome do cliente.")
                .NotNull().WithMessage("Por Favor informe o nome do cliente.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por Favor informe o CPF.")
                .NotNull().WithMessage("Por Favor informe o CPF.")
                .MaximumLength(15).WithMessage("CPF pode ter no máximo 15 caracteres.");

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

            RuleFor(c => c.Endereco)
               .NotEmpty().WithMessage("Por Favor informe o seu endereço.")
               .NotNull().WithMessage("Por Favor informe o seu endereço.")
               .MaximumLength(100).WithMessage("Endereço pode ter no máximo 100 caracteres.");

            RuleFor(c => c.Bairro)
              .NotEmpty().WithMessage("Por Favor informe o seu bairro.")
              .NotNull().WithMessage("Por Favor informe o seu bairro.")
              .MaximumLength(45).WithMessage("Bairro pode ter no máximo 45 caracteres.");

            RuleFor(c => c.Telefone)
               .NotEmpty().WithMessage("Por Favor informe o telefone.")
               .NotNull().WithMessage("Por Favor informe o telefone.")
               .MaximumLength(20).WithMessage("Telefone pode ter no máximo 20 caracteres.");
        }
    }
}
