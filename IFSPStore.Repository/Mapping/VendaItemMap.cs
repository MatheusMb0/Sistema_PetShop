using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class VendaItemMap : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            builder.ToTable("VendaItem");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(prop => prop.ValorUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.ValorTotal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.HasOne(prop => prop.Venda);
            builder.HasOne(prop => prop.Produto);
            builder.HasOne(prop => prop.Servico);
        }
    }
}