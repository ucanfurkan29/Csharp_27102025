namespace _09_Manav_Otomasyon_AI.Models
{
    /// <summary>
    /// Manav ürünlerini temsil eden model sýnýfý
    /// </summary>
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public decimal BirimFiyat { get; set; }
        public double StokMiktari { get; set; } // KG veya Adet
        public string Birim { get; set; } // "KG", "Adet", "Litre"
        public DateTime SonKullanmaTarihi { get; set; }
        public string Tedarikci { get; set; }

        public Urun()
        {
        }

        public Urun(int id, string ad, string kategori, decimal birimFiyat, double stokMiktari, string birim, DateTime sonKullanmaTarihi, string tedarikci)
        {
            Id = id;
            Ad = ad;
            Kategori = kategori;
            BirimFiyat = birimFiyat;
            StokMiktari = stokMiktari;
            Birim = birim;
            SonKullanmaTarihi = sonKullanmaTarihi;
            Tedarikci = tedarikci;
        }

        /// <summary>
        /// Ürünün toplam deðerini hesaplar
        /// </summary>
        public decimal ToplamDeger()
        {
            return BirimFiyat * (decimal)StokMiktari;
        }

        /// <summary>
        /// Ürünün son kullanma tarihine göre durumunu kontrol eder
        /// </summary>
        public string DurumKontrol()
        {
            var kalanGun = (SonKullanmaTarihi - DateTime.Now).Days;

            if (kalanGun < 0)
                return "Süresi Dolmuþ";
            else if (kalanGun <= 3)
                return "Acil Satýlmalý";
            else if (kalanGun <= 7)
                return "Dikkat";
            else
                return "Uygun";
        }

        public override string ToString()
        {
            return $"{Ad} - {StokMiktari} {Birim} - {BirimFiyat:C2}/{Birim}";
        }
    }
}
