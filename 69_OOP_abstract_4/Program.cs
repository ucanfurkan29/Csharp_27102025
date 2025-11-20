namespace _69_OOP_abstract_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Kare kare = new Kare();
            kare.Kenar = 5;
            Console.WriteLine("Karenin Alanı: " + kare.AlanHesapla());

            Daire daire = new Daire();
            daire.YariCap = 3;
            Console.WriteLine("Dairenin Alanı: " + daire.AlanHesapla());
        }
    }

    abstract class Sekil
    {
        public string Renk { get; set; }

        public abstract double AlanHesapla();

        public void BilgiYazdir()
        {
            Console.WriteLine("Bu bir şekildir.");
        }
    }
    class Kare : Sekil
    {
        public double Kenar { get; set; }
        public override double AlanHesapla()
        {
            return Kenar * Kenar;
        }
    }
    class Daire : Sekil
    {
        public double YariCap { get; set; }
        public override double AlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }
    }
}
