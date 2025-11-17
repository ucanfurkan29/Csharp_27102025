namespace _02_degisken_veritipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değişkenler Ve Veri Tipleri
            // Değişken: programın çalışması sırasında değer tutmakla görevli isimlendirilmiş bellek alanları.
            // Veri Tipleri: Değişkenlerin tutabileceği değerlerin türünü belirtir.


            //Değişken tanımlama kuralı => degisken_tipi degisken_ismi = degisken_degeri

            string araba = "Furkan";
            int yas = 25;
            string soyad = "Uçan";

            araba = "Özgür"; //Değişken değerini güncelleme işlemi yaptık
            soyad = "Özdemir";//Değişken değerini güncelleme işlemi yaptık

            string ad2 ="Şevval"; // yeni bir değişken tanımladık
            string soyad2 = "Özgenç"; // yeni bir değişken tanımladık
            
            Console.WriteLine("Adım: araba " + araba + soyad);
            Console.WriteLine("Yaşım: " + yas);            
            Console.WriteLine("Adım: " + ad2 + soyad2);

            Console.WriteLine($"Adım {araba} Soyadım {soyad} Yaşım {yas}"); //string interpolation. string içerisinde değişken yazdırma.

            //CHAR VERİ TİPİ
            // '' tek tırnaklar arasında tanımlanır.
            //tek bir karakter saklayabilir
            //ascii tabloda decimal karşılığını saklar.
            char tekHarf = 'F';
            Console.WriteLine(tekHarf + 5);


            //SAYISAL VERI TIPLERI
            //Tam Sayı Veri Tipi - INT
            int tamSayi = 10;
            int tamSayi2 = 2147483647;

            byte byteSayi = 255; // 0-255 aralığında değer tutabilir. (1 byte = 8 bit)
            long uzunSayi = 1234567890123456789; // Uzun tam sayıları tutar. (8 byte = 64 bit)
            short kisaSayi = 32767; // -32768 ile 32767 aralığında değer tutabilir. (2 byte = 16 bit)
            //Ondalıklı Sayılar
            float ondalikliSayi = 3.14f; // Ondalıklı sayıları tutar. (4 byte = 32 bit)
            double ondalikliSayi2 = 3.14; // Daha hassas ondalıklı sayıları tutar. (8 byte = 64 bit)
            decimal ondalikliSayi3 = 3.14m; // Finansal hesaplamalar için kullanılır. (16 byte = 128 bit)

            //MANTIKSAL VERI TIPLERI
            //true ya da false değer saklayabilen veri tipi
            bool dogruMu = true;
            bool dogruMu2 = false;

            int sayi2 = 30;
            bool sayiBuyukMu = sayi2 > 40;
            Console.WriteLine($"Sayi Büyük Mü? {sayiBuyukMu}");

            Console.WriteLine("Value type");
            Console.WriteLine($" int Max: {int.MaxValue} - int Min: {int.MinValue}");// $ işareti ile string interpolasyonu yapabiliriz.
            Console.WriteLine(" int Max: {int.MaxValue} - int Min: {int.MinValue}");
            Console.WriteLine($" byte Max: {byte.MaxValue} - byte Min: {byte.MinValue}");
            Console.WriteLine($" long Max: {long.MaxValue} - long Min: {long.MinValue}");
            Console.WriteLine($" short Max: {short.MaxValue} - short Min: {short.MinValue}");
            Console.WriteLine($" float Max: {float.MaxValue} - float Min: {float.MinValue}");
            Console.WriteLine($" double Max: {double.MaxValue} - double Min: {double.MinValue}");
            Console.WriteLine($" decimal Max: {decimal.MaxValue} - decimal Min: {decimal.MinValue}");

            //var veri tipi
            //var değer  tipi otomatik olarak tip belirlemesi yapar
            var isim = "Furkan";
            var yas2 = 25;
            var ondalik = 26.5f;

            //Const ifadesiyle sabit değerler tanımlayabiliriz. const olarak tanımlanan değişkenlerin daha sonradan değer güncellemesi yapılamaz
            const double PI = 3.14;
            //PI = 3.1424; 
            const string isim3 = "furkan";
            //isim3 = "Kaan";

            //DEGISKEN TANIMLAMA KURALLARI 
            // Türkçe karakter ve Özel karakterler kullanılmaz
            //Yanlış değişken tanımlamaları
            //int 1sayi = 10; 
            //int sayi-1 = 10;
            //int sayi 1 = 10;
            //int sayi$ = 10;

            //Tek kullanabileceğimiz özel karakter '_' alt çizgi
            int sayi_1 = 10;
            int _sayi1 = 10;

            /*
             Syntax:
                snake_case: degisken_adi;
                camelCase: degiskenAdi;
                PascalCase: DegiskenAdi;
                UPPER_CASE: DEGİSKEN_ADI;
                lower_case: degiskenadi;
            */


        }
    }
}
