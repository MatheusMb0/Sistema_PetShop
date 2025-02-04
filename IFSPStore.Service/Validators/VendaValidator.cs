using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator()
        {
            RuleFor(c => c.EnderecoEntrega)
                .NotEmpty().WithMessage("Por Favor informe o endereço para entrega do produto.")
                .NotNull().WithMessage("Por Favor informe o endereço para entrega do produto.")
                .MaximumLength(100).WithMessage("Endereço de entrega pode ter no máximo 100 caracteres.");

            RuleFor(c => c.BairroEntrega)
                .NotEmpty().WithMessage("Por Favor informe o bairro para entrega do produto.")
                .NotNull().WithMessage("Por Favor informe o bairro para entrega do produto.")
                .MaximumLength(45).WithMessage("Bairro de entrega pode ter no máximo 45 caracteres.");

            RuleFor(c => c.CidadeEntrega)
                .NotEmpty().WithMessage("Por Favor informe a cidade para entrega do produto.")
                .NotNull().WithMessage("Por Favor informe a cidade para entrega do produto.")
                .MaximumLength(25).WithMessage("Cidade de entrega pode ter no máximo 25 caracteres.");
        }
    }
}
