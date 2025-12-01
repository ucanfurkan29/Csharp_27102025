using _11_manav_otomasyonEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_manav_otomasyonEF.Data
{
    public class ManavContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<ManavStok> ManavStoklar { get; set; }
        public DbSet<Satis> Satislar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=204-HOCAPC1;Initial Catalog=ManavDB_EF;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
