﻿// <auto-generated />
using System;
using ApiReparacion.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiReparacion.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230627044013_asd")]
    partial class asd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiReparacion.Models.DetalleReparacion", b =>
                {
                    b.Property<int>("idDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idDetalle"), 1L, 1);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<double>("igv")
                        .HasColumnType("float");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precioUnitario")
                        .HasColumnType("float");

                    b.Property<int>("reparacionId")
                        .HasColumnType("int");

                    b.Property<double>("subtotal")
                        .HasColumnType("float");

                    b.HasKey("idDetalle");

                    b.HasIndex("reparacionId");

                    b.ToTable("detalleReparacion");
                });

            modelBuilder.Entity("ApiReparacion.Models.Reparacion", b =>
                {
                    b.Property<int>("idReparacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idReparacion"), 1L, 1);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empleadoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("idReparacion");

                    b.ToTable("reparacion");
                });

            modelBuilder.Entity("ApiReparacion.Models.DetalleReparacion", b =>
                {
                    b.HasOne("ApiReparacion.Models.Reparacion", "reparacion")
                        .WithMany("detalles")
                        .HasForeignKey("reparacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("reparacion");
                });

            modelBuilder.Entity("ApiReparacion.Models.Reparacion", b =>
                {
                    b.Navigation("detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
