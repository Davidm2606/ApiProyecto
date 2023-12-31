﻿// <auto-generated />
using APIProductos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIProductos.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIProductos.Models.Empleados", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            Cedula = "1721533980",
                            Apellido = "Terán",
                            Edad = 22,
                            Nombre = "David"
                        },
                        new
                        {
                            Cedula = "1700154550",
                            Apellido = "Molina",
                            Edad = 43,
                            Nombre = "Katya"
                        },
                        new
                        {
                            Cedula = "17154550",
                            Apellido = "Terán",
                            Edad = 40,
                            Nombre = "Cristian"
                        },
                        new
                        {
                            Cedula = "1700377052",
                            Apellido = "Rea",
                            Edad = 34,
                            Nombre = "Carmen"
                        });
                });

            modelBuilder.Entity("APIProductos.Models.Platos", b =>
                {
                    b.Property<int>("IdPlato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlato"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IdPlato");

                    b.ToTable("Platos");

                    b.HasData(
                        new
                        {
                            IdPlato = 1,
                            Cantidad = 1,
                            Ingredientes = "salchicha",
                            Nombre = "Salchipapa",
                            Precio = 3
                        },
                        new
                        {
                            IdPlato = 2,
                            Cantidad = 1,
                            Ingredientes = "carne",
                            Nombre = "Hamburguesa",
                            Precio = 4
                        },
                        new
                        {
                            IdPlato = 3,
                            Cantidad = 1,
                            Ingredientes = "carne",
                            Nombre = "Papicarne",
                            Precio = 3
                        },
                        new
                        {
                            IdPlato = 4,
                            Cantidad = 4,
                            Ingredientes = "4 alitas",
                            Nombre = "Alitas",
                            Precio = 5
                        });
                });

            modelBuilder.Entity("APIProductos.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Cantidad = 10,
                            Nombre = "Salchichas",
                            Valor = 6
                        },
                        new
                        {
                            IdProducto = 2,
                            Cantidad = 20,
                            Nombre = "carne",
                            Valor = 6
                        },
                        new
                        {
                            IdProducto = 3,
                            Cantidad = 30,
                            Nombre = "Alitas",
                            Valor = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
