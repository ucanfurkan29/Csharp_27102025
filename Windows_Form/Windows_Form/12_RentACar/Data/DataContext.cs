using _12_RentACar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RentACar.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=204-HOCAPC1;Database=RentACarDb;uid=sa;pwd=1;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//ilişkileri kurmak için kullanılır
        {
            modelBuilder.Entity<Araba>()
                .HasOne(a => a.Marka) //bire çok ilişki, bir markanın birden çok arabası olabilir
                .WithMany(m => m.Arabalar)
                .HasForeignKey(a => a.MarkaId);
            modelBuilder.Entity<Kiralama>() //bire çok ilişki, bir müşterinin birden çok kiralaması olabilir
                .HasOne(k=>k.Musteri)
                .WithMany(m=>m.Kiralamas)
                .HasForeignKey(k=>k.MusteriId);
            modelBuilder.Entity<Kiralama>()
                .HasOne(k => k.Araba) //bire çok ilişki, bir arabanın birden çok kiralaması olabilir
                .WithMany(a => a.Kiralamalar)
                .HasForeignKey(k => k.ArabaId);
        }
        //DbSet'ler
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
    }
}
