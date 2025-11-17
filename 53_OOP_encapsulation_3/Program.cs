namespace _53_OOP_encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Öğrenci diye bir sınıfımız olsun bu sınıfta Ad ve Yaş property leri olsun bu propertyler private olacak ve 
             * Kullanıcıdan alınan değerler kontrollü bir yapıda bu private proplara verilecek yani kapsülleme yapılacak 
             * Öğrencinin adı boş olamaz yada null bırakılamaz olacak ve Öğrencinin adı A ile Başlasın
             * Öğrencinin yaşı 18 yaşından küçük olmamalı 18 yaşından küçük değer gelirse hata gösterecek           
             */

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Furkan";
            ogrenci.Yas = 25;

        }
    }
}
