﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataHämtare))]
    partial class DataHämtareModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Beställning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beskrivning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBekräftad")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBetald")
                        .HasColumnType("bit");

                    b.Property<int>("KundID")
                        .HasColumnType("int");

                    b.Property<string>("Land")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeveransAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Postnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SkapadDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPris")
                        .HasColumnType("float");

                    b.Property<double>("TotalUtgift")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("KundID");

                    b.HasIndex("PersonalId");

                    b.ToTable("Beställningar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Beskrivning = "abc",
                            IsBekräftad = false,
                            IsBetald = false,
                            KundID = 1,
                            Land = "Sverige",
                            LeveransAdress = "abcgatan",
                            Ort = "Örebro",
                            PersonalId = 1,
                            Postnummer = "12345",
                            SkapadDatum = new DateTime(2023, 4, 27, 10, 56, 20, 183, DateTimeKind.Local).AddTicks(1807),
                            Status = "Ny beställning",
                            TotalPris = 1500.0,
                            TotalUtgift = 800.0
                        });
                });

            modelBuilder.Entity("Models.Dekoration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dekorationer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Pris = 100.0,
                            Typ = "Fjädrar"
                        },
                        new
                        {
                            Id = 2,
                            Pris = 150.0,
                            Typ = "Band"
                        },
                        new
                        {
                            Id = 3,
                            Pris = 125.0,
                            Typ = "Blommor"
                        });
                });

            modelBuilder.Entity("Models.Hatt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BeställningsID")
                        .HasColumnType("int");

                    b.Property<double>("Materialkostnad")
                        .HasColumnType("float");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("Storlek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TidsÅtgång")
                        .HasColumnType("float");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BeställningsID");

                    b.ToTable("Hattar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeställningsID = 1,
                            Materialkostnad = 800.0,
                            Pris = 1500.0,
                            Storlek = "M",
                            TidsÅtgång = 0.0,
                            Typ = "Lagerförd hatt"
                        });
                });

            modelBuilder.Entity("Models.HattDekoration", b =>
                {
                    b.Property<int>("HattId")
                        .HasColumnType("int");

                    b.Property<int>("DekorationId")
                        .HasColumnType("int");

                    b.Property<int>("Antal")
                        .HasColumnType("int");

                    b.HasKey("HattId", "DekorationId");

                    b.HasIndex("DekorationId");

                    b.ToTable("HattDekorationer");
                });

            modelBuilder.Entity("Models.HattMaterial", b =>
                {
                    b.Property<int>("HattId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<double>("Mängd")
                        .HasColumnType("float");

                    b.HasKey("HattId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.ToTable("HattMaterial");
                });

            modelBuilder.Entity("Models.Kund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Land")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kunder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "abcgatan 5",
                            Email = "123@abc.se",
                            Land = "Sverige",
                            Name = "Erik",
                            Ort = "Örebro",
                            Postnummer = "123 56",
                            TelefonNummer = "0701234567"
                        });
                });

            modelBuilder.Entity("Models.LagerfördHatt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Materialkostnad")
                        .HasColumnType("float");

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("LagerfördHatt");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Materialkostnad = 800.0,
                            Namn = "Doktorshatt",
                            Pris = 8000.0
                        });
                });

            modelBuilder.Entity("Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("MeterPris")
                        .HasColumnType("float");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Material");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MeterPris = 100.0,
                            Typ = "Bomull"
                        },
                        new
                        {
                            Id = 2,
                            MeterPris = 125.0,
                            Typ = "Linne"
                        },
                        new
                        {
                            Id = 3,
                            MeterPris = 150.0,
                            Typ = "Ull"
                        },
                        new
                        {
                            Id = 4,
                            MeterPris = 175.0,
                            Typ = "Silke"
                        },
                        new
                        {
                            Id = 5,
                            MeterPris = 200.0,
                            Typ = "Satin"
                        },
                        new
                        {
                            Id = 6,
                            MeterPris = 225.0,
                            Typ = "Tweed"
                        },
                        new
                        {
                            Id = 7,
                            MeterPris = 75.0,
                            Typ = "Polyester"
                        });
                });

            modelBuilder.Entity("Models.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Lösenord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lösenord = "123",
                            Name = "Judith"
                        },
                        new
                        {
                            Id = 2,
                            Lösenord = "123",
                            Name = "Otto"
                        });
                });

            modelBuilder.Entity("Models.Beställning", b =>
                {
                    b.HasOne("Models.Kund", null)
                        .WithMany("Beställningar")
                        .HasForeignKey("KundID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Personal", "Personal")
                        .WithMany()
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Models.Hatt", b =>
                {
                    b.HasOne("Models.Beställning", "Beställning")
                        .WithMany("Hattar")
                        .HasForeignKey("BeställningsID");

                    b.Navigation("Beställning");
                });

            modelBuilder.Entity("Models.HattDekoration", b =>
                {
                    b.HasOne("Models.Dekoration", "Dekoration")
                        .WithOne("HattDekoration")
                        .HasForeignKey("Models.HattDekoration", "DekorationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Hatt", "Hatt")
                        .WithMany("Dekorationer")
                        .HasForeignKey("HattId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dekoration");

                    b.Navigation("Hatt");
                });

            modelBuilder.Entity("Models.HattMaterial", b =>
                {
                    b.HasOne("Models.Hatt", "Hatt")
                        .WithMany("Material")
                        .HasForeignKey("HattId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Material", "Material")
                        .WithOne("HattMaterial")
                        .HasForeignKey("Models.HattMaterial", "MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hatt");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Models.Beställning", b =>
                {
                    b.Navigation("Hattar");
                });

            modelBuilder.Entity("Models.Dekoration", b =>
                {
                    b.Navigation("HattDekoration")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Hatt", b =>
                {
                    b.Navigation("Dekorationer");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Models.Kund", b =>
                {
                    b.Navigation("Beställningar");
                });

            modelBuilder.Entity("Models.Material", b =>
                {
                    b.Navigation("HattMaterial")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
