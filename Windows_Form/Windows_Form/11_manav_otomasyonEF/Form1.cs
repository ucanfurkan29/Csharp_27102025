using _11_manav_otomasyonEF.Data;
using _11_manav_otomasyonEF.Models;
using Microsoft.EntityFrameworkCore;

namespace _11_manav_otomasyonEF
{
    public partial class Form1 : Form
    {
        private readonly ManavContext _context = new ManavContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHalKategori.SelectedIndex = 0;
            cmbManavKategori.SelectedIndex = 0;
            GuncelleMusteriListesi();

        }
        private void cmbHalKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleHalUrunler();
        }
        private void cmbManavKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleManavUrunler();
        }
        private void GuncelleHalUrunler()
        {
            lstHalUrunler.Items.Clear();
            string seciliKategori = cmbHalKategori.SelectedItem.ToString();

            //Ef Core ve LINQ sorgusu ile veritabanýndan verileri çekme
            var urunler = _context.Urunler
                .Where(u => u.Kategori == seciliKategori)
                .OrderBy(u => u.UrunAdi)
                .ToList();
            foreach (var urun in urunler)
            {
                lstHalUrunler.Items.Add(urun.UrunAdi);
            }
        }
        private void GuncelleManavUrunler()
        {
            lstManavUrunler.Items.Clear();
            if (cmbManavKategori.SelectedItem == null) return;
            string seciliKategori = cmbManavKategori.SelectedItem.ToString();

            var manavdakiUrunler = _context.ManavStoklar
                .Include(stok => stok.Urun) //include ile navigation property yüklenir. ManavStok içindeki Urun bilgileri de getirilir
                .Where(stok => stok.Urun.Kategori == seciliKategori && stok.Kilo > 0)
                .OrderBy(stok => stok.Urun.UrunAdi)
                .ToList();

            foreach (var stok in manavdakiUrunler)
            {
                lstManavUrunler.Items.Add($"{stok.Urun.UrunAdi} - {stok.Kilo}KG");
            }
        }

        private void GuncelleMusteriListesi()
        {
            lstMusteri.Items.Clear();
            var satislar = _context.Satislar
                .OrderByDescending(s => s.SatisTarihi)
                .ToList();
            foreach (var satis in satislar)
            {
                lstMusteri.Items.Add($"Tarih: {satis.SatisTarihi:dd.MM.yyyy HH:mm:ss} - {satis.UrunAdi} - {satis.Kilo:F2}");
            }
        }

        private void btn_halEkle_Click(object sender, EventArgs e)
        {
            var yeniUrun = new Urun
            {
                UrunAdi = txt_urun.Text.ToUpper().Trim(),
                Kategori = cmbHalKategori.SelectedItem.ToString()
            };
            _context.Urunler.Add(yeniUrun); //yeni nesneyi DbContextde sýraya ekle
            _context.SaveChanges(); //deðiþiklikleri veritabanýna kaydet
            MessageBox.Show("Yeni ürün eklendi.");
            txt_urun.Clear();
            GuncelleHalUrunler();
        }

        private void btnHalEkle_Click(object sender, EventArgs e)
        {
            string secilenUrunAdi = lstHalUrunler.SelectedItem.ToString();
            decimal kilo = Convert.ToDecimal(txtHalKilo.Text);

            //Önce Urunler tablosundan bu ürünün nesnesini bul
            var urun = _context.Urunler.FirstOrDefault(u => u.UrunAdi == secilenUrunAdi);
            if (urun == null) return;

            var stok = _context.ManavStoklar.FirstOrDefault(s => s.UrunID == urun.UrunID);
            if (stok != null)
            {
                stok.Kilo += kilo;
                MessageBox.Show("Manav stok güncellendi.");

            }
            else
            {
                var yeniStok = new ManavStok
                {
                    UrunID = urun.UrunID,
                    Kilo = kilo
                };
                _context.ManavStoklar.Add(yeniStok);
                MessageBox.Show("Manav yeni stok eklendi.");

            }
            _context.SaveChanges();
            txtHalKilo.Clear();
            GuncelleManavUrunler();
        }

        private void btnManavSatis_Click(object sender, EventArgs e)
        {
            if (lstManavUrunler.SelectedItems == null)
            {
                MessageBox.Show("Lütfen satýlacak ürünü seçin");
                return;
            }
            if (!decimal.TryParse(txtManavKilo.Text, out decimal satilanKilo) || satilanKilo <= 0)
            {
                MessageBox.Show("geçerli bir kilo girin");
                return;

            }
            string secilenUrunAdi = lstManavUrunler.SelectedItem.ToString().Split('-')[0].Trim();
            var stok = _context.ManavStoklar.FirstOrDefault(u => u.Urun.UrunAdi == secilenUrunAdi); //ürün nesnesi
            if (stok == null)
            {
                MessageBox.Show("Ürün stokta bulunamadý");
                return;
            }
            if (satilanKilo > stok.Kilo)
            {
                MessageBox.Show("Yeterli stok yok.");
                return;
            }
            stok.Kilo -= satilanKilo;
            if (stok.Kilo == 0)
            {
                _context.ManavStoklar.Remove(stok);
            }

            var yeniSatis = new Satis
            {
                UrunAdi = secilenUrunAdi,
                Kilo = satilanKilo,
                SatisTarihi = DateTime.Now
            };
            _context.Satislar.Add(yeniSatis);
            _context.SaveChanges();
            MessageBox.Show("Satýþ gerçekleþtirildi.");
            txtManavKilo.Clear();
            GuncelleManavUrunler();
            GuncelleMusteriListesi();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStokSil_Click(object sender, EventArgs e)
        {
            if (lstManavUrunler.SelectedItems == null)
            {
                MessageBox.Show("Lütfen listeden silinecek stok ürününü seçiniz.", "Uyarý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string urunAdi = lstManavUrunler.SelectedItem.ToString().Split('-')[0].Trim();


            //silinecek stok kaydýný bulma
            var stok = _context.ManavStoklar
                .Include(s => s.Urun)
                .FirstOrDefault(s => s.Urun.UrunAdi == urunAdi);

            if (stok == null)
            {
                MessageBox.Show("Stok Kaydý bulunamadý", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dr = MessageBox.Show($"{urunAdi} isimli ürünün stok kaydýný silmek istediðinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes) return;

            _context.ManavStoklar.Remove(stok);
            _context.SaveChanges();
            MessageBox.Show("Stok kaydý silindi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            GuncelleManavUrunler();
        }

        private void btnHalSil_Click(object sender, EventArgs e)
        {
            if (lstHalUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek ürünü listeden seçiniz");
                return;
            }
            string urunAdi = lstHalUrunler.SelectedItem.ToString();
            var urun = _context.Urunler.FirstOrDefault(u => u.UrunAdi == urunAdi); // silinecek ürün nesnesi
            if (urun == null)
            {
                MessageBox.Show("Ürün bulunamadý.");
                return;
            }
            var ilgiliStok = _context.ManavStoklar.Where(s => s.UrunID == urun.UrunID).ToList();

            if (ilgiliStok.Any())
            {
                var toplamKilo = ilgiliStok.Sum(s => s.Kilo);
                var dr = MessageBox.Show($"{urunAdi} ürününden manavda {toplamKilo} KG bulunmaktadýr. Ürünü silerseniz stok bilgileri de silinecektir. Onaylýyor musunuz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;
                _context.ManavStoklar.RemoveRange(ilgiliStok);
            }

            _context.Urunler.Remove(urun);
            _context.SaveChanges();
            MessageBox.Show("Ürün ve ilgili stok bilgileri silindi.");
            GuncelleHalUrunler();
            GuncelleManavUrunler();
        }
    }
}
