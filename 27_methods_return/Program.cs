namespace _27_methods_return
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Geriye değer döndüren methodlar iş yapan methodlardan farklı olarak yaptıkları işin sonucunu dışarıya çıkartırlar.

            //Topla();//Değer Döndürmeyen İş yapan bir method
            //int sonuc = ToplaDondur(); //değer döndüren method
            //Console.WriteLine(sonuc);

            //-------------------------ÖRNEK----------------------------
            //SORU:MetinDondur() adında bir method yazın. bu method ad ve soyad olarak 2 tane paremetre alsın. daha sonra return ifadesi $"merhaba {ad} {soyad}" değerini döndürsün ve bunu ekrana yazın.
            //Console.WriteLine(MetinDondur("Furkan", "Uçan")); 

            //-------------------------ÖRNEK----------------------------
            //double s1 = 14.6;
            //double s2 = 4.8;

            //Console.WriteLine(ParametreliDeger(s1, s2));
            //Console.WriteLine(ParametreliDeger(22.3, 43.7));

            //---------------------------ÖRNEK:-------------------------
            //Kullanıcıdan 2 adet sayı istenecek ve bu sayılar geriye değer döndüren methoda gönderilecek bu methoda giden sayılara kdv uygulanıp kdv uygulanmış miktar dışarıya çıkarılacak ve ekranda görünecek.
            //Console.WriteLine("1.sayıyı girin");
            //double sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı girin");
            //double sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("KDVLİ FİYAT: " + KdvUygula(sayi1,sayi2));

            //---------------------------ÖRNEK:-------------------------
            Console.WriteLine("Şuanki Hızını: ");
            int hiz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hızınızı artırmak istiyor musunuz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                Console.WriteLine($"Şuanki hızınız: {Hizlan(hiz)}");
            }
            else if (cevap == "H")
            {
                Console.WriteLine($"Şuanki hızınız: {Yavasla(hiz)}");
            }
            else
            {
                Console.WriteLine($"Şuanki hızınız: {hiz}");
            }
        }

        static void Topla()
        {
            Console.WriteLine("1.değeri gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.değeri gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam: " +(sayi+sayi2));
        }
        static int ToplaDondur()
        {
            Console.WriteLine("1.değeri gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.değeri gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            return sayi + sayi2;
        }

        static string MetinDondur(string ad, string soyad)
        {
            return $"Merhaba {ad} {soyad}";
        }

        static double ParametreliDeger(double sayi, double sayi2)
        {
            double carp = sayi * sayi2;

            return carp;
        }
        static double KdvUygula(double s1, double s2)
        {
            double kdvliFiyat = (s1 + s2) * 1.20;
            return kdvliFiyat;
        }

        static int Hizlan(int hiz)
        {
            return hiz + 10;
        }
        static int Yavasla(int hiz)
        {
            return hiz - 10;
        }

    }
}
