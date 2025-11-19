namespace _61_OOP_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Polymorphism (Çok Biçimlilik): Bir methodun farklı şekillerde davranabilmesidir.
                -Static Polymorphism (Derleme Zamanı Polimorfizmi): Method Overloading ile sağlanır.
                -Dynamic Polymorphism (Çalışma Zamanı Polimorfizmi): Inheritance ve Method Overriding ile sağlanır.

             
             
             
             */
            /*
             -Virtual (İzin Belgesi): Üst sınıfta tanımlanır ve alt sınıflarda override edilebilir.
                Anlamı: "ben kaydet diye bir method tanımlıyorum, istersen alt sınıflarda beğenmezlerse bunu değiştirebilirsin izin veriyorum"

             -Override (Geçersiz Kılma): Alt sınıfta üst sınıftaki virtual methodu değiştirmek için kullanılır.
                Anlamı: "ben üst sınıftaki kaydet methodunu kendi ihtiyaçlarıma göre değiştirmek istiyorum"

             -Base (Üst Sınıfın Referansı): Alt sınıfta üst sınıfın methodunu çağırmak için kullanılır.
                Anlamı: "Tamam ben üst sınıfın metodunu beğenmedim ama oradaki bazı işlemler lazım, onları kullanıp üzerine ekleme yapayım"
             */


            UniOgrenci uni = new UniOgrenci();
            uni.Kaydet();
            Console.WriteLine($"Ad: {uni.Ad}");
            Console.WriteLine($"Soyad: {uni.Soyad}");
            Console.WriteLine($"Yas: {uni.Yas}");
            Console.WriteLine($"Numara: {uni.Numara}");
            Console.WriteLine($"Vize: {uni.Vize}");
            Console.WriteLine($"Final: {uni.Final}");
            Console.WriteLine($"Bolum: {uni.Bolum}");
        }
    }
    class UniOgrenci : Ogrenci
    {
        public string Bolum { get; set; }
        public override void Kaydet()
        {
            base.Kaydet(); 
            Console.WriteLine("Bolum:");
            Bolum = Console.ReadLine();
        }
    }
    class Ogrenci : Insan
    {
        public int Numara { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public void NotAl()
        {
            Console.WriteLine("Vize");
            Vize = int.Parse(Console.ReadLine());
            Console.WriteLine("Final");
            Final = int.Parse(Console.ReadLine());
        }
        public void NotAl(int vize, int final) //overload method - Static Polymorphism
        { 
            Vize = vize;
            Final = final;
        }
        public override void Kaydet() // override method - Dynamic Polymorphism
        {
            base.Kaydet(); // base -> üst sınıfın referansı
            Console.WriteLine("Numara:");
            Numara = int.Parse(Console.ReadLine());
            NotAl();
        }
    }
    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public virtual void Kaydet()  // virtual method -> override edebilmek için izin belgesi
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("Yas:");
            Yas = int.Parse(Console.ReadLine());
        }
    }
}
