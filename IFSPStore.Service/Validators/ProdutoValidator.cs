using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por Favor informe o produto.")
                .NotNull().WithMessage("Por Favor informe o produto.")
                .MaximumLength(45).WithMessage("Produto pode ter no máximo 45 caracteres.");

            RuleFor(c => c.UnidadeVenda)
                .NotEmpty().WithMessage("Por Favor informe em qual unidade de venda ele é vendido.")
                .NotNull().WithMessage("Por Favor informe em qual unidade de venda ele é vendido.")
                .MaximumLength(10).WithMessage("Unidade de venda pode ter no máximo 10 caracteres.");

            RuleFor(c => c.Descricao)
               .NotEmpty().WithMessage("Por Favor informe a descrição do produto.")
               .NotNull().WithMessage("Por Favor informe a descrição do produto.")
               .MaximumLength(500).WithMessage("Descrição pode ter no máximo 500 caracteres.");
        }
    }
}
