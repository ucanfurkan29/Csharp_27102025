using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_manav_otomasyonEF.Models
{
    public class ManavStok
    {
        [Key] //benzersiz anahtar(primary key) olduğunu belirtir
        public int StokID { get; set; }
        public decimal Kilo { get; set; }
        public int UrunID { get; set; }
        public Urun Urun { get; set; } //navigation property
    }
}
