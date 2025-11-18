namespace _55_OOP_inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Inheritance (Kalıtım/Miras Alma) Nedir?
                Inheritance, nesne yönelimli programlamada (OOP) bir sınıfın (class) diğer bir sınıftan özellikleri ve davranışları miras almasını sağlayan bir prensiptir.
                Bu yapıda Base Class özelliklerini Alt sınıflar (Derived class) devralır ve gerektiğinde bu özellikleri genişletebilir veya değiştirebilir.
                Fakat Base Class Alt Sınıfları Miras Almaz.
             */

            IK ik = new IK();
            ik.TC = 123456789;
            ik.Ad = "Ahmet";
            ik.Soyad = "Yılmaz";
            ik.Adres = "İstanbul";
            ik.Yas = 30;
            ik.PersonelSayisi = 25;
            ik.Yaz();
            ik.BilgiGetir();


        }
    }
}
