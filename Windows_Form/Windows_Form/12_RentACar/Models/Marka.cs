using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RentACar.Models
{
    public class Marka
    {
        [Key] // Birincil anahtar
        public int Id { get; set; }
        [Required] // Ad alanı zorunlu
        public string Ad { get; set; }
        public virtual ICollection<Araba> Arabalar { get; set; } // Marka ile ilişkili arabalar
        public Marka() // Varsayılan yapıcı
        {
            Arabalar = new List<Araba>(); // Arabalar koleksiyonunu başlat
        }
    }
}
