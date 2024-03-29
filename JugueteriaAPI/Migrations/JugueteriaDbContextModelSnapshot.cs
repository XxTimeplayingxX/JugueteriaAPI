﻿// <auto-generated />
using JugueteriaAPI.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JugueteriaAPI.Migrations
{
    [DbContext(typeof(JugueteriaDbContext))]
    partial class JugueteriaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JugueteriaAPI.MODELS.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("JugueteID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("JugueteID");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            JugueteID = 1,
                            Nombre = "Juguetes para niñas"
                        },
                        new
                        {
                            ID = 2,
                            JugueteID = 2,
                            Nombre = "Juguetes para niños"
                        });
                });

            modelBuilder.Entity("JugueteriaAPI.MODELS.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Direccion = "Calle 123",
                            Email = "juan@example.com",
                            NombreCompleto = "Juan Perez"
                        },
                        new
                        {
                            ID = 2,
                            Direccion = "Avenida 456",
                            Email = "maria@example.com",
                            NombreCompleto = "María García"
                        });
                });

            modelBuilder.Entity("JugueteriaAPI.MODELS.Juguete", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Juguetes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Descripcion = "Muñeca de porcelana",
                            Nombre = "Muñeca",
                            Precio = 25m
                        },
                        new
                        {
                            ID = 2,
                            Descripcion = "Carro a control remoto",
                            Nombre = "Carro de Juguete",
                            Precio = 30m
                        });
                });

            modelBuilder.Entity("JugueteriaAPI.MODELS.JugueteDetalle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("JugueteDetalles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClienteID = 1
                        },
                        new
                        {
                            ID = 2,
                            ClienteID = 2
                        });
                });

            modelBuilder.Entity("JugueteriaAPI.MODELS.Categoria", b =>
                {
                    b.HasOne("JugueteriaAPI.MODELS.Juguete", "Juguete")
                        .WithMany()
                        .HasForeignKey("JugueteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juguete");
                });

            modelBuilder.Entity("JugueteriaAPI.MODELS.JugueteDetalle", b =>
                {
                    b.HasOne("JugueteriaAPI.MODELS.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
