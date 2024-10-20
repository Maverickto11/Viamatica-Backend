﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Técnica.TuDbContex;

#nullable disable

namespace Prueba_Técnica.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240812083842_V2")]
    partial class V2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prueba_Técnica.Entidades.DetalleFactura", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("FacturaId")
                        .HasColumnType("int");

                    b.Property<decimal?>("IVA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Producto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetalleId");

                    b.HasIndex("FacturaId");

                    b.ToTable("DetalleFacturas");
                });

            modelBuilder.Entity("Prueba_Técnica.Entidades.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacturaId"));

                    b.Property<decimal?>("BaseIVA0")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BaseIVA12")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("IVA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FacturaId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Prueba_Técnica.Entidades.DetalleFactura", b =>
                {
                    b.HasOne("Prueba_Técnica.Entidades.Factura", "Factura")
                        .WithMany("Detalles")
                        .HasForeignKey("FacturaId");

                    b.Navigation("Factura");
                });

            modelBuilder.Entity("Prueba_Técnica.Entidades.Factura", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
