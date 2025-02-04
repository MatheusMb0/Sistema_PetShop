using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class PetValidator : AbstractValidator<Pet>
    {
        public PetValidator()
        {
            RuleFor(i => i.Nome)
            .NotEmpty().WithMessage("Por favor, informe o nome do pet.")
            .NotNull().WithMessage("Por favor, informe o nome do pet.")
            .MaximumLength(30).WithMessage("Nome pode ter no máximo 30 caracteres.");

            RuleFor(i => i.TipoPet)
                .NotEmpty().WithMessage("Por favor, informe o tipo do pet.")
                .NotNull().WithMessage("Por favor, informe o tipo do pet.")
                .MaximumLength(20).WithMessage("Tipo do pet pode ter no máximo 20 caracteres.");

            RuleFor(i => i.Raca)
                .NotEmpty().WithMessage("Por favor, informe a raça do pet.")
                .NotNull().WithMessage("Por favor, informe a raça do pet.")
                .MaximumLength(30).WithMessage("Raça pode ter no máximo 30 caracteres.");

            RuleFor(i => i.Sexo)
                .NotEmpty().WithMessage("Por favor, informe o sexo do pet.")
                .NotNull().WithMessage("Por favor, informe o sexo do pet.")
                .MaximumLength(15).WithMessage("Sexo pode ter no máximo 15 caracteres.");

            RuleFor(i => i.Cor)
                .NotEmpty().WithMessage("Por favor, informe a cor do pet.")
                .NotNull().WithMessage("Por favor, informe a cor do pet.")
                .MaximumLength(20).WithMessage("Cor pode ter no máximo 20 caracteres.");

        }
    }
}
