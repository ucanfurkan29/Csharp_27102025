namespace _05_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //DateTime Veri Tipi
           DateTime zaman = DateTime.Now;
           Console.WriteLine(zaman);
           Console.WriteLine(zaman.Year);
           Console.WriteLine(zaman.Month);
           Console.WriteLine(zaman.Day);
           Console.WriteLine(zaman.Minute);
           Console.WriteLine(zaman.Second);
           Console.WriteLine(zaman.Hour);

            DateTime tarih = new DateTime(2025,09,12,15,22,55);
            Console.WriteLine(tarih);
        }
    }
}
