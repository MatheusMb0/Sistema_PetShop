using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class Veterinario_ServicoMap : IEntityTypeConfiguration<Veterinario_Servico>
    {
        public void Configure(EntityTypeBuilder<Veterinario_Servico> builder)
        {
            builder.ToTable("Veterinario_Servico");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Veterinario);
            builder.HasOne(prop => prop.Servico);
        }
    }
}