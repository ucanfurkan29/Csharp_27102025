namespace _26_methods_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             🧠 1. Ortalama ve Sınıf Durumu (değer döndüren + koşullu yapı)

                    Bir öğrencinin 3 yazılı notunu alan bir double Ortalama(double n1, double n2, double n3) metodu yazın.
                    Metot ortalamayı geri döndürsün.
                    Main içinde ortalama 50 ve üzeriyse "Geçtiniz", değilse "Kaldınız" yazsın.

                    🔸 Amaç: return, if, parametre, double kullanımı.

            🔢 2. Sayı Tahmin Oyunu (parametresiz, işlem yapan metotlar)

                    Bir program yazın:
                    void TahminOyunu() metodu 1–100 arasında rastgele bir sayı tutsun.
                    Kullanıcı doğru tahmini bulana kadar tahmin alsın.
                    Her yanlışta “daha büyük” veya “daha küçük” ipucu versin.
                    Bulduğunda "Tebrikler, X denemede bildiniz" yazsın.

                    🔸 Amaç: metot, Random, while, karşılaştırma, tekrar.

            🎲 3. Dizideki En Büyük ve En Küçük Sayı Farkı (dizi + Array.Resize pekiştirme)

                    int[] RastgeleDiziOlustur(int adet) → 1–100 arası rastgele sayılardan oluşan dizi döndürsün.
                    int EnBuyuk(int[] dizi) ve int EnKucuk(int[] dizi) metotlarıyla dizideki en büyük ve en küçük sayıyı bulup ekrana yazdırın.
                    Farkı hesaplayıp "Fark: ..." yazdırın.

                    🔸 Amaç: dizi işlemleri, metot parametreleri, return değerleri, Random kullanımı.
             */
            #region 1.Soru
            //Console.Write("1.Not: ");
            //double not1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("2.Not: ");
            //double not2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("3.Not: ");
            //double not3 = Convert.ToDouble(Console.ReadLine());

            //Ortalama(not1, not2, not3);
            #endregion

            #region 2.Soru
            //TahminOyunu();
            #endregion

            #region 3.Soru
            int[] rastgeleDizi = RastgeleDiziOlustur(30);

            int enBuyukSayi = EnBuyuk(rastgeleDizi);
            int enKucukSayi = EnKucuk(rastgeleDizi);

            Console.WriteLine($"Max: {enBuyukSayi}");
            Console.WriteLine($"Min: {enKucukSayi}");
            Console.WriteLine($"Fark: {enBuyukSayi - enKucukSayi}");

            #endregion


        }

        #region 1.Soru Method
        //static void Ortalama(double n1, double n2, double n3)
        //{
        //    double ort = (n1 + n2 + n3) / 3;
        //    if (ort >= 50)
        //    {
        //        Console.WriteLine("Tebrikler Geçtiniz. Ortalamanız: " + ort);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Kaldınız. Ortalamanız: " + ort);
        //    }
        //}
        #endregion

        #region 2.Soru Method
        //static void TahminOyunu()
        //{
        //    Random random = new Random();
        //    int hedef = random.Next(1,101);
        //    int deneme = 0;
        //    Console.WriteLine("1-100 Arasındaki Sayıyı Tahmin Et:");
        //    while (true)
        //    {
        //        Console.Write("Tahmin: ");
        //        int tahmin = Convert.ToInt32(Console.ReadLine());
        //        deneme++;
        //        if (tahmin == hedef)
        //        {
        //            Console.WriteLine($"Tebrikler! {deneme} denemede bildiniz!");
        //            break;
        //        }
        //        else if (tahmin > hedef)
        //        {
        //            Console.WriteLine("Daha küçük tahminde bulun.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Daha büyük tahminde bulun.");
        //        }
        //    }
        //}
        #endregion

        #region 3.Soru Method
        static int[] RastgeleDiziOlustur(int adet)
        {
            int[] sayilarDizi = new int[adet]; 
            Random random = new Random();
            for (int i = 0; i < adet; i++)
            {
                sayilarDizi[i] = random.Next(1,101);
            }
            return sayilarDizi;
        }
        static int EnBuyuk(int[] dizi)
        {
            int max = dizi[0];
            foreach (var item in dizi)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static int EnKucuk(int[] dizi)
        {
            int min = dizi[0];
            foreach (var item in dizi)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        #endregion
    }
}
