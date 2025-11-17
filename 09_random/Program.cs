namespace _09_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayardan Rastgele sayılar üretmesini istiyoruz.
            Random zar = new Random(); //Random sınıfından bir nesne türetiyoruz. (instance)

            int rastgeleSayi = zar.Next(0,100);
            Console.WriteLine(rastgeleSayi);
        }
    }
}
