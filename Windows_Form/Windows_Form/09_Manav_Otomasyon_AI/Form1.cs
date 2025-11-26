using _09_Manav_Otomasyon_AI.Business;
using _09_Manav_Otomasyon_AI.Models;

namespace _09_Manav_Otomasyon_AI
{
    public partial class Form1 : Form
    {
        private UrunYonetici urunYonetici;
        private SatisYonetici satisYonetici;
        private int? secilenUrunId;

        public Form1()
        {
            InitializeComponent();
            urunYonetici = new UrunYonetici();
            satisYonetici = new SatisYonetici(urunYonetici);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Kategori filtrelerini yükle
                KategorileriYukle();

                // Ürünleri listele
                UrunleriListele();

                // Satış ürünlerini yükle
                SatisUrunleriniYukle();

                // Raporları güncelle
                RaporlariGuncelle();

                // Varsayılan değerler
                if (cmbKategori.Items.Count > 0)
                    cmbKategori.SelectedIndex = 0;

                if (cmbBirim.Items.Count > 0)
                    cmbBirim.SelectedIndex = 0;

                dtpSonKullanma.Value = DateTime.Now.AddDays(7);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Stok Yönetimi

        private void KategorileriYukle()
        {
            if (urunYonetici == null || cmbKategoriFiltre == null)
                return;

            try
            {
                var kategoriler = urunYonetici.KategorileriGetir();
                cmbKategoriFiltre.DataSource = kategoriler.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategori yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrunleriListele()
        {
            var urunler = urunYonetici.TumUrunleriGetir();
            dgvUrunler.DataSource = null;
            dgvUrunler.DataSource = urunler;

            UrunDataGridViewAyarla();
        }

        private void UrunDataGridViewAyarla()
        {
            // Kolon ayarları
            if (dgvUrunler == null || dgvUrunler.Columns.Count == 0)
                return;

            try
            {
                // Güvenli kolon kontrolü ve ayarları
                if (dgvUrunler.Columns["Id"] != null)
                {
                    dgvUrunler.Columns["Id"].HeaderText = "ID";
                    dgvUrunler.Columns["Id"].Width = 50;
                }

                if (dgvUrunler.Columns["Ad"] != null)
                    dgvUrunler.Columns["Ad"].HeaderText = "Ürün Adı";

                if (dgvUrunler.Columns["Kategori"] != null)
                    dgvUrunler.Columns["Kategori"].HeaderText = "Kategori";

                if (dgvUrunler.Columns["BirimFiyat"] != null)
                {
                    dgvUrunler.Columns["BirimFiyat"].HeaderText = "Birim Fiyat";
                    dgvUrunler.Columns["BirimFiyat"].DefaultCellStyle.Format = "C2";
                }

                if (dgvUrunler.Columns["StokMiktari"] != null)
                    dgvUrunler.Columns["StokMiktari"].HeaderText = "Stok Miktarı";

                if (dgvUrunler.Columns["Birim"] != null)
                {
                    dgvUrunler.Columns["Birim"].HeaderText = "Birim";
                    dgvUrunler.Columns["Birim"].Width = 70;
                }

                if (dgvUrunler.Columns["SonKullanmaTarihi"] != null)
                {
                    dgvUrunler.Columns["SonKullanmaTarihi"].HeaderText = "Son Kul. Tarihi";
                    dgvUrunler.Columns["SonKullanmaTarihi"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvUrunler.Columns["Tedarikci"] != null)
                    dgvUrunler.Columns["Tedarikci"].HeaderText = "Tedarikçi";

                // Duruma göre renklendirme
                foreach (DataGridViewRow row in dgvUrunler.Rows)
                {
                    var urun = row.DataBoundItem as Urun;
                    if (urun != null)
                    {
                        var durum = urun.DurumKontrol();
                        if (durum == "Süresi Dolmuş")
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                        else if (durum == "Acil Satılmalı")
                            row.DefaultCellStyle.BackColor = Color.LightSalmon;
                        else if (durum == "Dikkat")
                            row.DefaultCellStyle.BackColor = Color.LightYellow;

                        if (urun.StokMiktari <= 10)
                            row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DataGridView ayarlama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                var urun = dgvUrunler.SelectedRows[0].DataBoundItem as Urun;
                if (urun != null)
                {
                    secilenUrunId = urun.Id;
                    txtUrunAd.Text = urun.Ad;
                    cmbKategori.Text = urun.Kategori;
                    txtBirimFiyat.Text = urun.BirimFiyat.ToString();
                    txtStokMiktar.Text = urun.StokMiktari.ToString();
                    cmbBirim.Text = urun.Birim;
                    dtpSonKullanma.Value = urun.SonKullanmaTarihi;
                    txtTedarikci.Text = urun.Tedarikci;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!FormDogrula())
                return;

            bool basarili = urunYonetici.UrunEkle(
    txtUrunAd.Text,
 cmbKategori.Text,
     decimal.Parse(txtBirimFiyat.Text),
  double.Parse(txtStokMiktar.Text),
       cmbBirim.Text,
       dtpSonKullanma.Value,
       txtTedarikci.Text
        );

            if (basarili)
            {
                MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunleriListele();
                SatisUrunleriniYukle();
                KategorileriYukle();
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Ürün eklenirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenUrunId == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!FormDogrula())
                return;

            bool basarili = urunYonetici.UrunGuncelle(
             secilenUrunId.Value,
                   txtUrunAd.Text,
                cmbKategori.Text,
               decimal.Parse(txtBirimFiyat.Text),
                double.Parse(txtStokMiktar.Text),
            cmbBirim.Text,
                  dtpSonKullanma.Value,
        txtTedarikci.Text
              );

            if (basarili)
            {
                MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunleriListele();
                SatisUrunleriniYukle();
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Ürün güncellenirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenUrunId == null)
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onay",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool basarili = urunYonetici.UrunSil(secilenUrunId.Value);

                if (basarili)
                {
                    MessageBox.Show("Ürün başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UrunleriListele();
                    SatisUrunleriniYukle();
                    KategorileriYukle();
                    FormuTemizle();
                }
                else
                {
                    MessageBox.Show("Ürün silinirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void cmbKategoriFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Null kontrolleri
            if (cmbKategoriFiltre == null || urunYonetici == null)
                return;

            var kategori = cmbKategoriFiltre.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(kategori))
            {
                try
                {
                    var urunler = urunYonetici.KategoriyeGoreFiltrele(kategori);
                    dgvUrunler.DataSource = null;
                    dgvUrunler.DataSource = urunler;

                    // Kolon ayarlarını yeniden uygula
                    UrunDataGridViewAyarla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Filtreleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (urunYonetici == null)
                return;

            try
            {
                var aramaMetni = txtArama.Text;
                var urunler = urunYonetici.UrunAra(aramaMetni);
                dgvUrunler.DataSource = null;
                dgvUrunler.DataSource = urunler;

                // Kolon ayarlarını yeniden uygula
                UrunDataGridViewAyarla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FormDogrula()
        {
            if (string.IsNullOrWhiteSpace(txtUrunAd.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtBirimFiyat.Text, out _))
            {
                MessageBox.Show("Geçerli bir birim fiyat girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtStokMiktar.Text, out _))
            {
                MessageBox.Show("Geçerli bir stok miktarı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbBirim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen birim seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTedarikci.Text))
            {
                MessageBox.Show("Tedarikçi adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void FormuTemizle()
        {
            secilenUrunId = null;
            txtUrunAd.Clear();
            cmbKategori.SelectedIndex = 0;
            txtBirimFiyat.Clear();
            txtStokMiktar.Clear();
            cmbBirim.SelectedIndex = 0;
            dtpSonKullanma.Value = DateTime.Now.AddDays(7);
            txtTedarikci.Clear();
            dgvUrunler.ClearSelection();
        }

        #endregion

        #region Satış İşlemleri

        private void SatisUrunleriniYukle()
        {
            if (urunYonetici == null || cmbSatisUrun == null)
                return;

            try
            {
                var urunler = urunYonetici.TumUrunleriGetir();
                cmbSatisUrun.DataSource = null;
                cmbSatisUrun.DataSource = urunler;
                cmbSatisUrun.DisplayMember = "Ad";
                cmbSatisUrun.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış ürünleri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSatisUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        private void txtSatisMiktar_TextChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        private void ToplamTutarHesapla()
        {
            if (cmbSatisUrun.SelectedItem != null && double.TryParse(txtSatisMiktar.Text, out double miktar))
            {
                var urun = cmbSatisUrun.SelectedItem as Urun;
                if (urun != null)
                {
                    decimal toplam = (decimal)miktar * urun.BirimFiyat;
                    lblToplamTutar.Text = toplam.ToString("C2");
                }
            }
            else
            {
                lblToplamTutar.Text = "0,00₺";
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (cmbSatisUrun.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSatisMiktar.Text, out double miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir satış miktarı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var urun = cmbSatisUrun.SelectedItem as Urun;
            string musteriAd = string.IsNullOrWhiteSpace(txtMusteriAd.Text) ? "Müşteri" : txtMusteriAd.Text;

            var (basarili, mesaj) = satisYonetici.SatisYap(urun.Id, miktar, musteriAd);

            if (basarili)
            {
                MessageBox.Show(mesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunleriListele();
                SatislariListele();
                RaporlariGuncelle();

                // Satış formunu temizle
                txtSatisMiktar.Clear();
                txtMusteriAd.Clear();
                lblToplamTutar.Text = "0,00₺";
            }
            else
            {
                MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatislariListele()
        {
            if (satisYonetici == null || dgvSatislar == null)
                return;

            try
            {
                var satislar = satisYonetici.TumSatislariGetir();
                dgvSatislar.DataSource = null;
                dgvSatislar.DataSource = satislar;

                if (dgvSatislar.Columns.Count > 0)
                {
                    // Güvenli kolon kontrolü ve ayarları
                    if (dgvSatislar.Columns["Id"] != null)
                    {
                        dgvSatislar.Columns["Id"].HeaderText = "ID";
                        dgvSatislar.Columns["Id"].Width = 50;
                    }

                    if (dgvSatislar.Columns["UrunId"] != null)
                        dgvSatislar.Columns["UrunId"].Visible = false;

                    if (dgvSatislar.Columns["UrunAd"] != null)
                        dgvSatislar.Columns["UrunAd"].HeaderText = "Ürün";

                    if (dgvSatislar.Columns["SatilanMiktar"] != null)
                        dgvSatislar.Columns["SatilanMiktar"].HeaderText = "Miktar";

                    if (dgvSatislar.Columns["BirimFiyat"] != null)
                    {
                        dgvSatislar.Columns["BirimFiyat"].HeaderText = "Birim Fiyat";
                        dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Format = "C2";
                    }

                    if (dgvSatislar.Columns["ToplamTutar"] != null)
                    {
                        dgvSatislar.Columns["ToplamTutar"].HeaderText = "Toplam";
                        dgvSatislar.Columns["ToplamTutar"].DefaultCellStyle.Format = "C2";
                    }

                    if (dgvSatislar.Columns["SatisTarihi"] != null)
                    {
                        dgvSatislar.Columns["SatisTarihi"].HeaderText = "Tarih";
                        dgvSatislar.Columns["SatisTarihi"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }

                    if (dgvSatislar.Columns["MusteriAd"] != null)
                        dgvSatislar.Columns["MusteriAd"].HeaderText = "Müşteri";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış listesi güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Raporlar

        private void RaporlariGuncelle()
        {
            if (satisYonetici == null || urunYonetici == null)
                return;

            try
            {
                // Günlük rapor
                var gunlukRapor = satisYonetici.GunlukRapor();
                lblGunlukSatisSayisi.Text = gunlukRapor.adet.ToString();
                lblGunlukCiro.Text = gunlukRapor.toplam.ToString("C2");

                // Aylık rapor
                var aylikRapor = satisYonetici.AylikRapor();
                lblAylikSatisSayisi.Text = aylikRapor.adet.ToString();
                lblAylikCiro.Text = aylikRapor.toplam.ToString("C2");

                // Toplam stok değeri
                lblToplamStokDegeri.Text = urunYonetici.ToplamStokDegeri().ToString("C2");

                // Kritik stok uyarıları
                var kritikStoklar = urunYonetici.KritikStokUrunler();
                dgvKritikStok.DataSource = null;
                dgvKritikStok.DataSource = kritikStoklar;

                // Son kullanma tarihi yaklaşanlar
                var sonKullanmaYaklasan = urunYonetici.SonKullanmaTarihiYaklasanlar();
                dgvSonKullanma.DataSource = null;
                dgvSonKullanma.DataSource = sonKullanmaYaklasan;

                // En çok satanlar
                var enCokSatanlar = satisYonetici.EnCokSatanUrunler();

                // Sadece satış varsa listeyi oluştur
                if (enCokSatanlar != null && enCokSatanlar.Count > 0)
                {
                    var enCokSatanlarListe = enCokSatanlar.Select(x => new
                    {
                        UrunAdi = x.urunAd,
                        ToplamMiktar = x.toplamMiktar,
                        ToplamTutar = x.toplamTutar
                    }).ToList();

                    dgvEnCokSatan.DataSource = null;
                    dgvEnCokSatan.DataSource = enCokSatanlarListe;

                    if (dgvEnCokSatan.Columns.Count > 0)
                    {
                        // Güvenli kolon kontrolü
                        if (dgvEnCokSatan.Columns["UrunAdi"] != null)
                            dgvEnCokSatan.Columns["UrunAdi"].HeaderText = "Ürün Adı";

                        if (dgvEnCokSatan.Columns["ToplamMiktar"] != null)
                            dgvEnCokSatan.Columns["ToplamMiktar"].HeaderText = "Toplam Miktar";

                        if (dgvEnCokSatan.Columns["ToplamTutar"] != null)
                        {
                            dgvEnCokSatan.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";
                            dgvEnCokSatan.Columns["ToplamTutar"].DefaultCellStyle.Format = "C2";
                        }
                    }
                }
                else
                {
                    // Satış yoksa boş liste göster
                    dgvEnCokSatan.DataSource = null;
                }

                // Satış geçmişini güncelle - sadece satış varsa
                var tumSatislar = satisYonetici.TumSatislariGetir();
                if (tumSatislar != null && tumSatislar.Count > 0)
                {
                    SatislariListele();
                }
                else
                {
                    // Satış yoksa DataGridView'i temizle
                    if (dgvSatislar != null)
                    {
                        dgvSatislar.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rapor güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
