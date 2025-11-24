namespace _02_Ogrenci_Bilgi_Sistemi
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public string Bolum { get; set; }
        public DateTime DogumTarihi { get; set; }

        public Ogrenci(string ad, string soyad, string ogrenciNo, string bolum, DateTime dogumTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Bolum = bolum;
            DogumTarihi = dogumTarihi;
        }

        public override string ToString()
        {
            return $"{OgrenciNo} - {Ad} {Soyad} - {Bolum} - {DogumTarihi:dd.MM.yyyy}";
        }
    }
}
