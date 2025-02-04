using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por Favor informe o nome do funcionário.")
                .NotNull().WithMessage("Por Favor informe o nome do funcionário.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por Favor informe o CPF.")
                .NotNull().WithMessage("Por Favor informe o CPF.")
                .MaximumLength(15).WithMessage("CPF pode ter no máximo 15 caracteres.");

            RuleFor(c => c.RG)
               .NotEmpty().WithMessage("Por Favor informe o RG.")
               .NotNull().WithMessage("Por Favor informe o RG.")
               .MaximumLength(20).WithMessage("RG pode ter no máximo 20 caracteres.");

            RuleFor(c => c.Endereco)
               .NotEmpty().WithMessage("Por Favor informe o seu endereço.")
               .NotNull().WithMessage("Por Favor informe o seu endereço.")
               .MaximumLength(100).WithMessage("Endereço pode ter no máximo 100 caracteres.");

            RuleFor(c => c.Bairro)
               .NotEmpty().WithMessage("Por Favor informe o bairro.")
               .NotNull().WithMessage("Por Favor informe o bairro.")
               .MaximumLength(45).WithMessage("Bairro pode ter no máximo 45 caracteres.");

            RuleFor(c => c.Telefone)
               .NotEmpty().WithMessage("Por Favor informe o telefone.")
               .NotNull().WithMessage("Por Favor informe o telefone.")
               .MaximumLength(20).WithMessage("Telefone pode ter no máximo 20 caracteres.");

            RuleFor(c => c.Email)
               .NotEmpty().WithMessage("Por Favor informe o seu email.")
               .NotNull().WithMessage("Por Favor informe o seu email.")
               .MaximumLength(100).WithMessage("Email pode ter no máximo 100 caracteres.");

            RuleFor(c => c.Cargo)
              .NotEmpty().WithMessage("Por Favor informe o seu cargo.")
              .NotNull().WithMessage("Por Favor informe o seu cargo.")
              .MaximumLength(50).WithMessage("Cargo pode ter no máximo 50 caracteres.");

            RuleFor(c => c.HorarioTrabalho)
               .NotEmpty().WithMessage("Por Favor informe o Horário de trabalho.")
               .NotNull().WithMessage("Por Favor informe o Horário de trabalho.")
               .MaximumLength(50).WithMessage("Horário de trabalho pode ter no máximo 50 caracteres.");

            RuleFor(c => c.Descricao)
               .NotEmpty().WithMessage("Por Favor informe alguma descrição.")
               .NotNull().WithMessage("Por Favor informe alguma descrição.")
               .MaximumLength(500).WithMessage("Descrição pode ter no máximo 500 caracteres.");
        }
    }
}
