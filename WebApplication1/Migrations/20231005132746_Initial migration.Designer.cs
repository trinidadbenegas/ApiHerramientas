﻿// <auto-generated />
using HerramientasApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HerramientasApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231005132746_Initial migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HerramientasApi.Models.Herramienta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApellidoReservante")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Disponibilidad")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("NombreReservante")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoHerramienta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Herramientas");
                });
#pragma warning restore 612, 618
        }
    }
}