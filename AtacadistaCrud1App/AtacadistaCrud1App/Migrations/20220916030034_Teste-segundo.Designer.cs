﻿// <auto-generated />
using AtacadistaCrud1App.Models.ContextoDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AtacadistaCrud1App.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220916030034_Teste-segundo")]
    partial class Testesegundo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AtacadistaCrud1App.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Categoria");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("Quantidade")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.Property<int>("Valor")
                       .IsRequired()
                       .HasColumnType("int")
                       .HasColumnName("Valor");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
