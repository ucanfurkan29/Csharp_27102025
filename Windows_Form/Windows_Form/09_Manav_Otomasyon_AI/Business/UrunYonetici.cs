using _09_Manav_Otomasyon_AI.Models;

namespace _09_Manav_Otomasyon_AI.Business
{
    /// <summary>
    /// Ürün yönetimi için iþ mantýðý sýnýfý
    /// </summary>
    public class UrunYonetici
    {
        private List<Urun> urunler;
        private int sonId;

        public UrunYonetici()
        {
            urunler = new List<Urun>();
            sonId = 0;
            OrnekVerileriYukle();
        }

        /// <summary>
        /// Örnek ürünleri yükler
        /// </summary>
        private void OrnekVerileriYukle()
        {
            UrunEkle("Domates", "Sebze", 45.50m, 50, "KG", DateTime.Now.AddDays(5), "Antalya Seracýlýk");
            UrunEkle("Salatalýk", "Sebze", 35.00m, 30, "KG", DateTime.Now.AddDays(4), "Antalya Seracýlýk");
            UrunEkle("Elma", "Meyve", 55.00m, 40, "KG", DateTime.Now.AddDays(10), "Isparta Meyvecilik");
            UrunEkle("Portakal", "Meyve", 40.00m, 60, "KG", DateTime.Now.AddDays(8), "Mersin Narenciye");
            UrunEkle("Muz", "Meyve", 75.00m, 25, "KG", DateTime.Now.AddDays(3), "Alanya Muzculuk");
            UrunEkle("Patates", "Sebze", 28.00m, 100, "KG", DateTime.Now.AddDays(20), "Niðde Patates");
            UrunEkle("Soðan", "Sebze", 22.00m, 80, "KG", DateTime.Now.AddDays(30), "Niðde Patates");
            UrunEkle("Biber", "Sebze", 65.00m, 20, "KG", DateTime.Now.AddDays(6), "Antalya Seracýlýk");
        }

        /// <summary>
        /// Yeni ürün ekler
        /// </summary>
        public bool UrunEkle(string ad, string kategori, decimal birimFiyat, double stokMiktari, string birim, DateTime sonKullanmaTarihi, string tedarikci)
        {
            try
            {
                sonId++;
                var yeniUrun = new Urun(sonId, ad, kategori, birimFiyat, stokMiktari, birim, sonKullanmaTarihi, tedarikci);
                urunler.Add(yeniUrun);
                return true;
            }
            catch
            {
                sonId--;
                return false;
            }
        }

        /// <summary>
        /// Ürünü günceller
        /// </summary>
        public bool UrunGuncelle(int id, string ad, string kategori, decimal birimFiyat, double stokMiktari, string birim, DateTime sonKullanmaTarihi, string tedarikci)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == id);
            if (urun == null) return false;

            urun.Ad = ad;
            urun.Kategori = kategori;
            urun.BirimFiyat = birimFiyat;
            urun.StokMiktari = stokMiktari;
            urun.Birim = birim;
            urun.SonKullanmaTarihi = sonKullanmaTarihi;
            urun.Tedarikci = tedarikci;
            return true;
        }

        /// <summary>
        /// Ürünü siler
        /// </summary>
        public bool UrunSil(int id)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == id);
            if (urun == null) return false;

            urunler.Remove(urun);
            return true;
        }

        /// <summary>
        /// Tüm ürünleri getirir
        /// </summary>
        public List<Urun> TumUrunleriGetir()
        {
            return urunler.ToList();
        }

        /// <summary>
        /// ID'ye göre ürün getirir
        /// </summary>
        public Urun UrunGetir(int id)
        {
            return urunler.FirstOrDefault(u => u.Id == id);
        }

        /// <summary>
        /// Kategoriye göre ürünleri filtreler
        /// </summary>
        public List<Urun> KategoriyeGoreFiltrele(string kategori)
        {
            if (string.IsNullOrEmpty(kategori) || kategori == "Tümü")
                return urunler.ToList();

            return urunler.Where(u => u.Kategori == kategori).ToList();
        }

        /// <summary>
        /// Stok miktarýný günceller
        /// </summary>
        public bool StokGuncelle(int id, double yeniMiktar)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == id);
            if (urun == null) return false;

            urun.StokMiktari = yeniMiktar;
            return true;
        }

        /// <summary>
        /// Kritik stok seviyesindeki ürünleri getirir
        /// </summary>
        public List<Urun> KritikStokUrunler(double esikDeger = 10)
        {
            return urunler.Where(u => u.StokMiktari <= esikDeger).ToList();
        }

        /// <summary>
        /// Son kullanma tarihi yaklaþan ürünleri getirir
        /// </summary>
        public List<Urun> SonKullanmaTarihiYaklasanlar(int gun = 7)
        {
            var kontrolTarihi = DateTime.Now.AddDays(gun);
            return urunler.Where(u => u.SonKullanmaTarihi <= kontrolTarihi).ToList();
        }

        /// <summary>
        /// Tüm kategorileri getirir
        /// </summary>
        public List<string> KategorileriGetir()
        {
            var kategoriler = urunler.Select(u => u.Kategori).Distinct().ToList();
            kategoriler.Insert(0, "Tümü");
            return kategoriler;
        }

        /// <summary>
        /// Arama yapar
        /// </summary>
        public List<Urun> UrunAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return urunler.ToList();

            aramaMetni = aramaMetni.ToLower();
            return urunler.Where(u =>
              u.Ad.ToLower().Contains(aramaMetni) ||
              u.Kategori.ToLower().Contains(aramaMetni) ||
             u.Tedarikci.ToLower().Contains(aramaMetni)
                  ).ToList();
        }

        /// <summary>
        /// Toplam stok deðerini hesaplar
        /// </summary>
        public decimal ToplamStokDegeri()
        {
            return urunler.Sum(u => u.ToplamDeger());
        }
    }
}
