namespace _54_encapsulation_4_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev Kapsülleme
            /*** Ödev ***
                Bir banka hesabını temsil eden bir uygulama geliştirmek istiyoruz. 
                Bu uygulamada, hesap bakiyesi gizli tutulmalı ve sadece belirli
                işlemlerle (para yatırma ve çekme) değiştirilebilmelidir.
                Kapsülleme (encapsulation) prensibini kullanarak bakiyeye 
                doğrudan erişimi engelleyeceğiz ve işlemler sırasında gerekli kontrolleri yapacağız.

               Kapsülleme (Encapsulation): Verileri dışarıya karşı korumak ve kontrollü 
                        erişim sağlamak için kapsülleme prensibini kullanın.
               Veri Doğrulama: Metotlar içinde girilen tutarların geçerli olup olmadığını kontrol edin.
               Metot İsimlendirme: Metot isimlerinin anlamlı ve eylem odaklı 
                olmasına dikkat edin (örneğin, Deposit, Withdraw).
               */
            #endregion

            BankAccount bankAccount1 = new BankAccount();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bankaya Hoşgeldiniz");
                Console.WriteLine("1- Para Çekme\n2-Güncel Bakiye\n3-Para Yatırma\n4-Kart İade");
                Console.Write("Giriş: ");
                string cevap = Console.ReadLine();
                if (cevap == "1")
                {
                    Console.Write("Çekmek istediğiniz tutarı girin: ");
                    double cekilecekTutar = Convert.ToDouble(Console.ReadLine());
                    bankAccount1.WithDraw(cekilecekTutar);
                    Thread.Sleep(2000);
                }
                else if (cevap == "2")
                {
                    Console.WriteLine($"Hesap Bakiyeniz {bankAccount1.Balance()}");
                    Thread.Sleep(2000);
                }
                else if (cevap == "3")
                {
                    Console.Write("Yatırmak istediğiniz tutarı girin: ");
                    double yatirilacakTutar = Convert.ToDouble(Console.ReadLine());
                    bankAccount1.Deposit(yatirilacakTutar);
                    Thread.Sleep(2000);
                }
                else if (cevap == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Yine Bekleriz...");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama");
                    Thread.Sleep(2000);
                    
                }
            }

        }
    }

    class BankAccount
    {
        private double _hesap = 2000;

        public double hesap 
        { 
            get { return _hesap; } 
            set 
            {
                if (value >= 0)
                {
                    _hesap += value;   
                }
                else
                {
                    Console.WriteLine("0dan küçük tutar verilemez");
                }
            } 
        }

        public void WithDraw(double tutar)
        {
            if (tutar >= 0 && tutar <= _hesap)
            {
                _hesap -= tutar;
                Console.WriteLine($"{tutar} TL para çekildi. Yeni hesap bakiyesi {_hesap}");
            }
            else
            {
                if (tutar < 0)
                {
                    Console.WriteLine("0dan küçük işlem yapamazsın");
                }
                else
                {
                    Console.WriteLine("Yetersiz Bakiye");
                }
            }
        }
        public void Deposit(double tutar)
        {
            if (tutar > 0)
            {
                _hesap += tutar;
                Console.WriteLine($"{tutar} TL para yatırıldı. Yeni hesap bakiyesi {_hesap}");
            }
            else
            {
                Console.WriteLine("0 veya negatif işlem yapılamaz.");
            }
        }
        public double Balance()
        {
            return _hesap;
        }

    }
}
