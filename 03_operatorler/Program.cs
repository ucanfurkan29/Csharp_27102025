namespace _03_operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konsola Çıktı Verme
            //Console.WriteLine(20);
            //Console.WriteLine("Merhaba");
            //Console.WriteLine('A');
            //Console.WriteLine(true);
            //Console.WriteLine(20.5);


            //string sayi1 = "10";
            //int sayi2 = 10;
            //string metin = "Dünya";
            //Console.WriteLine(sayi1 + metin);
            //Console.WriteLine(sayi1 + sayi2);
            #endregion

            #region Aritmatik Operatorler
            /*
             +,-,*,/,%
                % => mod alma operatörü bir sayının diğer sayıya bölümünden kalanı bize verir.
             */
            //int sayi1 = 10;
            //double sayi2 = 3;
            //double sonuc = sayi1 / sayi2;
            //Console.WriteLine(sonuc);

            //int s1 = 17;
            //int s2 = 2;
            //Console.WriteLine(s1 + s2);
            //Console.WriteLine(s1 - s2);
            //Console.WriteLine(s1 * s2);
            //Console.WriteLine(s1 / s2);
            //Console.WriteLine($"Mod {s1 % s2}"); //Bir sayının bölümünden kalanı verir.
            #endregion

            #region Atama Operatorleri
            /*
             = -> sağdaki değeri soldaki değişkene atar.
            += -> sağdaki değeri soldaki değişkene ekler.
            -= -> sağdaki değeri soldaki değişkenden çıkarır.
            *=
            /= 
            .  -> Console.WriteLine()  nokta erişim operatorüdür
            ++ -> 1 artırma operatörü
            -- -> 1 eksiltme operatörü
             */

            //int s1 = 10;
            //int s2 = 20;
            //s1 *= 3; // s1 = s1 * 3;
            //s1 /= 2;
            //s1++;
            //Console.WriteLine(s1); 
            #endregion

            #region Karşılaştırma Operatörleri
            /* Karşılaştırma Operatörleri true ya da false değerini döndürür.
             
                > -> Büyük mü?
                < -> Küçük mü?
                >= -> Büyük Veya eşit mi?
                <= -> Küçük veya eşit mi?
                == -> Eşit Mi?
                != -> Farklı Mı?
             */

            int sayi1 = 10;
            int sayi2 = 5;

            bool sonuc = sayi1 > sayi2;
            bool sonuc2 = sayi1 < sayi2;
            bool sonuc3 = sayi1 >= sayi2;
            bool sonuc4 = sayi1 <= sayi2;
            bool sonuc5 = sayi1 == sayi2;
            bool sonuc6 = sayi1 != sayi2;

            Console.WriteLine($"Sonuc1: {sonuc}");
            Console.WriteLine($"Sonuc2: {sonuc2}");
            Console.WriteLine($"Sonuc3: {sonuc3}");
            Console.WriteLine($"Sonuc4: {sonuc4}");
            Console.WriteLine($"Sonuc5: {sonuc5}");
            Console.WriteLine($"Sonuc6: {sonuc6}");

            Console.WriteLine($"15 == 15:{15==15}");
            Console.WriteLine($"15 != 15:{15!=15}");
            Console.WriteLine($"15 >= 15:{15>=15}");
            Console.WriteLine($"15 <= 15:{15<=15}");


            #endregion

            #region Mantıksal Operatörler

            /* And(&&, Ve), Or(||, Veya)


            // Birden fazla koşul belirtilmesi durumunda koşulların kontrol edilmesi için kullanılan operatörlerdir.

            Ve (&&)
            True - 1, False - 0
             s1  &&  s2 sonuc
              1      1    1
              1      0    0
              0      1    0
              0      0    0

           Veya (||)
            True - 1, False - 0
             s1  &&  s2 sonuc
              1      1    1
              1      0    1
              0      1    1
              0      0    0


             */
            #endregion

        }
    }
}
