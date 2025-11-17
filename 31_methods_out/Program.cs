namespace _31_methods_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 0;
            //Topla(sayi,out int sayi2,out int sayi3);
            //Console.WriteLine($"{sayi}, {sayi2}, {sayi3}");

            int x, y;
            Hesapla(14,5,out x, out y);
            Console.WriteLine($"Toplam {x} - Fark {y}");
        }
        static void Topla(int sayi, out int sayi2,out int sayi3)
        {
            sayi = 10;
            sayi2 = 20;
            sayi3 = 30;
        }

        static void Hesapla(int a,int b, out int toplam, out int fark)
        {
            toplam = a + b;
            fark = a - b;
        }
    }
}
