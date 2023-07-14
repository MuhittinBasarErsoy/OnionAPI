using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnionAPI.Domain.Entities;
using OnionAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.Contexts
{
    public class OnionAPIDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public OnionAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Mudurluk> Mudurlukler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mudurluk>().HasData(

                new Mudurluk()
                {
                    Id= Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "BALIKESİR",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 1
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "EDREMİT",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 2
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "BANDIRMA",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 3
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "ÇANAKKALE",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 4
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "BİGA",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 5
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "YALOVA",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 6
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "OSMANGAZİ",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 7
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "GEMLİK",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 8
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "İNEGÖL",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 9
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "M.KEMALPAŞA",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 10
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "NİLÜFER",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 11
                },
                new Mudurluk()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Boylam = "",
                    Enlem = "",
                    MudurlukAdi = "YILDIRIM",
                    MudurlukBolgeKodu = 0,
                    MudurlukKodu = 12
                });


            base.OnModelCreating(modelBuilder);

        }

    }
}
