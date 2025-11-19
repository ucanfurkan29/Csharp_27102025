using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_OOP_partial_class_2
{
    internal partial class Ogrenci
    {
        public string Tc;
        public string Ad;
        public string Soyad;

        partial void Bilgi(string bolum)
        {
            Console.WriteLine("Bölüm: " + bolum);
        }
    }
}
