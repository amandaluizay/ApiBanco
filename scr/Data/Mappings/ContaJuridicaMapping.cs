using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Business.Models;

namespace Data.Mappings
{
    public class ContaJuridicaMapping : IEntityTypeConfiguration<ContaJuridica>
    {
        public void Configure(EntityTypeBuilder<ContaJuridica> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Cnpj)
                .IsRequired()
                .IsUnicode()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.ChaveJ)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Usuario)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Senha8Dig)
                .IsRequired()
                .HasColumnType("INT");

            builder.Property(p => p.Senha6Dig)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("ContaJuridica");
        }
    }
}
