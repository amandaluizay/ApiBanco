﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20221014202018_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Business.Models.ContaBancaria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ContaCorrente")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Senha6dig")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Senha8dig")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.ToTable("ContaBancarias");
                });
#pragma warning restore 612, 618
        }
    }
}
