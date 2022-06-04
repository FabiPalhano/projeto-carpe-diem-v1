﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using carpe_diem_v2.Models;

#nullable disable

namespace carpe_diem_v2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220529233518_M04")]
    partial class M04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("carpe_diem_v2.Models.CadastroImovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("DesativarImovel")
                        .HasColumnType("bit");

                    b.Property<bool>("DisponibilizarImovel")
                        .HasColumnType("bit");

                    b.Property<int>("DistPraia")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fotos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HoraCheckin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraCheckout")
                        .HasColumnType("datetime2");

                    b.Property<int>("HospedeId")
                        .HasColumnType("int");

                    b.Property<string>("InfAdicionais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpOferecer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantBanheiros")
                        .HasColumnType("int");

                    b.Property<int>("QuantCamas")
                        .HasColumnType("int");

                    b.Property<int>("QuantHospedes")
                        .HasColumnType("int");

                    b.Property<int>("TipoAcomodacao")
                        .HasColumnType("int");

                    b.Property<int>("TipoEspaco")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HospedeId");

                    b.ToTable("CadastroImovel");
                });

            modelBuilder.Entity("carpe_diem_v2.Models.Hospede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<int>("DataNascimento")
                        .HasColumnType("int");

                    b.Property<string>("EmailHospede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompHospede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hospedes");
                });

            modelBuilder.Entity("carpe_diem_v2.Models.CadastroImovel", b =>
                {
                    b.HasOne("carpe_diem_v2.Models.Hospede", "Hospede")
                        .WithMany("CadastroImovel")
                        .HasForeignKey("HospedeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospede");
                });

            modelBuilder.Entity("carpe_diem_v2.Models.Hospede", b =>
                {
                    b.Navigation("CadastroImovel");
                });
#pragma warning restore 612, 618
        }
    }
}
