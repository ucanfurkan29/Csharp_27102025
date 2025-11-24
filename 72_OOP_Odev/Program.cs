namespace _72_OOP_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AkilliCihaz> cihazlar = new List<AkilliCihaz>();

            cihazlar.Add(new AkilliIsik("ISIK001", "Salon Işığı", "Salon") { Parlaklik = 150, AcikMi = true });
            cihazlar.Add(new AkilliKlima("KLIMA001", "Yatak Odası Kliması", "Yatak Odası") { Sicaklik = 18, Mod = "Soğutma", AcikMi = true });
            cihazlar.Add(new AkilliTV("TV001", "Salon TV", "Salon") { Ses = 30, AcikMi = false });

            Console.WriteLine("Akıllı Ev Sistemi");
            foreach (var cihaz in cihazlar)
            {
                cihaz.BilgiYazdir();
                cihaz.IslemYap();
                Console.WriteLine("-------------------------------");
            }
        }
    }
    public abstract class AkilliCihaz
    {
        public string SeriNo { get; set; }
        public string Ad { get; set; }
        public string OdaAdi { get; set; }
        public bool AcikMi { get; set; }

        public AkilliCihaz(string seriNo,string ad, string oda)
        {
            SeriNo = seriNo;
            Ad = ad;    
            OdaAdi = oda;
        }

        public virtual void BilgiYazdir()
        {
            string durum = AcikMi ? "Açık" : "Kapalı";
            Console.WriteLine($"Cihaz Adı: {Ad}, Seri No: {SeriNo}, Oda: {OdaAdi}, Durum: {durum}");
        }

        public abstract void IslemYap();
    }
    public class AkilliIsik : AkilliCihaz
    {
        private int _parlaklik;
        public int Parlaklik
        {
            get { return _parlaklik; }
            set
            {
                if (value < 0) _parlaklik = 0;
                else if (value > 100) _parlaklik = 100;
                else _parlaklik = value;
            }
        }
        public AkilliIsik(string seriNo, string ad, string oda) : base(seriNo, ad, oda)
        {
            Parlaklik = 50; // Varsayılan parlaklık seviyesi
        }

        public override void IslemYap()
        {
            if (!AcikMi)
            {
                Console.WriteLine("Işık Kapalı. Aydınlatma yapılmıyor.");
            }
            else
            {
                Console.WriteLine($"Işık %{Parlaklik} seviyesinde aydınlatma yapıyor.");
            }
        }
    }
    public class AkilliKlima : AkilliCihaz
    {
        private int _sicaklik;
        public string Mod { get; set; } // "Isıtma" veya "Soğutma"
        public int Sicaklik
        {
            get { return _sicaklik; }
            set
            {
                if (value < 16) _sicaklik = 16;
                else if (value > 30) _sicaklik = 30;
                else _sicaklik = value;
            }
        }
        public AkilliKlima(string seriNo, string ad, string oda) : base(seriNo, ad, oda)
        {
            Sicaklik = 22; // Varsayılan sıcaklık seviyesi
        }
        public override void IslemYap()
        {
            if (!AcikMi)
            {
                Console.WriteLine("Klima Kapalı. Isıtma/Soğutma yapılmıyor.");
            }
            else
            {
                Console.WriteLine($"Klima {Sicaklik}°C sıcaklıkta çalışıyor.");
            }
        }
    }

    public class AkilliTV : AkilliCihaz
    {
        private int _ses;
        public int Ses
        {
            get { return _ses; }
            set
            {
                if (value < 0) _ses = 0;
                else if (value > 50) _ses = 50;
                else _ses = value;
            }
        }
        public AkilliTV(string seriNo, string ad, string oda) : base(seriNo, ad, oda)
        {
            
        }
        public override void IslemYap()
        {
            if (!AcikMi)
            {
                Console.WriteLine("TV kapalı görüntü yok");
            }
            else
            {
                Console.WriteLine($"Tv izleniyor. ses seviyesi: {Ses}");
            }
        }
    }
}
