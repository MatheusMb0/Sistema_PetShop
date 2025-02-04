using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.Property(prop => prop.RG)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.DataNascimento)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Bairro)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Email)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Cargo)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Salario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.DataContratacao)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(prop => prop.HorarioTrabalho)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.HasOne(prop => prop.Cidade);
        }
    }
}