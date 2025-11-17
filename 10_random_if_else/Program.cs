namespace _10_random_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sansliSayi = random.Next(0,10); //0 dahil, 10 dahil değil

        basla:
            Console.WriteLine("Şanslı sayıyı tahmin edin: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin == sansliSayi)
            {
                Console.WriteLine("Tebrikler Bildiniz -> " + sansliSayi);
            }
            else if (sansliSayi > tahmin)
            {
                Console.WriteLine("Daha büyük bir sayı girin");
                goto basla;
            }
            else if (tahmin > sansliSayi)
            {
                Console.WriteLine("Daha küçük bir sayı girin");
                goto basla;
            }

        }
    }
}
