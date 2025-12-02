using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RentACar.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage ="Maksimum 30 karakter girilebilir!")]
        public string AdSoyad { get; set; }
        [Required]
        [StringLength(11,MinimumLength = 11, ErrorMessage = "Telefon numarası 11 haneli olmalıdır!")]
        public string Telefon { get; set; }
        [Required]
        public double Bakiye { get; set; }
        [Required]
        [MinLength(6, ErrorMessage ="Şifre en az 6 karakter olmalıdır!")]
        public string Password { get; set; }
        public virtual ICollection<Kiralama> Kiralamas { get; set; }
        public Musteri()
        {
            Kiralamas = new List<Kiralama>();
        }

    }
}
