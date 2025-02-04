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
    public class GrupoValidator : AbstractValidator<Grupo>
    {
        public GrupoValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por Favor informe o grupo")
               .NotNull().WithMessage("Por Favor informe o grupo")
               .MaximumLength(55).WithMessage("Nome pode ter no máximo 45 caracteres.");
        }
    }
}