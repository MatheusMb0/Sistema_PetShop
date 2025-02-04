using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class PetMap : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(prop => prop.TipoPet)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Raca)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(prop => prop.DataNascimento)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(prop => prop.Peso)
                .IsRequired()
                .HasColumnType("float");

            builder.Property(prop => prop.Sexo)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.Property(prop => prop.Cor)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.HasOne(prop => prop.Cliente);
        }
    }
}