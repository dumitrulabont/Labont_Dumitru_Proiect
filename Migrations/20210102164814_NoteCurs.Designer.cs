﻿// <auto-generated />
using System;
using Labont_Dumitru_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labont_Dumitru_Proiect.Migrations
{
    [DbContext(typeof(Labont_Dumitru_ProiectContext))]
    [Migration("20210102164814_NoteCurs")]
    partial class NoteCurs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labont_Dumitru_Proiect.Models.Curs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfesorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProfesorID");

                    b.ToTable("Curs");
                });

            modelBuilder.Entity("Labont_Dumitru_Proiect.Models.Nota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("ValoareNota")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CursID");

                    b.HasIndex("StudentID");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("Labont_Dumitru_Proiect.Models.Profesor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNasteri")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Labont_Dumitru_Proiect.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNasterii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipScolarizare")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Labont_Dumitru_Proiect.Models.Curs", b =>
                {
                    b.HasOne("Labont_Dumitru_Proiect.Models.Profesor", "Profesor")
                        .WithMany("Cursuri")
                        .HasForeignKey("ProfesorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labont_Dumitru_Proiect.Models.Nota", b =>
                {
                    b.HasOne("Labont_Dumitru_Proiect.Models.Curs", "Curs")
                        .WithMany("Note")
                        .HasForeignKey("CursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labont_Dumitru_Proiect.Models.Student", "Student")
                        .WithMany("Note")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
