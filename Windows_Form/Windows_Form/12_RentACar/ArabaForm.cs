using _12_RentACar.Data;
using _12_RentACar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_RentACar
{
    public partial class ArabaForm : Form
    {
        DataContext _context;
        Araba _kiralikAraba;
        Musteri _musteri;
        DateTime finisDate;
        DateTime startDate;

        public ArabaForm(Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            this._musteri = musteri;
            dtp_kTarih.MinDate = DateTime.Now;
            dtp_tTarih.MinDate = DateTime.Now;

        }

        private void ArabaForm_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            cmb_Listele.DataSource = _context.Markalar.ToList();
            cmb_Listele.DisplayMember = "Ad";
            cmb_Listele.ValueMember = "Id";
            cmb_Listele.SelectedIndex = -1;
            dtp_kTarih.Value = time;
            dtp_tTarih.Value = time.AddDays(1);
            dtp_kSaat.Value = time;
            dtp_tSaat.Value = time;

            YukleAktifAraclar();
        }
        private void YukleAktifAraclar()
        {
            var arabaList = _context.Arabalar.Where(a => a.Aktif)
                .Include(i => i.Marka)
                .Select(a => new
                {
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret,
                    Marka = a.Marka.Ad,
                    Aktif = a.Aktif
                }).ToList();
            dtg_arabalar.DataSource = arabaList;
        }

        private void btn_arabaGetir_Click(object sender, EventArgs e)
        {
            cmb_Listele.BackColor = Color.White;

            var arabaList = _context.Arabalar.Where(a => a.Aktif).AsQueryable();
            if (cmb_Listele.SelectedValue != null)
            {
                arabaList = arabaList.Where(i => i.MarkaId == (int)cmb_Listele.SelectedValue);
            }
            dtg_arabalar.DataSource = arabaList.Include(i => i.Marka)
                .Select(a => new
                {
                    Id = a.Id,
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret,
                    Marka = a.Marka.Ad,
                    Aktif = a.Aktif
                }).ToList();
        }

        private void dtg_arabalar_DoubleClick(object sender, EventArgs e)
        {
            int id = 0; //seçilen aracın id değerini tutacak.
            cmb_Listele.BackColor = Color.White;
            if (dtg_arabalar.SelectedRows.Count > 0)
            {
                try
                {
                    id = (int)dtg_arabalar.SelectedRows[0].Cells[0].Value; //seçilen aracın id sini alıyoruz.
                    _kiralikAraba = _context.Arabalar.Include(a => a.Marka).FirstOrDefault(a => a.Id == id); //seçilen aracı veritabanından çekiyoruz.
                    if (_kiralikAraba == null)
                    {
                        MessageBox.Show("Araba bulunamadı");
                        return;
                    }
                    txt_kAraba.Text = _kiralikAraba.Marka.Ad + " " + _kiralikAraba.Model;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Marka Seçin");
                    cmb_Listele.BackColor = Color.Red;
                    return;
                }
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            // 1. Kontrol: Araç seçilmiş mi?
            if (_kiralikAraba == null)
            {
                MessageBox.Show("Lütfen önce listeden bir araç seçiniz.");
                return;
            }

            // 2. Tarih ve Saati Birleştir
            DateTime baslangicTarihi = dtp_kTarih.Value.Date + dtp_kSaat.Value.TimeOfDay;
            DateTime teslimTarihi = dtp_tTarih.Value.Date + dtp_tSaat.Value.TimeOfDay;

            // 3. Tarih Kontrolü
            if (teslimTarihi <= baslangicTarihi)
            {
                MessageBox.Show("Teslim tarihi başlangıç tarihinden sonra olmalıdır.");
                return;
            }

            // 4. Saat Farkını Bul (TotalHours double döner)
            TimeSpan zamanFarki = teslimTarihi - baslangicTarihi;
            double toplamSaat = zamanFarki.TotalHours;

            // 5. Ücret Hesapla
            // Araba modelindeki SaatlikUcret 'double' olduğu için 'decimal'a çeviriyoruz (cast ediyoruz).
            decimal saatlikUcret = (decimal)_kiralikAraba.SaatlikUcret;

            // Toplam saati de işlem yapabilmek için decimal'a çeviriyoruz.
            decimal toplamTutar = (decimal)toplamSaat * saatlikUcret;

            // 6. Ekrana Yazdır
            txt_toplamSaat.Text = toplamSaat.ToString("N2"); // Örn: 1.50
            txt_toplamTutar.Text = toplamTutar.ToString("C2"); // Örn: ₺1,500.00
        }

        private void btn_kiralamalar_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralama = new KiralamaForm(_musteri);
            kiralama.Show();
            this.Hide();
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            try
            {
                if (_kiralikAraba == null)
                {
                    MessageBox.Show("Bir Araç Seçiniz!");
                    return;
                }
                DateTime baslangicTarihi = dtp_kTarih.Value.Date + dtp_kSaat.Value.TimeOfDay;
                DateTime teslimTarihi = dtp_tTarih.Value.Date + dtp_tSaat.Value.TimeOfDay;
                if (teslimTarihi <= baslangicTarihi)
                {
                    MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır");
                    return;
                }
                bool aracMusaitMi = _context.Kiralamalar
                    .Where(k => k.ArabaId == _kiralikAraba.Id)
                    .Where(k=> baslangicTarihi >= k.BaslangicTarihi && baslangicTarihi < k.BitisTarihi ||
                    (teslimTarihi > k.BaslangicTarihi && teslimTarihi <= k.BitisTarihi) || 
                    baslangicTarihi <= k.BaslangicTarihi && teslimTarihi >= k.BitisTarihi)
                    .Count() == 0;
                if (!aracMusaitMi)
                {
                    MessageBox.Show("Araç Müsaitliği bulunamadı");
                    return;
                }
                TimeSpan zamanFarki = teslimTarihi - baslangicTarihi;
                double toplamSaat = zamanFarki.TotalHours;
                double toplamTutar  = toplamSaat * _kiralikAraba.SaatlikUcret;
                Kiralama yeniKiralama = new Kiralama()
                {
                    MusteriId = _musteri.Id,
                    ArabaId = _kiralikAraba.Id,
                    BaslangicTarihi = baslangicTarihi,
                    BitisTarihi = teslimTarihi,
                    ToplamTutar = toplamTutar
                };
                _kiralikAraba.Aktif = false;
                _context.Kiralamalar.Add(yeniKiralama);
                _context.SaveChanges();
                MessageBox.Show("Kiralama Başarılı!");
                YukleAktifAraclar();
                txt_toplamTutar.Clear();
                txt_toplamSaat.Clear();
                txt_kAraba.Clear();
                _kiralikAraba = null;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
