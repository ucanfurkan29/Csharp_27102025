namespace _14_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Örnek Soru: Ulaşım Bileti Ücreti Hesaplama

                 Kullanıcıdan ulaşım türünü seçmesini isteyin:
                 1 → Otobüs
                 2 → Tren
                 3 → Uçak

                 Ardından kullanıcıdan mesafe (km) bilgisini alın.

                 Her ulaşım türü için kilometre başına ücret aşağıdaki gibidir:

                 Otobüs: 1.5 TL/km

                 Tren: 2.0 TL/km

                 Uçak: 5.0 TL/km

                 Seçilen ulaşım türüne göre toplam bilet ücretini hesaplayıp ekrana yazdırın.
                 Geçersiz seçim yapılırsa “Hatalı seçim!” mesajı verin.
             */

            //Console.WriteLine("=== Ulaşım Bileti Ücret Hesaplama ===");
            //Console.WriteLine("1-Otobüs");
            //Console.WriteLine("2-Tren");
            //Console.WriteLine("3-Uçak");
            //Console.Write("Ulaşım Türünü Seçin (1-3): ");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Mesafeyi Gir (KM): ");
            //double mesafe = Convert.ToDouble(Console.ReadLine());

            //switch (secim)
            //{
            //    case 1: Console.WriteLine($"Otobüs Bileti Ücreti: {mesafe * 1.5}TL"); break;
            //    case 2: Console.WriteLine($"Tren Bileti Ücreti: {mesafe * 2.0}TL"); break;
            //    case 3: Console.WriteLine($"Uçak Bileti Ücreti: {mesafe * 5.0}TL"); break;
            //    default: Console.WriteLine("Hatalı Seçim!");break;
            //}

            /*
             Örnek Soru: Restoran Sipariş Sistemi
                Kullanıcıya bir menü gösteriniz:
                    1 → Hamburger (120 TL)
                    2 → Pizza (150 TL)
                    3 → Salata (80 TL)
                    4 → İçecek (40 TL)

                -Kullanıcıdan bir seçim (1–4) ve ardından adet bilgisi alınız.
                -Seçilen ürüne ve adede göre toplam fiyatı hesaplayıp ekrana yazdırınız.
                -Eğer geçersiz bir seçim yapılırsa, “Geçersiz menü seçimi!” mesajı veriniz.
             */
            Console.WriteLine("===Sipariş hesaplama===");
            Console.WriteLine("1-hamburger");
            Console.WriteLine("2-pizza");
            Console.WriteLine("3-salata");
            Console.WriteLine("4-içecek");
            Console.WriteLine("siparişinizi seçiniz (1-4)");
            int siparis = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Adeti gir (TL)");
            double adet = Convert.ToDouble(Console.ReadLine());

            switch (siparis)
            {
                case 1: Console.WriteLine($"hamburgerin fiyatı:{adet * 120} TL"); break;
                case 2: Console.WriteLine($"pizzanın fiyatı:{adet * 150} TL"); break;
                case 3: Console.WriteLine($"salatanın fiyatı:{adet * 80} TL"); break;
                case 4: Console.WriteLine($"içeceğin fiyatı:{adet * 40} TL"); break;
                default: Console.WriteLine("Geçersiz menü seçimi!"); break;
            }




        }
    }
}
