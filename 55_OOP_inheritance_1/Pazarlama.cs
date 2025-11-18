using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_OOP_inheritance_1
{
    internal class Pazarlama : Personel
    {
        public int MusteriSayisi { get; set; }
        public void Yaz()
        {
            Console.WriteLine($"Adı: {Ad} - Soyad: {Soyad} - Yaş: {Yas} - Müşteri Sayisi {MusteriSayisi}");
        }
    }
}
