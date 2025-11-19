using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_OOP_partial_class
{
    partial class Personel
    {
        public int Yas { get; set; }

        public Personel(string name)
        {
            Ad = name;
        }
        public void BilgiYazdir()
        {
            Console.WriteLine($"Personel Bilgi Yazdir metodu - partial class 2. dosya");
        }
        public void Test()
        {
            Console.WriteLine("Test");
        }

        //partial void KayitOncesiKontrol() //Gövdesiz metot gövdesi burada tanımlanıyor
        //{
        //    Console.WriteLine("Log: Kayıt Öncesi log alındı");
        //    Console.WriteLine($"LOG : {this.Ad} sisteme eklenmek üzere.");

        //}
    }
}
