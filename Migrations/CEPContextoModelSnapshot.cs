﻿// <auto-generated />
using ApiCep2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCep2.Migrations
{
    [DbContext(typeof(CEPContexto))]
    partial class CEPContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("ApiCep2.Models.CEP", b =>
                {
                    b.Property<string>("Cep")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Complemento");

                    b.Property<string>("Ibge");

                    b.Property<string>("Localidade");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Uf");

                    b.Property<string>("Unidade");

                    b.Property<string>("gia");

                    b.HasKey("Cep");

                    b.ToTable("CEP");
                });
#pragma warning restore 612, 618
        }
    }
}
