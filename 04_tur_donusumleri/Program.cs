namespace _04_tur_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden Veri Girişi Alma

            //Console.Write("Adınızı Girin: ");
            //string ad = Console.ReadLine(); //Console.ReadLine() Klavyeden veri almaya yarar. Girilen veriyi string olarak okur. Bu sebepten sayısal değer girilecekse tür dönüşümü yapılması gerekir.
            //Console.WriteLine($"Benim Adım {ad}!");

            //Console.Write("Yaşınızı Girin: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Benim Yaşım {yas}!");

            //SORU1: Kullanıcıdan 2 adet sayı girmesini isteyin. 2 sayıyı farklı değişkenlere kaydedip daha sonra consolda toplanmış halini ekrana yazdırın.

            //Console.WriteLine("Birinci Sayıyı Girin: ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci Sayıyı Girin: ");
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //int sonuc = s1 + s2;
            //Console.WriteLine($"Iki Sayının toplamı: {s1} + {s2} = {sonuc}");

            //SORU2: Kullanıcının Adını, Soyadını, Yaşını klavyeden girmesini isteyin. daha sonra bunları tek bir console.writeline içinde yazdırın.

            //Console.WriteLine("Adınızı Girin: ");
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyadınızı Girin: ");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Yaşınızı Girin: ");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Merhaba benim adım {ad} {soyad}, {yas} yaşındayım.");
            #endregion

            char deger = 'A';
            int s1 = (int)deger;
            Console.WriteLine(s1);

            float s2 = 5.5f;
            int s3 = (int)s2;
            Console.WriteLine(s3);

            char deger2 = Convert.ToChar(s3);
            Console.WriteLine(deger2);

            Console.WriteLine("Double değer girin: ");
            double s4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(s4);
        }
    }
}
