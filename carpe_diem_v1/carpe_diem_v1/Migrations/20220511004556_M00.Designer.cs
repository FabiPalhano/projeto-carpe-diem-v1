﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using carpe_diem_v1.Models;

namespace carpe_diem_v1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220511004556_M00")]
    partial class M00
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("carpe_diem_v1.Models.Hospede", b =>
                {
                    b.Property<string>("Cpf")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("DataNascimento")
                        .HasColumnType("int");

                    b.Property<string>("EmailHospede")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NomeCompHospede")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Cpf");

                    b.ToTable("Hospedes");
                });
#pragma warning restore 612, 618
        }
    }
}
