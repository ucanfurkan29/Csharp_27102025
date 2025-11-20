namespace _64_OOP_polymorphism_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru: E-Ticaret Ürün KDV Hesaplama Sistemi

                Senaryo: Bir e-ticaret sitemiz var. Sitede Elektronik, Gıda ve Tekstil olmak üzere farklı kategorilerde ürünler satılıyor. Devlet her ürün grubu için farklı KDV oranı belirlemiştir.
                        Standart Ürünler: %18 KDV
                        Elektronik Ürünler: %25 KDV (ÖTV eklendiği için yüksek)
                        Gıda Ürünleri: %8 KDV (Temel ihtiyaç olduğu için düşük)

                Sizden Urun adında bir temel sınıf (base class) ve bu sınıftan türeyen alt sınıfları kullanarak dinamik bir fiyat hesaplama sistemi yazmanız isteniyor.

                Teknik İsterler:
                    Base Class (Urun):
                        Ad (string) ve HamFiyat (double) özellikleri olsun.
                        KdvHesapla() adında virtual bir metot olsun. Bu metot standart olarak ham fiyatın %18'ini hesaplayıp geriye döndürsün.

                    Sub Classes (Tureyen Sınıflar):
                        Elektronik: Urunden türesin. KdvHesapla metodunu override etsin ve ham fiyatın %25'ini hesaplasın.
                        Gida: Urunden türesin. KdvHesapla metodunu override etsin ve ham fiyatın %8'ini hesaplasın.

                    Main Metodu:
                        Birer tane Elektronik (Laptop), Gıda (Ekmek) ve Standart Ürün (Kitap vb.) oluşturun.
                        Ekrana ürünün adını, ham fiyatını, KDV tutarını ve KDV dahil toplam fiyatını yazdırın.
             */




            Elektronik laptop = new Elektronik();
            laptop.Ad = "Macbook";
            laptop.HamFiyat = 30000;

            Gida hamburger = new Gida();
            hamburger.Ad = "cheeseburger";
            hamburger.HamFiyat = 100;

            Urun kitap = new Urun();
            kitap.Ad = "C# Programming";
            kitap.HamFiyat = 150;

            Urun[] urunler = { laptop, hamburger, kitap };
            foreach (var urun in urunler)
            {
                double kdvTutar = urun.KdvHesapla();
                double toplamFiyat = urun.HamFiyat + kdvTutar;
                Console.WriteLine($"Ürün Adı: {urun.Ad}");
                Console.WriteLine($"Ham Fiyat: {urun.HamFiyat} TL");
                Console.WriteLine($"KDV Tutarı: {kdvTutar} TL");
                Console.WriteLine($"KDV Dahil Toplam Fiyat: {toplamFiyat} TL");
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }

    class Urun 
    { 
        public string Ad { get; set; }
        public double HamFiyat { get; set; }

        public virtual double KdvHesapla()
        {
            return HamFiyat * 0.18;
        }
    }
    class Elektronik : Urun
    {
        public override double KdvHesapla()
        {
            return HamFiyat * 0.25;
        }
    }

    class Gida : Urun
    {
        public override double KdvHesapla()
        {
            return HamFiyat * 0.08;
        }
    }
}
