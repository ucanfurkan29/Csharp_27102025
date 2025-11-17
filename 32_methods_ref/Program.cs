namespace _32_methods_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ref anahtar kelimesi, bir değişkenin değerini değil adresini metoda gönderilmesini sağlar. Böylece metot içinde yapılan değişiklikler asıl değişkeni de etkiler.
            //Değişken Metoda gönderilmeden önce mutlaka tanımlanmalıdır.
            //metot içinde ve çağırılırken ref ile belirtilmeli

            /*
             ref ve out farkı
                Özellik	                                    ref	                          |  out
            -----------------------------------------------------------------------------------
                Metottan önce değer atanmalı mı?	        ✅ Evet	                      | ❌ Hayır
                Metot içinde yeni değer atanmalı mı?	    Gerekmez	                  | ✅ Evet
                Amaç	                                    Var olan değeri değiştirmek	  | Yeni değer döndürmek
                Kullanım örneği	                            Değer güncelleme, takas işlemi| TryParse, birden fazla değer döndürme
             */

            int x = 15;
            Degistir(ref x);
            Console.WriteLine(x);

            Console.WriteLine("-------------");
            //Örnek: Bakkala gelen ürünlerin fiyatlarına kar koyma
            double urunFiyati = 500;
            double urunFiyati2 = 500;
            FiyatGuncelle(ref urunFiyati,1.15);
            FiyatGuncelle(ref urunFiyati2,0.85);
            Console.WriteLine($"Yeni Fiyat Urun1: {urunFiyati}");
            Console.WriteLine($"Yeni Fiyat Urun2: {urunFiyati2}");
        }

        static void Degistir(ref int sayi)
        {
            sayi = sayi + 10;
        }
        static void FiyatGuncelle(ref double fiyat, double guncellemeOrani)
        {
            fiyat = fiyat * guncellemeOrani;
        }
    }
}
