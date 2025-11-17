using System.Numerics;

namespace _16_donguler_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü Tanım
            //döngüler belirli bir işi tekrar tekrar yaptırmak veya koleksiyon yapıları içerisinden sırayla verileri okumak için kullandığımı yapılardır.
            //Döngü yapıları => For döngüsü - While döngüsü - dowhile döngüsü - foreach döngüsü

            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");
            //Console.WriteLine("Furkan");

            /*
             for(veri_tipi degisken_adi = baslangic_degeri; koşul; artis veya azalis degeri;)
            {
                Döngüye girecek kod bloğu
            }
             */

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine($"{i} - Furkan Uçan");
            //}

            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Faktöriyel Hesaplama
            //ÖRNEK: Kullanıcıdan alınan bir sayının faktoriyelini hesaplama

            //ÇÖZÜM1:
            //Console.WriteLine("Faktoriyeli hesaplanacak sayıyı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine($"{sayi} sayısının faktoriyeli: {faktoriyel}");


            //ÇÖZÜM2:
            //Console.WriteLine("Faktoriyeli hesaplanacak sayıyı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;

            //for (int i = sayi; i >= 1; i--)
            //{
            //    Console.Write($"{faktoriyel} * {i} = ");
            //    faktoriyel = faktoriyel * i;
            //    Console.WriteLine(faktoriyel);
            //}
            #endregion

            #region İç içe For döngüsü
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int k = 0; k < 5; k++)
            //    {
            //        Console.WriteLine("K Döngüsü");
            //    }
            //    Console.WriteLine("I Döngüsü");
            //}

            //SORU: Çarpım Tablosunu For döngüsü ile yazın.
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine($"{i} TABLOSU");
            //    Console.WriteLine("-------------");
            //    for (int j = 0; j < 11; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i*j}");
            //    }
            //    Console.WriteLine("-------------");
            //}
            #endregion

            #region istediğimiz değer artışıyla for döngüsü

            //for (int i = 0; i < 11; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Sonsuz Döngü

            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine($"Sonsuz Döngü {i}");
            //}

            #endregion

            #region Break ve Continue Kullanımı
            //break döngüyü bitirmek ve scope dışına çıkmak için kullanılır.
            //continue da döngüdeki bir sonraki adıma geçirir. kodu alt satıra değil direkt for döngüsünün başına gönderir.

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        Console.WriteLine("Sayı 5'e ulaştı sayının değeri: " + i);
            //        continue;
            //    }
            //    if (i==7)
            //    {
            //        Console.WriteLine($"Sayı 7 değerine ulaştı: {i} - Döngü bitti");
            //        break;
            //    }
            //    Console.WriteLine($"Sayı:{i}");
            //}
            //Console.WriteLine("Döngü Bitti.");


            //SORU:9 a bölünen bir sayıya denk geldiğinde döngüyü bitir. döngü her adıma i değerini 1 artırısın. i 9 olduğunda 9a tam bölünür demesin continue desin.
            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine($"I Değeri: {i}");
            //    if (i == 9)
            //    {
            //        continue;
            //    }
            //    if (i % 9 == 0)
            //    {
            //        Console.WriteLine($"{i} sayısı 9'a tam bölünür. Döngü bitti.");
            //        break;
            //    }
            //}
            #endregion

            #region 1den 100e kadar olan tek sayıların ve çift sayıların toplamını hesaplayan döngüyü yazın. tekToplam, ciftToplam

            //int tekToplam = 0;
            //int ciftToplam = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam = ciftToplam + i;
            //    }
            //    else
            //    {
            //        tekToplam += i;
            //    }
            //}
            //Console.WriteLine($"Tek Sayıların Toplamı: {tekToplam}");
            //Console.WriteLine($"Çift Sayıların Toplamı: {ciftToplam}");
            #endregion

            #region SORU: 100 ila 1 arasında 3 e tam bölünen sayıları ekrana yazdıran döngüyü yazınız 100 den başlayarak 1 e kadar gelecek
            //int toplam = 0;
            //for (int i = 100; i >= 1; i--)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine($"3'e tam bölünen sayıların toplamı:{toplam}");
            #endregion
        }
    }
}
