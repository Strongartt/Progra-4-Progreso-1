﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Progra_4_Progreso_1.Data;

#nullable disable

namespace Progra_4_Progreso_1.Migrations
{
    [DbContext(typeof(Progra_4_Progreso_1Context))]
    [Migration("20240502125645_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Progra_4_Progreso_1.Models.Carrera", b =>
                {
                    b.Property<int>("Idcarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idcarrera"), 1L, 1);

                    b.Property<string>("Nombre_carrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero_semestre")
                        .HasColumnType("int");

                    b.Property<string>("campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idcarrera");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("Progra_4_Progreso_1.Models.Ricardo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Calificacion")
                        .HasColumnType("real");

                    b.Property<int>("CarreraIdcarrera")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EstadoFecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Idcarrera")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarreraIdcarrera");

                    b.ToTable("Ricardo");
                });

            modelBuilder.Entity("Progra_4_Progreso_1.Models.Ricardo", b =>
                {
                    b.HasOne("Progra_4_Progreso_1.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraIdcarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });
#pragma warning restore 612, 618
        }
    }
}