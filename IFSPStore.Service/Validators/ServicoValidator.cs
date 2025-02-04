using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ServicoValidator : AbstractValidator<Servico>
    {
        public ServicoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por Favor informe o nome do serviço.")
                .NotNull().WithMessage("Por Favor informe o nome do serviço.")
                .MaximumLength(100).WithMessage("Serviço pode ter no máximo 100 caracteres.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por Favor informe a descrição do servico.")
                .NotNull().WithMessage("Por Favor informe a descrição do servico.")
                .MaximumLength(500).WithMessage("Descrição pode ter no máximo 500 caracteres.");

            RuleFor(c => c.DuracaoEstimada)
               .NotEmpty().WithMessage("Por Favor informe a duração estimada do serviço.")
               .NotNull().WithMessage("Por Favor informe a duração estimada do serviço.")
               .MaximumLength(15).WithMessage("Duração estimada pode ter no máximo 15 caracteres.");

            RuleFor(c => c.TipoServico)
              .NotEmpty().WithMessage("Por Favor informe o tipo do serviço.")
              .NotNull().WithMessage("Por Favor informe o tipo do serviço.")
              .MaximumLength(30).WithMessage("Tipo de serviço pode ter no máximo 30 caracteres.");

            RuleFor(c => c.Disponibilidade)
               .NotEmpty().WithMessage("Por Favor informe os dias disponíveis para realizar o serviço.")
               .NotNull().WithMessage("Por Favor informe os dias disponíveis para realizar o serviço.")
               .MaximumLength(30).WithMessage("Disponibilidade pode ter no máximo 30 caracteres.");

            RuleFor(c => c.Requisitos)
              .NotEmpty().WithMessage("Por Favor informe os requisitos para realizar o serviço.")
              .NotNull().WithMessage("Por Favor informe os requisitos para realizar o serviço.")
              .MaximumLength(50).WithMessage("Requisitos pode ter no máximo 50 caracteres.");

            RuleFor(c => c.Materiais)
               .NotEmpty().WithMessage("Por Favor informe os materiais necessários para o serviço.")
               .NotNull().WithMessage("Por Favor informe os materiais necessários para o serviço.")
               .MaximumLength(100).WithMessage("Materiais pode ter no máximo 100 caracteres.");
        }
    }
}
