﻿// <auto-generated />
using System;
using Actividad_18.Server.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Actividad_18.Server.Migrations
{
    [DbContext(typeof(ContextoTienda))]
    partial class ContextoTiendaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Actividad_18.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Pedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientesId")
                        .HasColumnType("int");

                    b.Property<string>("DireccionEntrega")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Productos", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("PedidosId")
                        .HasColumnType("int");

                    b.Property<string>("medidas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("precio")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("talla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PedidosId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Pedidos", b =>
                {
                    b.HasOne("Actividad_18.Shared.Models.Clientes", "Cliente")
                        .WithMany("Pedido")
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Productos", b =>
                {
                    b.HasOne("Actividad_18.Shared.Models.Pedidos", "Pedidos")
                        .WithMany("Producto")
                        .HasForeignKey("PedidosId");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Clientes", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Pedidos", b =>
                {
                    b.Navigation("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}