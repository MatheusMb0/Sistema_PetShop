using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por Favor informe a cidade.")
                .NotNull().WithMessage("Por Favor informe a cidade.")
                .MaximumLength(25).WithMessage("Nome pode ter no máximo 25 caracteres.");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("Por Favor informe a sigla do estado.")
                .NotNull().WithMessage("Por Favor informe a sigla do estado.")
                .Length(2).WithMessage("A sigla do estado só pode ter no máximo 2 caracteres.");
        }
    }
}
