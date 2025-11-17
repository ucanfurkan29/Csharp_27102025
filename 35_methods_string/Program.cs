namespace _35_methods_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "C# Dersleri";
            string[] metinler = { "Merhaba", "Ben", "C#" };
            string ad = "Furkan";
            string soyad = "Uçan";
            string text = "        String Methodlar       ";

            Console.WriteLine($"String Uzunluğu: {metin.Length}");
            Console.WriteLine($"Büyük Harfe Çevir: {metin.ToUpper()}");
            Console.WriteLine($"Küçük Harfe Çevir: {metin.ToLower()}");
            bool buldum = metin.Contains("Java");
            Console.WriteLine($"Metin içinde C# geçiyor mu? {buldum}");

            string degistirilmisMetin = metin.Replace("C#","Java");
            Console.WriteLine($"Değiştirilmiş Metin: {degistirilmisMetin}");

            string adSoyad = String.Concat(ad + " " + soyad);
            Console.WriteLine($"Ad Soyad: {adSoyad}");

            Console.WriteLine($"Trim edilmiş değer: {text.Trim()}");
        }
    }
}
