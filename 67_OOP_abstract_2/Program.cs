namespace _67_OOP_abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Elektronik diye bir sınıfımız olsun bu sınıfta alış fiyatı ve kar yüzdesi propertisi olacak
              * Ve method olarak FiyatHesapla Methodu olacak bu method zorunlu olacak.
              * abstract Sarjlı sınıfı olacak özelliği miliamper olsun
              * Elektirikli sınıfı olsun volt diye property si olsun 
              * Telefon Sarjlı dan miras alacak 
              * Buzdolabı sınıfı olacak.
              */


        }
    }
    public abstract class Elektronik
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYuzdesi { get; set; }
        public abstract decimal FiyatHesapla();
    }

    public abstract class  Sarjli:Elektronik
    {
        public abstract double MiliAmper { get; set; }
    }
    public abstract class Elektrikli
    {
        public abstract double Volt { get; set; }
    }
    public class Telefon : Sarjli
    {
        public override double MiliAmper { get; set; }
        public override decimal FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati * KarYuzdesi / 100);
        }
    }
    public class Laptop : Sarjli
    {
        public override double MiliAmper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
