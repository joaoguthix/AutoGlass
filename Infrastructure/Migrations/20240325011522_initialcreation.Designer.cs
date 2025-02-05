﻿// <auto-generated />
using System;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(SqlLiteDbContext))]
    [Migration("20240325011522_initialcreation")]
    partial class initialcreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("EntitieProduct.Product", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJFornecedor")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodigoFornecedor")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescricaoFornecedor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Situacao")
                        .HasColumnType("TEXT");

                    b.HasKey("Codigo");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
