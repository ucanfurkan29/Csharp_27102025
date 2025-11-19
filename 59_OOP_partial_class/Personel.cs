using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_OOP_partial_class
{
    partial class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public Personel()
        {
            
        }

        public void BilgiYazdir(int Id)
        {
            Console.WriteLine($"Personel Bilgi Yazdir metodu");
        }
        public void Deneme()
        {
            Console.WriteLine("Deneme");
        }

        //Partial metotlar void tipinde olmak zorundadır.
        //Default olarak private erişim belirleyicisine sahiptirler.
        //Zorunlu değildir: imzasını atıp gövdesini tanımlamayabilirsin ve program hata vermez. metot yokmuş gibi çalışmaya devam eder.

        partial void KayitOncesiKontrol(); //Gövdesiz metot  



        public void Kaydet()
        {

            KayitOncesiKontrol(); //Gövdesiz metot çağrısı. Çağırabilirsin ama çağırmak zorunda da değilsin. isteğe bağlı. 

            Console.WriteLine("Personel Veritabanına kaydediliyor...");
        }

    }
}
