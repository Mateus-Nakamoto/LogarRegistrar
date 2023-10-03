﻿// <auto-generated />
using LogarRegistrar.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogarRegistrar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LogarRegistrar.Models.User", b =>
                {
                    b.Property<int>("pessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pessoaId"));

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pessoaEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pessoaNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pessoaSenha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pessoaTipo")
                        .HasColumnType("bit");

                    b.Property<string>("pessoaUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pessoaId");

                    b.ToTable("users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
