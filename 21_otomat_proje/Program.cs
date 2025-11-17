namespace _21_otomat_proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
                Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği
                ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
                satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
                var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
          */
            #region kaan otomat
            //string[] urunler = { "Kola", "Fanta", "Su", "Çay", "Kahve" };
            //double[] fiyatlar = { 60, 60, 15, 25, 35 };
            //double cüzdan = 0;

            //while (true)
            //{
            //    Console.WriteLine("=== ÜRÜN LİSTESİ ===");
            //    Console.WriteLine($"1.{urunler[0]} {fiyatlar[0]}TL ");
            //    Console.WriteLine($"2.{urunler[1]} {fiyatlar[1]}TL ");
            //    Console.WriteLine($"3.{urunler[2]} {fiyatlar[2]}TL ");
            //    Console.WriteLine($"4.{urunler[3]} {fiyatlar[3]}TL ");
            //    Console.WriteLine($"5.{urunler[4]} {fiyatlar[4]}TL ");
            //    Console.Write("Bir ürün seçiniz (1-5): ");
            //    int secim = Convert.ToInt32(Console.ReadLine());
            //    if (secim == 1)
            //    {
            //        Console.Write("Para yatırınız: ");
            //        double para = Convert.ToDouble(Console.ReadLine());
            //        cüzdan = para;

            //        while (cüzdan < fiyatlar[0])
            //        {
            //            Console.WriteLine("Paranız Yetersiz");
            //            Console.Write("Ek para giriniz: ");
            //            double ek = Convert.ToDouble(Console.ReadLine());
            //            cüzdan = cüzdan + ek;
            //        }
            //        ;
            //        if (cüzdan > fiyatlar[0])
            //        {
            //            Console.WriteLine($"Kola Satın Aldınız ,Para üstü {cüzdan - fiyatlar[0]}TL ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kola alındı! Afiyet olsun!");
            //        }
            //    }
            //    if (secim == 2)
            //    {
            //        Console.Write("Para yatırınız: ");
            //        double para = Convert.ToDouble(Console.ReadLine());
            //        cüzdan = para;

            //        while (cüzdan < fiyatlar[1])
            //        {
            //            Console.WriteLine("Paranız Yetersiz");
            //            Console.Write("Ek para giriniz: ");
            //            double ek = Convert.ToDouble(Console.ReadLine());
            //            cüzdan = cüzdan + ek;
            //        }
            //        ;
            //        if (cüzdan > fiyatlar[1])
            //        {
            //            Console.WriteLine($"Fanta Satın Aldınız ,Para üstü {cüzdan - fiyatlar[1]}TL ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Fanta satın alındı! Afiyet olsun!");
            //        }
            //    }
            //    if (secim == 3)
            //    {
            //        Console.Write("Para yatırınız: ");
            //        double para = Convert.ToDouble(Console.ReadLine());
            //        cüzdan = para;

            //        while (cüzdan < fiyatlar[2])
            //        {
            //            Console.WriteLine("Paranız Yetersiz");
            //            Console.Write("Ek para giriniz: ");
            //            double ek = Convert.ToDouble(Console.ReadLine());
            //            cüzdan = cüzdan + ek;
            //        }
            //        ;
            //        if (cüzdan > fiyatlar[2])
            //        {
            //            Console.WriteLine($"Su Satın Aldınız ,Para üstü {cüzdan - fiyatlar[2]}TL ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Su satın alındı! Afiyet olsun!");
            //        }
            //    }
            //    if (secim == 4)
            //    {
            //        Console.Write("Para yatırınız: ");
            //        double para = Convert.ToDouble(Console.ReadLine());
            //        cüzdan = para;

            //        while (cüzdan < fiyatlar[3])
            //        {
            //            Console.WriteLine("Paranız Yetersiz");
            //            Console.Write("Ek para giriniz: ");
            //            double ek = Convert.ToDouble(Console.ReadLine());
            //            cüzdan = cüzdan + ek;
            //        }
            //        ;
            //        if (cüzdan > fiyatlar[3])
            //        {
            //            Console.WriteLine($"Çay Satın Aldınız ,Para üstü {cüzdan - fiyatlar[3]}TL ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Çay satın alındı! Afiyet olsun!");
            //        }
            //    }
            //    if (secim == 5)
            //    {
            //        Console.Write("Para yatırınız: ");
            //        double para = Convert.ToDouble(Console.ReadLine());
            //        cüzdan = para;

            //        while (cüzdan < fiyatlar[4])
            //        {
            //            Console.WriteLine("Paranız Yetersiz");
            //            Console.Write("Ek para giriniz: ");
            //            double ek = Convert.ToDouble(Console.ReadLine());
            //            cüzdan = cüzdan + ek;
            //        }
            //        ;
            //        if (cüzdan > fiyatlar[4])
            //        {
            //            Console.WriteLine($"Kahve Satın Aldınız ,Para üstü {cüzdan - fiyatlar[4]}TL ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kahve satın alındı! Afiyet olsun!");
            //        }

            //    }
            //    Console.Write("\nBaşka bir isteğiniz var mı? (E/H): ");
            //    string cevap = Console.ReadLine().ToUpper();

            //    if (cevap == "H")
            //    {
            //        Console.WriteLine("Teşekkür ederiz, iyi günler!");
            //        break;
            //    }

            //}
            #endregion

            bool admin = false;
            string pass = "1234";
            string inputPass;
            int wrongAttempts = 0;
            bool locked = false;


            string[] products = { "kola", "fanta", "su", "çay", "kahve","ayran" };
            double[] price = { 60, 60, 20, 30, 50,30 };
            double balance = 0;

            while (true)
            {
                try
                {
                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"{i+1} - {products[i]} => {price[i]}TL");
                    }
                    Console.WriteLine("Ürün Numarasını Seçin(Admin:-1): ");
                    int productNo = Convert.ToInt32(Console.ReadLine());
                    if (productNo == -1)
                    {
                        Console.Clear();
                        if (!locked)
                        {
                            while (wrongAttempts < 3)
                            {
                                Console.WriteLine("Admin Şifresi Girin: ");
                                inputPass = Console.ReadLine();
                                if (inputPass == pass)
                                {
                                    admin = true;
                                    Console.WriteLine("Admin Girişi Başarılı.");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    wrongAttempts++;
                                    Console.WriteLine($"Yanlış şifre. Kalan hakkın{3 - wrongAttempts}");
                                }
                                if (wrongAttempts == 3)
                                {
                                    Console.WriteLine("3 kere yanlış giriş yapıldı hesap 5 saniye bloke");
                                    locked = true;
                                    Thread.Sleep(10000);
                                    locked = false;
                                    wrongAttempts = 0;
                                }
                            }
                            Console.Clear();
                        }
                        continue;
                    }
                    Console.WriteLine("Para Girişi Yapınız:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance >= price[productNo-1])
                    {
                        Console.WriteLine($"Ürünü Satın Aldınız.\nAfiyet Olsun\nPara Üstü: {balance - price[productNo-1]}");
                        Thread.Sleep(3000);
                        balance = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine($"Yetersiz Bakiye - Cüzdan:{balance} => Ürün:{price[productNo-1]} => Eksik Tutar:{price[productNo-1] - balance}");
                            Console.WriteLine("1-Para Ekle \n2-Para İade");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Para Ekle:");
                                balance += Convert.ToDouble(Console.ReadLine());
                                if (balance >= price[productNo-1])
                                {
                                    Console.WriteLine($"Ürünü Satın Aldınız.\nAfiyet Olsun\nPara Üstü: {balance - price[productNo-1]}");
                                    Thread.Sleep(3000);
                                    balance = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine($"İade Edilen Tutar: {balance}TL");
                                Thread.Sleep(3000);
                                balance = 0;
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz Seçim");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }


        }
    }
}
