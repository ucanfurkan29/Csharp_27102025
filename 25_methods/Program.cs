namespace _25_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çift sayıları ayrı ayrı dizilere atayan method
            DiziDoldur();
        }
        internal static void DiziDoldur()
        {
            int[] sayilar = new int[250];
            int[] tekSayilar = new int[0];
            int[] ciftSayilar = new int[0];

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = rnd.Next(1, 101);
                sayilar[i] = sayi;

                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftSayilar, 15);
                    ciftSayilar[ciftSayilar.Length - 1] = sayi;
                }
                else
                {
                    Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
                    tekSayilar[tekSayilar.Length - 1] = sayi;
                }
            }
            DiziYazdir(sayilar);
            DiziYazdir(tekSayilar);
            DiziYazdir(ciftSayilar);
        }

        internal static void DiziYazdir(int[] dizi)
        {

            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------");

        }
    }
}
