﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221207164627_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Subeler", b =>
                {
                    b.Property<int>("SubelerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubelerAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubelerIl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubelerImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubelerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubelerTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubelerID");

                    b.ToTable("subelers");
                });

            modelBuilder.Entity("WebAPI.Models.Urunler", b =>
                {
                    b.Property<int>("UrunlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UrunlerImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunlerKisaAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunlerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunlerUzunAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunlerID");

                    b.ToTable("urunlers");
                });
#pragma warning restore 612, 618
        }
    }
}