namespace _71_abstract_6
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
            
            Araba araba = new Araba("Toyota", "Corolla", 300000, "Otomatik", "Benzin");
            Console.WriteLine($"Taşıt: {araba.Marka}, Fiyat: {araba.Fiyat}");
            Tren tren = new Tren("TCDD", "Ankara-İstanbul", 500000, 10, "A");
            Console.WriteLine($"Taşıt: {tren.Marka}, Fiyat: {tren.Fiyat}");
            Ucak ucak = new Ucak("THY", "Boeing 737", 2000000, 180);
            Console.WriteLine($"Taşıt: {ucak.Marka}, Fiyat: {ucak.Fiyat}");
            Gemi gemi = new Gemi("MSC", "Fantasia", 10000000, 50);
            Console.WriteLine($"Taşıt: {gemi.Marka}, Fiyat: {gemi.Fiyat}");
        }
    }
}
