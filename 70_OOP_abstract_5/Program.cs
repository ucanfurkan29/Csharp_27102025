namespace _70_OOP_abstract_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek: Bir tane Tasit sınıfı oluşturalım ancak bu sınıftan nesne üretilemesin.
            //İçerisinde Marka, Model, TabanFiyat property'leri  bir de türeyen her sınıfa
            //özel hesaplanacak abstract Fiyat property'si ekleyelim.
            //Tasit'dan türeyen Araba, Ucak, Tren ve Gemi class'larımız olsun.
            //Araba'ya özel fiyat hesabı YakitTuru, VitesTuru bilgilerine göre yapılsın
            //(Dizel'se +5000, Otomatikse'se +10000)
            //Uçak'a özel fiyat hesabı kapasite bilgisine göre yapılsın.
            //(Kapasite başına +100)
            //Trene özel fiyat hesabı vagon sayısı ve sınıf bilgisine göre yapılsın
            //(sınıf A ise + 5000, B ise +10000 vagon sayısı başına + 30000)
            //Gemi'ye özel fiyat hesabı kamara sayısına göre yapılsın
            //(kamara başına +40000)


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


            /*
             
             
             
             */
        }
    }
}
