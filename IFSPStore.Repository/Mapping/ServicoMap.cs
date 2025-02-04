using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(prop => prop.Preco)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.DuracaoEstimada)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.Property(prop => prop.TipoServico)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(prop => prop.Disponibilidade)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(prop => prop.Requisitos)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Materiais)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}