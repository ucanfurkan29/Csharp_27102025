namespace _66_OOP_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Abstract Class
             * abstract class'lar, base class olarak kullanılır ve doğrudan örneklenemezler(nesnelenemezler).
             * c# da bir class'ı abstract yapmak için class tanımının önüne abstract anahtar kelimesi eklenir.
             * abstract class'lar, abstract metotlar içerebilir. abstract metotlar, gövdesiz metotlardır ve türeyen sınıflar tarafından override edilmek zorundadır.
             abstract sınıflar alt sınıflar için bir şablon görevi görür ve ortak özellikler ile davranışları tanımlar. metotları kullanmayı zorunlu kılar.
            sadece metodlar değil, property'ler ve event'ler de abstract olarak tanımlanabilir.
             */

            //Insan insan = new Insan(); // Hata: abstract class'lar doğrudan örneklenemezler. bu yapı soyut bir yapıdır.
            //Insan ogrenci = new Ogrenci(); //evet bir insan var ama o insan bir öğrenci

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Create();
            ogrenci.Update();
            ogrenci.Delete();
        }
    }
    public abstract class Insan
    {
        public abstract long Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public void Find(int id)
        {
            Console.WriteLine(id);
        }
    }

    public class Ogrenci : Insan
    {
        public override long Tc { get; set; }
        public string DerslikSayisi { get; set; }
        public string Bolum { get; set; }

        public override void Create()
        {
            Console.WriteLine("Tc:");
            Tc = long.Parse(Console.ReadLine());
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("Derslik Sayisi:");
            DerslikSayisi = Console.ReadLine();
            Console.WriteLine("Bolum:");
            Bolum = Console.ReadLine();
            List();
        }

        public override void Delete()
        {
            Tc = 0;
            Bolum = "";
            DerslikSayisi = "";
            Ad = "";
            Soyad = "";
            Console.WriteLine("Öğrenci kaydı silindi.");
            List();
        }

        public override void List()
        {
            Console.WriteLine($"{Tc} - {Ad} - {Soyad} - {Bolum}");
        }

        public override void Update()
        {
            Create();
        }
    }


}
