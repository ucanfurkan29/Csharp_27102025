using System;

namespace _07_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Scopesuz kullanım
            //if (false) //scope demek => {} demektir
            //    Console.WriteLine("Scopesuz if kullanımı.");

            //if (false) Console.WriteLine("Scopesuz if kullanımı2");
            #endregion

            #region Birden fazla if Kullanımı
            //Console.WriteLine("Bir Sayı Giriniz: ");

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı Sıfırdan Büyüktür");
            //}
            //if (sayi <0)
            //{
            //    Console.WriteLine("Sayı Sıfırdan Küçüktür.");
            //}
            //if (sayi == 0 )
            //{
            //    Console.WriteLine("Sayı sıfıra eşittir");
            //}
            //if (sayi != 0)
            //{
            //    Console.WriteLine("Sayı Sıfırdan Farklıdır.");
            //}

            #endregion

            #region İç İçe İf
            //ve &&
            //string kullaniciAdi = "Furkan";
            //string password = "1234";

            //Console.WriteLine("Lütfen Kullanıcı Adınızı Girin:");
            //string kad = Console.ReadLine();
            //if (kad == kullaniciAdi)
            //{
            //    Console.WriteLine("Lütfen Şifre Girin:");
            //    string pass = Console.ReadLine();
            //    if (pass == password)
            //    {
            //        Console.WriteLine("Sisteme Giriş Başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Parola hatalı");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı!");
            //}

            //SORU: Kullanıcı adı ve şifre kontorlünü tek if içerisnde && operaötür ile yapın
            //Console.WriteLine("Lütfen Kullanıcı Adınızı Girin:");
            //string kad2 = Console.ReadLine();
            //Console.WriteLine("Lütfen Şifre Girin:");
            //string pass2 = Console.ReadLine();

            //if (kad2 == kullaniciAdi && pass2 == password)
            //{
            //    Console.WriteLine("Sisteme Giriş Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı Veya Şifre yanlış!");
            //}

            #endregion

            //kullanıcıdan girdiği sayı değerini alıp öncelikle 0dan büyük olup olmadığını kontrol edin. 0dan büyükse 100den büyük veya küçük olup olmadığını kontrol edin.

            //Console.WriteLine("Bir sayı girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    if (sayi >= 100)
            //    {
            //        if (sayi > 100)
            //        {
            //            Console.WriteLine("Sayı 100den büyüktür: " + sayi);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayı 100e eşittir: " + sayi);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 100den Küçüktür: " + sayi);
            //    }
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı Sıfırdan Küçüktür: " + sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Sıfıra Eşittir: " + sayi);
            //}





            //Kullanıcının girdiği sayı tek mi çift mi kontrol eden koşulu yazın

            //Console.WriteLine("Sayı girin:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çift Sayıdır: " + sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tek Sayıdır: " + sayi);
            //}

            //Kullanıcıdan aylık geliri istenecek  eğer geliri 40000 üstünde ise %12 lik vergi kesilecek
            //40000 tl ve altında ise %9 vergi kesilecek  kullanıcıya yeni gelirini
            //bu hesaplamalar sonucunda göstereceğiz

            //Console.WriteLine("Maaşınızı girin:");
            //double maas = Convert.ToInt32(Console.ReadLine());

            //if (maas > 40000)
            //{
            //    Console.WriteLine("%12 vergi kesilmiş maaşınız " + maas *0.88);
            //}
            //else
            //{
            //    Console.WriteLine("%9 vergi kesilmiş maaşınız " + maas *0.91);
            //}
        }
    }
}
