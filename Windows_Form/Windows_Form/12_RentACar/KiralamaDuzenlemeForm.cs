using _12_RentACar.Data;
using _12_RentACar.Models;
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
    public partial class KiralamaDuzenlemeForm : Form
    {
        private readonly DataContext _context;
        private Kiralama _kiralama;
        private Musteri _musteri;
        public KiralamaDuzenlemeForm(Kiralama kiralama, Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            _kiralama = kiralama;
            _musteri = musteri;
        }

        private void KiralamaDuzenlemeForm_Load(object sender, EventArgs e)
        {
            txt_arac.Text = _kiralama.Araba.Marka.Ad + " " + _kiralama.Araba.Model;
            dtp_baslaTarih.Value = _kiralama.BaslangicTarihi.Date;
            dtp_baslaSaat.Value = _kiralama.BaslangicTarihi;
            dtp_bitisTarih.Value = _kiralama.BitisTarihi.Date;
            dtp_bitisSaat.Value = _kiralama.BitisTarihi;
        }

        private void HesaplaVeGoster()
        {
            DateTime baslangicTarihi = dtp_baslaTarih.Value + dtp_baslaSaat.Value.TimeOfDay;
            DateTime bitisTarihi = dtp_bitisTarih.Value + dtp_bitisSaat.Value.TimeOfDay;

            if (bitisTarihi <= baslangicTarihi)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır.");
                return;
            }
            TimeSpan fark = bitisTarihi - baslangicTarihi;
            double toplamSaat = fark.TotalHours;
            double saatlikUcret = _kiralama.Araba.SaatlikUcret;
            double toplamTutar = toplamSaat * saatlikUcret;
            txt_toplamSaat.Text = Math.Round(toplamSaat, 2).ToString();
            txt_toplamTutar.Text = toplamTutar.ToString("C2");

        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            HesaplaVeGoster();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            KiralamaForm kiralamaForm = new KiralamaForm(_musteri);
            kiralamaForm.Show();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtp_baslaTarih.Value + dtp_baslaSaat.Value.TimeOfDay;
                DateTime bitisTarihi = dtp_bitisTarih.Value + dtp_bitisSaat.Value.TimeOfDay;

                if (bitisTarihi <= baslangicTarihi)
                {
                    MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır.");
                    return;
                }
                TimeSpan fark = bitisTarihi - baslangicTarihi;
                double toplamSaat = fark.TotalHours;
                double saatlikUcret = _kiralama.Araba.SaatlikUcret;
                double toplamTutar = Math.Round(toplamSaat * saatlikUcret);


                _kiralama.BaslangicTarihi = baslangicTarihi;
                _kiralama.BitisTarihi = bitisTarihi;
                _kiralama.ToplamTutar = toplamTutar;


                _context.Update(_kiralama);
                int deger = _context.SaveChanges();
                MessageBox.Show("Kayıt Başarıyla güncellendi");

                if (deger > 0)
                {
                    this.Hide();
                    KiralamaForm kiralamaForm = new KiralamaForm(_musteri);
                    kiralamaForm.Show();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
