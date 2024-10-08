﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Context;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241002014425_ModificacionFaltante")]
    partial class ModificacionFaltante
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Models.Juego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Juegos");
                });

            modelBuilder.Entity("WebApi.Models.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("WebApi.Models.Opcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Opciones");
                });

            modelBuilder.Entity("WebApi.Models.Ronda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_JuegoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_JuegoId");

                    b.ToTable("Rondas");
                });

            modelBuilder.Entity("WebApi.Models.RondasJugadas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_JugadoresId")
                        .HasColumnType("int");

                    b.Property<int>("Id_OpcionId")
                        .HasColumnType("int");

                    b.Property<int>("Id_RondasId")
                        .HasColumnType("int");

                    b.Property<bool>("Victoria")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_JugadoresId");

                    b.HasIndex("Id_OpcionId");

                    b.HasIndex("Id_RondasId");

                    b.ToTable("RondasJugadas");
                });

            modelBuilder.Entity("WebApi.Models.Ronda", b =>
                {
                    b.HasOne("WebApi.Models.Juego", "Id_Juego")
                        .WithMany()
                        .HasForeignKey("Id_JuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id_Juego");
                });

            modelBuilder.Entity("WebApi.Models.RondasJugadas", b =>
                {
                    b.HasOne("WebApi.Models.Jugador", "Id_Jugadores")
                        .WithMany()
                        .HasForeignKey("Id_JugadoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Opcion", "Id_Opcion")
                        .WithMany()
                        .HasForeignKey("Id_OpcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Ronda", "Id_Rondas")
                        .WithMany()
                        .HasForeignKey("Id_RondasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id_Jugadores");

                    b.Navigation("Id_Opcion");

                    b.Navigation("Id_Rondas");
                });
#pragma warning restore 612, 618
        }
    }
}
