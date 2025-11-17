namespace _28_methods_optional_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Optional Parameters eğer methoda bir değer gelmiyorsa methodun o değer için kullanabileceği bir default değer ataması yapılır.
            
            Console.WriteLine(Yazdir("Furkan", "Uçan"));
            Console.WriteLine(Yazdir("Irmak"));

            Insan("Furkan",25,"2000");
        }

        static string Yazdir(string ad, string soyad = "Belirtilmedi")
        {
            return $"Ad: {ad} Soyad: {soyad}";
        }

        static void Insan(string adSoyad, int yas, string dogumYili, string meslek = "Serbest", string ülke = "Türkiye", string cinsiyet = "Belirtmek İstemiyor")
        {
            Console.WriteLine($"Adınız: {adSoyad} - Yaşınız: {yas} - Doğum Yılı: {dogumYili} - Meslek: {meslek} - Ülke: {ülke} - Cinsiyet: {cinsiyet}");
        }
    }
}
