using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_manav_otomasyonEF.Models
{
    public class Urun
    {
        [Key] //benzersiz anahtar(primary key) olduğunu belirtir
        public int UrunID { get; set; }

        [Required] //boş geçilemez
        [StringLength(50)]
        public string UrunAdi { get; set; }

        [Required] //boş geçilemez
        [StringLength(50)]
        public string Kategori { get; set; }
    }
}
