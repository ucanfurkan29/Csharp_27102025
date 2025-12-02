using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RentACar.Models
{
    public class Araba
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MarkaId { get; set; }
        [Required]
        [MaxLength(50)] // Model adı için maksimum uzunluk
        public string Model { get; set; }
        [Required]
        [MaxLength(20)]
        public string Plaka { get; set; }
        [Required]
        public int Yil { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Saatlik ücret negatif olamaz!")]
        public double SaatlikUcret { get; set; }
        [Required]
        public bool Aktif { get; set; }

        public virtual Marka Marka { get; set; }

        public virtual ICollection<Kiralama> Kiralamalar { get; set; }

        public Araba()
        {
            Kiralamalar = new List<Kiralama>();
        }
    }
}
