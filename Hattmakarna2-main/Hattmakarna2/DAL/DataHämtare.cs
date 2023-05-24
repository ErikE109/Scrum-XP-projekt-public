using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    internal class DataHämtare : DbContext
    {
        public DataHämtare()
        {

        }

        public DbSet<Beställning> Beställningar { get; set; }

        public DbSet<Dekoration> Dekorationer { get; set; }


        public DbSet<Hatt> Hattar { get; set; }

        public DbSet<Kund> Kunder { get; set; }

        public DbSet<Material> Material { get; set; }

        public DbSet<Personal> Personal { get; set; }

        public DbSet<HattDekoration> HattDekorationer { get; set; }

        public DbSet<HattMaterial> HattMaterial { get; set; }

        public DbSet<LagerfördHatt> LagerfördHatt { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Keys


            modelBuilder.Entity<HattDekoration>().HasIndex(
                hd => hd.DekorationId).IsUnique(false);



            modelBuilder.Entity<HattMaterial>().HasIndex(
                ht => ht.MaterialId).IsUnique(false);


            //Exempeldata

            modelBuilder.Entity<LagerfördHatt>().HasData(
                new LagerfördHatt
                {
                    Id = 1,
                    Namn = "Doktorshatt",
                    Pris = 8000,
                    Materialkostnad = 800
                }
                );

            modelBuilder.Entity<Kund>().HasData(
                new Kund
                {
                    Id = 1,
                    Name = "Erik",
                    Adress = "abcgatan 5",
                    Postnummer = "123 56",
                    Ort = "Örebro",
                    Land = "Sverige",
                    Email = "123@abc.se",
                    TelefonNummer = "0701234567"
                }
                );

            modelBuilder.Entity<Hatt>().HasData(
                new Hatt
                {
                    Id = 1,
                    Storlek = "M",
                    Dekorationer = null,
                    Material = null,
                    Pris = 1500,
                    Materialkostnad = 800,
                    BeställningsID = 1,
                    Typ = "Lagerförd hatt"



                });


            modelBuilder.Entity<Beställning>().HasData(
                new Beställning
                {
                    Id = 1,
                    KundID = 1,
                    PersonalId = 1,
                    LeveransAdress = "abcgatan",
                    Postnummer = "12345",
                    Ort = "Örebro",
                    Land = "Sverige",
                    TotalPris = 1500,
                    TotalUtgift = 800,
                    Hattar = null,
                    Beskrivning = "abc",

                    SkapadDatum = DateTime.Now,
                }

                );

            modelBuilder.Entity<Personal>().HasData(
                 new Personal
                 {
                     Id = 1,
                     Name = "Judith",
                     Lösenord = "123"

                 },
                 new Personal()
                 {
                     Id = 2,
                     Name = "Otto",
                     Lösenord = "123"
                 });

            modelBuilder.Entity<Dekoration>().HasData(
                new Dekoration
                {
                    Id = 1,
                    Typ = "Fjädrar",
                    Pris = 100,
                },
                new Dekoration
                {
                    Id = 2,
                    Typ = "Band",
                    Pris = 150,
                },
                new Dekoration
                {
                    Id = 3,
                    Typ = "Blommor",
                    Pris = 125,


                });




            modelBuilder.Entity<Material>().HasData(
                new Material
                {
                    Id = 1,
                    Typ = "Bomull",
                    MeterPris = 100

                },
                new Material
                {
                    Id = 2,
                    Typ = "Linne",
                    MeterPris = 125

                },
                new Material
                {
                    Id = 3,
                    Typ = "Ull",
                    MeterPris = 150

                },
                new Material
                {
                    Id = 4,
                    Typ = "Silke",
                    MeterPris = 175

                },
                new Material
                {
                    Id = 5,
                    Typ = "Satin",
                    MeterPris = 200

                },
                new Material
                {
                    Id = 6,
                    Typ = "Tweed",
                    MeterPris = 225

                },
                new Material
                {
                    Id = 7,
                    Typ = "Polyester",
                    MeterPris = 75

                }
                );

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data source=.\\SQLEXPRESS; TrustServerCertificate=True; Initial Catalog = Hattmakarna; Trusted_Connection=True; Integrated security = true");
        }
    }
}