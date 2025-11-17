namespace _23_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dört İşlem
            //Kullanıcıdan 2 sayı alınacak ve yapmak istediği işlem sorulacak.
            //Örneğin toplama, çıkarma, çarpma, bölme
            //kullanıcının yapmak istediği işleme göre method çalışacak ve sonucu ekrana yazdıracak.

            //Console.WriteLine("1. sayıyı girin:");
            //double sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayıyı girin:");
            //double sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlemi seçin: +, -, *, /");
            //string islem = Console.ReadLine();

            //if (islem == "+")
            //{
            //    Topla(sayi1,sayi2);
            //}
            //else if (islem == "-")
            //{
            //    Cikar(sayi1, sayi2);
            //}
            //else if (islem == "*")
            //{
            //    Carp(sayi1, sayi2);
            //}
            //else if (islem == "/")
            //{
            //    Bol(sayi1, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz işlem seçimi.");
            //}

            //Yukarıdaki kodu tek bir method içinde toplayalım.
            //IslemYap();
            #endregion

            #region Indirim Hesaplama
            //Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan method
            //ve 3. ürünü almak isterse 3. ürünede %50 indirim uygulayacağız.
            Indırım();
            #endregion
        }

        #region Dört İşlem Methodları
        static void Topla(double a, double b)
        {
            Console.WriteLine($"Sonuç: {a + b}");
        }
        static void Cikar(double a, double b)
        {
            Console.WriteLine($"Sonuç: {a - b}");
        }
        static void Carp(double a, double b)
        {
            Console.WriteLine($"Sonuç: {a * b}");
        }
        static void Bol(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Sonuç: {a / b}");
            }
            else
            {
                Console.WriteLine("Hata: Bir sayı sıfıra bölünemez.");
            }
        }
        static void IslemYap()
        {
            Console.WriteLine("1. sayıyı girin:");
            double sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı girin:");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi seçin: +, -, *, /");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Topla(sayi1, sayi2);
            }
            else if (islem == "-")
            {
                Cikar(sayi1, sayi2);
            }
            else if (islem == "*")
            {
                Carp(sayi1, sayi2);
            }
            else if (islem == "/")
            {
                Bol(sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem seçimi.");
            }
        }
        #endregion

        #region Indirim Hesaplama Methodları
        static void Indırım()
        {
            Console.WriteLine("1.Ürünün Fiyatını gir:");
            double urun1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürünün Fiyatını gir:");
            double urun2 = Convert.ToDouble(Console.ReadLine());
            if (urun1 > urun2)
            {
                urun1 *= 0.7;
            }
            else
            {
                urun2 *= 0.7;
            }
            Console.WriteLine("3. Ürünü almak ister misin(E/H)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                UcuncuUrunIndirim(urun1,urun2);
            }
            else
            {
                Console.WriteLine($"Ödeme {urun1 + urun2}");
            }
        }
        static void UcuncuUrunIndirim(double f1, double f2)
        {
            Console.WriteLine("Üçüncü ürün");
            double f3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme {f1 + f2 + (f3 * 0.5)}");
        }
        #endregion

    }
}
