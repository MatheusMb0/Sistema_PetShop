using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Preco)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(prop => prop.DataCompra)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(prop => prop.UnidadeVenda)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.HasOne(prop => prop.Grupo);
            builder.HasOne(prop => prop.Fornecedor);
        }
    }
}