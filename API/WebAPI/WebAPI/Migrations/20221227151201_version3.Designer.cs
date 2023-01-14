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
    [Migration("20221227151201_version3")]
    partial class version3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Araclar", b =>
                {
                    b.Property<int>("AraclarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AraclarDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarHiz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarRenk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarSeri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarYakit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarYil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AraclarID");

                    b.ToTable("araclars");
                });

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
