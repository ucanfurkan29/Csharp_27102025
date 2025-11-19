namespace _62_OOP_polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Balik balik = new Balik();
            balik.HareketEt();
            Console.WriteLine("-----------------");

            Kus kus = new Kus();
            kus.HareketEt();
            Console.WriteLine("-----------------");

            Insan insan = new Insan();
            insan.HareketEt();
            Console.WriteLine("-----------------");

            Yilan yilan = new Yilan();
            yilan.HareketEt();
            Console.WriteLine("-----------------");

            Canli canli = new Canli();
            canli.HareketEt();
        }
    }
}
