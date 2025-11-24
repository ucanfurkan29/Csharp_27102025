namespace _03_ATM_Otomasyon
{
    public class Hesap
    {
        public int HesapNo { get; set; }
     public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public decimal Bakiye { get; set; }

        public Hesap(int hesapNo, string kullaniciAdi, string sifre, decimal baslangicBakiye)
        {
        HesapNo = hesapNo;
            KullaniciAdi = kullaniciAdi;
Sifre = sifre;
            Bakiye = baslangicBakiye;
     }
    }

    public static class HesapYonetimi
    {
        // Tüm hesaplar burada saklanýyor
      public static List<Hesap> Hesaplar { get; private set; }
        public static Hesap AktifHesap { get; set; }

  static HesapYonetimi()
 {
            // Baþlangýç hesaplarýný oluþtur
    Hesaplar = new List<Hesap>
            {
     new Hesap(1, "admin", "1234", 5000.00m),
         new Hesap(2, "furkan", "5678", 3000.00m)
          };
 }

        public static Hesap GirisYap(string kullaniciAdi, string sifre)
   {
 var hesap = Hesaplar.FirstOrDefault(h => 
  h.KullaniciAdi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase) && 
        h.Sifre == sifre);
        
            if (hesap != null)
        {
            AktifHesap = hesap;
            }
            
            return hesap;
        }

        public static Hesap HesapNoylaBul(int hesapNo)
 {
        return Hesaplar.FirstOrDefault(h => h.HesapNo == hesapNo);
        }

 public static bool ParaYatir(decimal tutar)
        {
        if (AktifHesap != null && tutar > 0)
            {
      AktifHesap.Bakiye += tutar;
    return true;
            }
return false;
   }

 public static bool ParaCek(decimal tutar)
   {
            if (AktifHesap != null && tutar > 0 && AktifHesap.Bakiye >= tutar)
{
      AktifHesap.Bakiye -= tutar;
         return true;
     }
            return false;
        }

        public static bool ParaGonder(int aliciHesapNo, decimal tutar)
        {
            if (AktifHesap == null || tutar <= 0 || AktifHesap.Bakiye < tutar)
                return false;

          var aliciHesap = HesapNoylaBul(aliciHesapNo);
         if (aliciHesap == null)
          return false;

// Gönderen hesaptan düþ
      AktifHesap.Bakiye -= tutar;
            // Alýcý hesaba ekle
         aliciHesap.Bakiye += tutar;

            return true;
}

     public static void CikisYap()
        {
  AktifHesap = null;
        }
    }
}
