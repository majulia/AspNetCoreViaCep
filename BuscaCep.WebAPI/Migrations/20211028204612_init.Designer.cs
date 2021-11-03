﻿// <auto-generated />
using BuscaCep.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuscaCep.WebApi.Migrations
{
    [DbContext(typeof(BuscaContext))]
    [Migration("20211028204612_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("BuscaCep.WebApi.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uf")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bairro = "Pedregulho",
                            Cep = "12515160",
                            Complemento = "",
                            Localidade = "Guaratinguetá",
                            Logradouro = "Rua Alfonso Giannico",
                            Uf = "SP"
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Pedregulho",
                            Cep = "12345678",
                            Complemento = "",
                            Localidade = "Guaratinguetá",
                            Logradouro = "Rua Alfonso Giannico",
                            Uf = "SP"
                        },
                        new
                        {
                            Id = 3,
                            Bairro = "Pedregulho",
                            Cep = "87654321",
                            Complemento = "",
                            Localidade = "Guaratinguetá",
                            Logradouro = "Rua Alfonso Giannico",
                            Uf = "SP"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}