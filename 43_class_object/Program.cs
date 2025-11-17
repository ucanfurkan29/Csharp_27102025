namespace _43_class_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erişim Belirleyici ve static non-static kavramları
            /*Access Modifiers (Erişim Belirleyici)
             * Private=>Özel yapı bu yapı sadece bulunduğu sınıf içerisinde kullanılabileceği anlamına gelir diğer sınıflar bu yapıya erişemezler private olarak seçilen bir sınıf sadece kendi sınıfı içerisinde çağırılır yada kullanılır
               Eğer bir erişim belirleyici verilmez ise bir sınıfa o yapı varsayılan olarak Private olur.
             *Public=> Hiçbir kısıtlamaya tabi olmayan Solition içerisinde her yapıdan erişilebileceği anlamına gelir.
             *internal=> bu yapı sadece oluşturulan projedeki yapıların erişebileceği anlamına gelir diğer projeler erişemez kendi projesine özel bir erişim sağlar.
             *Protected=> inherit(kalıtım) yolu ile erişilir yapıdır bu yapı Anasınıf olarak belirtilir ve diğer sınıflar bu yapıdan miras alarak kullanırlar miras alınma yolu ile erişilebilinir.
             *Sealed=>Mühürlü yapı demek bir yapı Sealed keywordü ile işaretlenmiş ise bu sınıf miras alınmaya kapalıdır.

             */
            /* Static Nonstatic yapı
             * Static yapılar sınıf içerisinde program çalıştığında çalışan yapılardır bir defa çalışır işlemini yapar ve sonrasında daha çalışmazlar static sınıflar static yapıları içinde barındırır bir sınıf static ise içindeki yapılar da static olmalıdır.
             *Static yapılardan nesneleme(örneklem/instance) işlemi yapılamaz. 
             *Nonstatic yapılar ise bir değişken üzerinden sınıftaki yapılara erişmek için nesneleme örneklem instance dediğimiz kavramla 
             *sınıfın özelliklerini kullanır.
            
            */
            #endregion

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.OgretmenName = "Furkan";
            ogretmen.OgretmenSurName = "Uçan";
            ogretmen.Phone = 55555555;
            ogretmen.OgretmenNo = 123;

            ogretmen.OgretmenTest();

            Ogretmen ogretmen2 = new Ogretmen();
            ogretmen2.OgretmenName = "Erkan";
            ogretmen2.OgretmenSurName = "Türk";
            ogretmen2.Phone = 444444444;
            ogretmen2.OgretmenNo = 124;

            ogretmen2.OgretmenTest();

            //Ogrenci irmak = new Ogrenci();
            //irmak.OgrenciNo = 1234;
            //irmak.OgrenciAdi = "Irmak"; //private olduğu için bu sınıftaki property e erişemeyiz.

            Console.WriteLine();//static classda direkt class adıyla erişim sağlanır.
            //Console console = new Console(); //Static Class için nesne oluşturulamaz.
            Random random = new Random(); //non-static classlarda nesne oluşturmak gerekir.

            
        }
    }
}
