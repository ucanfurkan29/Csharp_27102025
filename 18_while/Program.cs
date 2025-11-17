namespace _18_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While döngüsü koşul true olduğu sürece çalışır.

            //Örnek1 Sonsuz Döngü

            //bool durum = true;
            //while (durum)
            //{
            //    Console.WriteLine(durum);
            //    Console.WriteLine("Devam etmek istiyor musun?");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "e")
            //    {
            //        durum = true;
            //    }
            //    else if (cevap == "h")
            //    {
            //        durum = false;
            //    }
            //}

            //Örnek2 

            //int sayac = 0;
            //while (sayac <= 10)
            //{
            //    sayac++;
            //    if (sayac == 5 || sayac == 6)
            //    {
            //        continue;
            //    }
            //    if (sayac == 9)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(sayac);
            //}

            //Örnek3

            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Başlangıç Değerini Girin: ");
            //    int basla = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bitiş Değerini Girin: ");
            //    int bitis = Convert.ToInt32(Console.ReadLine());

            //    for (int i = basla; i < bitis; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //    if (sum > 300)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(sum);


            //Örnek4

            //string userName = "furkan";
            //string password = "123";

            //int hak = 3;
            //while (hak > 0)
            //{
            //    Console.WriteLine("Kullanıcı adını gir:");
            //    string kad = Console.ReadLine();
            //    Console.WriteLine("şifre gir:");
            //    string pass = Console.ReadLine();

            //    hak--;
            //    if (kad == userName && pass == password)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız Kalmadı!");
            //        Console.WriteLine("Sistem Kitlendi!");
            //        Thread.Sleep(5000);
            //        Console.WriteLine("Sistem Açıldı!");
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //        hak = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Başarısız");
            //        Console.WriteLine("Tekrar Deneyin!");
            //    }
            //}


            /*1. Basit Sayı Yazdırma
                    Soru:
                    Kullanıcıdan bir sayı alın.
                    1’den başlayarak o sayıya kadar olan tüm sayıları while döngüsüyle ekrana yazdırın.*/

            //Çözüm1
            //Console.WriteLine("Bir Sayı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //while (i <= sayi)
            //{
            //    Console.Write(i + " - ");
            //    i++;
            //}

            /*2. Tek Sayıları Toplama
                    Soru:
                    Kullanıcı 0 girene kadar sayılar girmeye devam etsin.
                    Girilen tek sayıların toplamını hesaplayıp en sonunda ekrana yazdırın.*/

            //Çözüm2
            //int sayi;
            //int toplam = 0;

            //do
            //{
            //    Console.WriteLine("Bir sayı girin: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi % 2 != 0)
            //    {
            //        toplam += sayi;
            //    }
            //}
            //while (sayi != 0);
            //Console.WriteLine("Toplam: " + toplam);

            /*3. En küçük sayıyı bul
                    Soru:
                    Kullanıcı 0 girene kadar sayılar girsin.
                    Girilen sayılardan sadece en küçüğünü ekrana yazdırın.*/
            //Çözüm3

            //bool ilk = true;
            //int enKucuk = 0;

            //while (true)
            //{
            //    Console.WriteLine("Bir Sayı Girin: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0) break;

            //    if (ilk)
            //    {
            //        enKucuk = sayi;
            //        ilk = false;
            //    }
            //    else if (sayi < enKucuk)
            //    {
            //        enKucuk = sayi;
            //    }
            //}
            //if (ilk)
            //{
            //    Console.WriteLine("Hiç Sayı Girilmedi");
            //}
            //else
            //{
            //    Console.WriteLine("En Küçük Sayı: " + enKucuk);
            //}


            /*4. ATM menüsü (mini proje)
                    Soru:
                    Kullanıcıdan giriş yaptıktan sonra aşağıdaki menüyü gösterin:

                    1 - Bakiye Görüntüle  
                    2 - Para Yatır  
                    3 - Para Çek  
                    4 - Çıkış

                    Kullanıcı “4” diyene kadar menü dönsün.
                    Her işlem sonrası bakiye güncellensin.

                    İpucu: Menü döngüsü için while (true) kullanılabilir. Başlangıçta bakiye tanımlayabilirsiniz.*/

            //Çözüm4
            decimal bakiye = 1000m;

            while (true)
            {
                Console.WriteLine("\n--- ATM ---");
                Console.WriteLine("1 - Bakiye Görüntüle");
                Console.WriteLine("2 - Para Yatır");
                Console.WriteLine("3 - Para Çek");
                Console.WriteLine("4 - Çıkış");
                Console.Write("Seçim: ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine($"Bakiyeniz: {bakiye}");
                }
                else if (secim =="2")
                {
                    Console.WriteLine("Yatırılacak Tutar: ");
                    decimal yatirilacak = Convert.ToDecimal(Console.ReadLine());
                    if (yatirilacak > 0)
                    {
                        bakiye += yatirilacak;
                        Console.WriteLine($"{yatirilacak} TL Para yatırıldı");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz tutar");
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Çekilecek Tutar: ");
                    decimal cekilecek = Convert.ToDecimal(Console.ReadLine());
                    if(cekilecek <= 0)
                    {
                        Console.WriteLine("Geçersiz tutar");
                    }
                    else if (cekilecek > bakiye)
                    {
                        Console.WriteLine("Bakiye yetersiz. Bakiye: " + bakiye);
                    }
                    else
                    {
                        bakiye -= cekilecek;
                        Console.WriteLine($"{cekilecek} TL Para çekildi");
                    }
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Çıkış yapıldı.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız.");
                }
            }
        }
    }
}
