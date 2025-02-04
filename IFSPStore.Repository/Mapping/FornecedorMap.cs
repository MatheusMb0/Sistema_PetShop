using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NomeFantasia)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.RazaoSocial)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.CNPJ)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Bairro)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.DataCadastro)
               .IsRequired()
               .HasColumnType("timestamp");

            builder.HasOne(prop => prop.Cidade);
        }
    }
}