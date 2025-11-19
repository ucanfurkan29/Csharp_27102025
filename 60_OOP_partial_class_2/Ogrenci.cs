using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_OOP_partial_class_2
{
    internal partial class Ogrenci
    {
        public int OgrenciNo;
        public string Bolum;
        public int DerslikNo;

        partial void Bilgi(string bolum);

        public void Bilgi2()
        {
            Console.WriteLine("Öğrenci No: " + OgrenciNo);
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("TC: " + Tc);
            Console.WriteLine("Derslik No: " + DerslikNo);

            Bilgi(Bolum);
        }
    }
}
