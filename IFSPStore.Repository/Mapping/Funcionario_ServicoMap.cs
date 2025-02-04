using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class Funcionario_ServicoMap : IEntityTypeConfiguration<Funcionario_Servico>
    {
        public void Configure(EntityTypeBuilder<Funcionario_Servico> builder)
        {
            builder.ToTable("Funcionario_Servico");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Funcionario);
            builder.HasOne(prop => prop.Servico);
        }
    }
}