namespace _17_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do-While Döngüsü
             * do-while koşul başlangıçta false olsa bile do tarafı işlemi bir defa gerçekleştirir. koşul true ise false dönene kadar çalışmaya devam eder.
             */

            //int sayac = 1;
            //do
            //{
            //    Console.WriteLine("Sayac: " + sayac);
            //    sayac++;
            //}
            //while (sayac <= 10);

            //--------------------------------------------------------

            //int sayac2 = 1;
            //do
            //{
            //    Console.WriteLine("Sayac2: " + sayac2);
            //    sayac2++;
            //}
            //while (sayac2 >= 10);

            //--------------------------------------------------------

            //do
            //{
            //    Console.WriteLine("Do While Çalıştı");
            //}
            //while (false);

            //--------------------------------------------------------

            //Kullanıcı 0 girene kadar girilen sayıları toplayarak devam etsin kullanıcı 0 a bastığında  döngü sonlansın ve toplam değeri söylesin


            //int sayi = 0;
            //int toplam = 0;

            //do
            //{
            //    Console.WriteLine("Lütfen toplanacak sayı girin(çıkış için 0 girin): ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //}
            //while (sayi != 0);
            //Console.WriteLine("Toplam: " + toplam);


            //random sayı tahmin oyunu - bilgisayar rastgele bir sayı tutsun. kullanıcı bu sayıyı 5 hakta bilmeye çalışsın hakkı biterse bilemeden döngü sonlansın ve bilemedin desin. do-while ile yapın. daha küçük veya daha büyük sayı tahmin et diye bilgi versin.

            Random zar = new Random();
            int tutulanSayi = zar.Next(1,10);
            Console.WriteLine(tutulanSayi);
            int hak = 1;
            int girilenSayi = 0;
            do
            {
                Console.WriteLine($"{hak}. hakkınız. Lütfen Sayıyı tahmin edin: ");
                girilenSayi = Convert.ToInt32(Console.ReadLine());

                if (girilenSayi > tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }
                else if (girilenSayi < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else
                {
                    Console.WriteLine("Tebrikler Sayıyı Doğru Tahmin Ettiniz. Şanslı Sayı => " + tutulanSayi);
                    break;
                }
                if (hak == 5)
                {
                    Console.WriteLine("Hakkınız Doldu. Sayıyı Bilemediniz. Şanslı Sayı => " + tutulanSayi);
                }
                hak++;
            }
            while (hak <= 5 && girilenSayi != tutulanSayi);



        }
    }
}
