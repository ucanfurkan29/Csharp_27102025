using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RentACar.Models
{
    public class Kiralama
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MusteriId { get; set; }
        [Required]
        public int ArabaId { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        [Required]
        public double ToplamTutar { get; set; }
        [ForeignKey("MusteriId")] // Navigation property: Musteri sınıfından MusteriId ile ilişki kuruluyor
        public virtual Musteri Musteri { get; set; }
        [ForeignKey("ArabaId")]
        public virtual Araba Araba { get; set; }
    }
}
