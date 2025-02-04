using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(c => c.NomeFantasia)
                .NotEmpty().WithMessage("Por Favor informe o nome fantasia da empresa.")
                .NotNull().WithMessage("Por Favor informe o nome fantasia da empresa.")
                .MaximumLength(100).WithMessage("Nome fantasia pode ter no máximo 100 caracteres.");

            RuleFor(c => c.RazaoSocial)
                .NotEmpty().WithMessage("Por Favor informe a razão social da empresa.")
                .NotNull().WithMessage("Por Favor informe a razão social da empresa.")
                .MaximumLength(100).WithMessage("Razão social pode ter no máximo 100 caracteres.");

            RuleFor(c => c.CNPJ)
               .NotEmpty().WithMessage("Por Favor informe o CNPJ.")
               .NotNull().WithMessage("Por Favor informe o CNPJ.")
               .MaximumLength(20).WithMessage("CNPJ pode ter no máximo 20 caracteres.");

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

            RuleFor(c => c.Telefone)
               .NotEmpty().WithMessage("Por Favor informe o telefone.")
               .NotNull().WithMessage("Por Favor informe o telefone.")
               .MaximumLength(20).WithMessage("Telefone pode ter no máximo 20 caracteres.");

            RuleFor(c => c.Endereco)
               .NotEmpty().WithMessage("Por Favor informe o seu endereço.")
               .NotNull().WithMessage("Por Favor informe o seu endereço.")
               .MaximumLength(100).WithMessage("Endereço pode ter no máximo 100 caracteres.");

            RuleFor(c => c.Bairro)
              .NotEmpty().WithMessage("Por Favor informe o seu bairro.")
              .NotNull().WithMessage("Por Favor informe o seu bairro.")
              .MaximumLength(45).WithMessage("Bairro pode ter no máximo 45 caracteres.");
        }
    }
}
