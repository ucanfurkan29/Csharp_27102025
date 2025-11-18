using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_OOP_inheritance_1
{
    internal class IK : Personel // IK sınıfı Personel sınıfından miras alır
    {
        public int PersonelSayisi { get; set; }

        public void Yaz()
        {
            Console.WriteLine($"Adı: {Ad} - Soyad: {Soyad} - Yaş: {Yas} - Personel Sayisi {PersonelSayisi}");
        }
    }
}
