using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data)
                .IsRequired()
                .HasColumnType("timestamp");

            builder.Property(prop => prop.ValorTotalFinal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.EnderecoEntrega)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.BairroEntrega)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.CidadeEntrega)
                .IsRequired()
                .HasColumnType("varchar(25)");

            builder.HasOne(prop => prop.Cliente);
        }
    }
}