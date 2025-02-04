using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class Pet_ServicoMap : IEntityTypeConfiguration<Pet_Servico>
    {
        public void Configure(EntityTypeBuilder<Pet_Servico> builder)
        {
            builder.ToTable("Pet_Servico");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Pet);
            builder.HasOne(prop => prop.Servico);
        }
    }
}