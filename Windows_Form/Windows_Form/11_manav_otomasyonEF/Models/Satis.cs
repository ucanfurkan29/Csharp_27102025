using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_manav_otomasyonEF.Models
{
    public class Satis
    {
        [Key] //benzersiz anahtar(primary key) olduğunu belirtir
        public int SatisID { get; set; }
        [StringLength(50)]
        public string UrunAdi { get; set; }
        public decimal Kilo { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
