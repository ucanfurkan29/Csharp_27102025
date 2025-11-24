namespace _70_OOP_abstract_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* ÖDEV - 2
            Kurumsal Maaş Bordro Sistemi
               Senaryo: Büyük bir teknoloji şirketinin İnsan Kaynakları (HR) departmanı için yazılım geliştiriyorsun. Şirkette farklı statüde çalışanlar var ve ay sonunda herkesin maaşı farklı parametrelere göre hesaplanıyor.

               Patronun isteği şu: "Bana öyle bir sistem kur ki, tek bir tuşa bastığımda şirketteki Genel Müdür'den Stajyer'e kadar herkesin o ay ne kadar para alacağını hesaplayıp döküm versin."

               Teknik Gereksinimler (Kurallar):
               Base Class (Soyut Sınıf): Calisan adında bir sınıf oluştur.
               Özellikler: Ad, Soyad, Gorev (Hepsi için ortak).
               Metot 1 (Normal): BilgiGetir() -> Ekrana "Ad Soyad - Görev" yazsın. (Virtual olabilir, override edilebilir).
               Metot 2 (Abstract): MaasHesapla() -> Geriye double döndüren bir metot olsun. (Gövdesi olmayacak!).
               Sub Classes (Türeyen Sınıflar ve Kurallar):
               GenelMudur:
               Sabit maaşı: 80.000 TL.
               Ekstra özelliği: Bonus (double).
               Maaş Hesabı: Sabit Maaş + Bonus.
               Mudur:
               Sabit maaşı: 60.000 TL.
               Ekstra özelliği: Bonus (double).
               Maaş Hesabı: Sabit Maaş + Bonus.
               Yazilimci:
               Sabit maaşı: 40.000 TL.
               Ekstra özelliği: ProjeSayisi (int).
               Maaş Hesabı: Sabit Maaş + (Proje Başına 3.000 TL).
               Stajyer:
               Sabit maaşı: 10.000 TL.
               Ekstra özelliği: Yok.
               Maaş Hesabı: Sadece sabit maaş (Değişmez).
               Main (Test):
               Birer tane Genel Müdür, Müdür, Yazılımcı ve Stajyer nesnesi oluşturup özelliklerini (Ad, Bonus vb.) girin.
               Hepsini List<Calisan> içine atın.
               Bir döngü ile tek tek dönerek;
               Çalışanın bilgisini yazdırın.
               "Ödenecek Maaş: [Tutar] TL" şeklinde hesaplanan maaşı yazdırın.
               Bonus Görev: Döngünün sonunda "Şirketin bu ay ödeyeceği Toplam Maaş" tutarını yazdırın.

            */

            GenelMudur genelMudur = new GenelMudur() { Ad = "Ahmet", Soyad = "Yılmaz", Gorev = "Genel Müdür", Bonus = 15000 };
            Mudur mudur = new Mudur() { Ad = "Mehmet", Soyad = "Demir", Gorev = "Müdür", Bonus = 10000 };
            Yazilimci yazilimci = new Yazilimci() { Ad = "Ayşe", Soyad = "Kara", Gorev = "Yazılımcı", ProjeSayisi = 3 };
            Stajyer stajyer = new Stajyer() { Ad = "Fatma", Soyad = "Çelik", Gorev = "Stajyer" };

            List<Calisan> calisanlar = new List<Calisan>();

            calisanlar.Add(genelMudur);
            calisanlar.Add(mudur);
            calisanlar.Add(yazilimci);
            calisanlar.Add(stajyer);

            double toplamMaas = 0;

            Console.WriteLine("Aylık Maaş Tablosu");
            foreach (var calisan in calisanlar)
            {
                calisan.BilgiGetir();
                double maas = calisan.MaasHesapla();
                Console.WriteLine($"Ödenecek Maaş: {maas} TL");
                Console.WriteLine("-------------------------");
                toplamMaas += maas;
            }
            Console.WriteLine($"Şirketin bu ay ödeyeceği toplam maaş: {toplamMaas}");


        }
    }
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gorev { get; set; }
        public virtual void BilgiGetir()
        {
            Console.WriteLine($"{Ad} {Soyad} - {Gorev}");
        }
        public abstract double MaasHesapla();
    }

    public class GenelMudur : Calisan
    {
        public double Bonus { get; set; }
        private const double SabitMaas = 80000;
        public override double MaasHesapla()
        {
            return SabitMaas + Bonus;
        }
    }
    public class Mudur : Calisan
    {
        public double Bonus { get; set; }
        private const double SabitMaas = 60000;
        public override double MaasHesapla()
        {
            return SabitMaas + Bonus;
        }
    }
    public class Yazilimci : Calisan
    {
        public int ProjeSayisi { get; set; }
        private const double SabitMaas = 40000;
        public override double MaasHesapla()
        {
            return SabitMaas + (ProjeSayisi * 3000);
        }
    }
    public class Stajyer : Calisan
    {
        private const double SabitMaas = 10000;
        public override double MaasHesapla()
        {
            return SabitMaas;
        }
    }
}
