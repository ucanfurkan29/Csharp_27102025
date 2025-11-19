namespace _60_OOP_partial_class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci diye partial sınıfımız olsun birinci sınıfta Ogrenci no bolum derslikno alanları olsun
            //bilgi adında partial string bolum parametreli bir gövdesiz method olsun
            //bilgi2 methodunda ogrenci no ad soyad tc kısımlarını ekrana yazsın 
            //ogrenci 2 nin içerisinde tc ad soyad kısımları olacak ve bu alanda da bilgi methodunun gövdeli hali olacak 
            //string parametre alan bir method olacak. ve bolum değeriini ekrana yazsın

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciNo = 123;
            ogrenci.Bolum = "Bilgisayar Mühendisliği";
            ogrenci.DerslikNo = 45;
            ogrenci.Tc = "12345678901";
            ogrenci.Ad = "Ahmet";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.Bilgi2();
        }
    }
}
