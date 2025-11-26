namespace _09_Manav_Otomasyon_AI.Models
{
    /// <summary>
    /// Satýþ iþlemlerini kaydeden model sýnýfý
    /// </summary>
    public class SatisKaydi
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public double SatilanMiktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime SatisTarihi { get; set; }
        public string MusteriAd { get; set; }

        public SatisKaydi()
        {
            SatisTarihi = DateTime.Now;
        }

        public SatisKaydi(int id, int urunId, string urunAd, double satilanMiktar, decimal birimFiyat, string musteriAd = "Müþteri")
        {
            Id = id;
            UrunId = urunId;
            UrunAd = urunAd;
            SatilanMiktar = satilanMiktar;
            BirimFiyat = birimFiyat;
            ToplamTutar = (decimal)satilanMiktar * birimFiyat;
            SatisTarihi = DateTime.Now;
            MusteriAd = musteriAd;
        }

        public override string ToString()
        {
            return $"{SatisTarihi:dd/MM/yyyy HH:mm} - {UrunAd} - {SatilanMiktar} - {ToplamTutar:C2}";
        }
    }
}
