using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;

namespace Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<ContaBancaria>
    {
        public void Configure(EntityTypeBuilder<ContaBancaria> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CPF)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Agencia)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.ContaCorrente)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Senha8dig)
                .IsRequired()
                .HasColumnType("INT");

            builder.Property(p => p.Senha6dig)
                .IsRequired()
                .HasColumnType("varchar(200)");
        }
    }
}
