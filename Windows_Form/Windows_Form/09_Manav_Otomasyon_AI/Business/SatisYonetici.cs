using _09_Manav_Otomasyon_AI.Models;

namespace _09_Manav_Otomasyon_AI.Business
{
    /// <summary>
    /// Satýþ iþlemleri için iþ mantýðý sýnýfý
    /// </summary>
    public class SatisYonetici
    {
        private List<SatisKaydi> satislar;
        private UrunYonetici urunYonetici;
        private int sonId;

        public SatisYonetici(UrunYonetici urunYonetici)
        {
            satislar = new List<SatisKaydi>();
            this.urunYonetici = urunYonetici;
            sonId = 0;
        }

        /// <summary>
        /// Yeni satýþ kaydý oluþturur ve stoktan düþer
        /// </summary>
        public (bool basarili, string mesaj) SatisYap(int urunId, double miktar, string musteriAd = "Müþteri")
        {
            var urun = urunYonetici.UrunGetir(urunId);

            if (urun == null)
                return (false, "Ürün bulunamadý!");

            if (urun.StokMiktari < miktar)
                return (false, $"Yetersiz stok! Mevcut: {urun.StokMiktari} {urun.Birim}");

            // Stoktan düþ
            urun.StokMiktari -= miktar;

            // Satýþ kaydý oluþtur
            sonId++;
            var satis = new SatisKaydi(sonId, urunId, urun.Ad, miktar, urun.BirimFiyat, musteriAd);
            satislar.Add(satis);

            return (true, $"Satýþ baþarýlý! Toplam: {satis.ToplamTutar:C2}");
        }

        /// <summary>
        /// Tüm satýþlarý getirir
        /// </summary>
        public List<SatisKaydi> TumSatislariGetir()
        {
            return satislar.OrderByDescending(s => s.SatisTarihi).ToList();
        }

        /// <summary>
        /// Belirli tarih aralýðýndaki satýþlarý getirir
        /// </summary>
        public List<SatisKaydi> TariheGoreSatislar(DateTime baslangic, DateTime bitis)
        {
            return satislar.Where(s => s.SatisTarihi >= baslangic && s.SatisTarihi <= bitis)
          .OrderByDescending(s => s.SatisTarihi)
          .ToList();
        }

        /// <summary>
        /// Günlük satýþ raporunu getirir
        /// </summary>
        public (int adet, decimal toplam) GunlukRapor()
        {
            var bugun = DateTime.Today;
            var gunlukSatislar = satislar.Where(s => s.SatisTarihi.Date == bugun).ToList();

            return (gunlukSatislar.Count, gunlukSatislar.Sum(s => s.ToplamTutar));
        }

        /// <summary>
        /// Aylýk satýþ raporunu getirir
        /// </summary>
        public (int adet, decimal toplam) AylikRapor()
        {
            var buAy = DateTime.Now;
            var aylikSatislar = satislar.Where(s =>
    s.SatisTarihi.Year == buAy.Year &&
   s.SatisTarihi.Month == buAy.Month).ToList();

            return (aylikSatislar.Count, aylikSatislar.Sum(s => s.ToplamTutar));
        }

        /// <summary>
        /// En çok satan ürünleri getirir
        /// </summary>
        public List<(string urunAd, double toplamMiktar, decimal toplamTutar)> EnCokSatanUrunler(int adet = 5)
        {
            return satislar.GroupBy(s => s.UrunAd)
             .Select(g => (
                   urunAd: g.Key,
       toplamMiktar: g.Sum(s => s.SatilanMiktar),
            toplamTutar: g.Sum(s => s.ToplamTutar)
                  ))
                       .OrderByDescending(x => x.toplamTutar)
           .Take(adet)
             .ToList();
        }

        /// <summary>
        /// Toplam satýþ gelirini hesaplar
        /// </summary>
        public decimal ToplamSatisGeliri()
        {
            return satislar.Sum(s => s.ToplamTutar);
        }
    }
}
