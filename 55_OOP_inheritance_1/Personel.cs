using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_OOP_inheritance_1
{
    internal class Personel
    {
        public int TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public int Yas { get; set; }

        public void BilgiGetir()
        {
            Console.WriteLine($"TC: {TC}, Ad: {Ad}, Soyad: {Soyad}, Adres: {Adres}, Yas: {Yas}");
        }
    }
}
