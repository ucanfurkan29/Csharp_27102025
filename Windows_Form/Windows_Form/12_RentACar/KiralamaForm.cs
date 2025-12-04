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
    public partial class KiralamaForm : Form
    {
        private readonly DataContext _db;
        private Musteri _musteri;
        private Kiralama _secilenKiralama;

        public KiralamaForm()
        {
            InitializeComponent();
            _db = new DataContext();
        }
        public KiralamaForm(Musteri musteri) : this() //yukarıdaki parametresiz constructor'ı da çağırır
        {
            this._musteri = musteri;
        }


        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            btn_kiralamaDuzenle.Enabled = false;
            btn_kiralamaSil.Enabled = false;
            KiralamalariYukle();
        }
        private void KiralamalariYukle()
        {
            try
            {
                var kiralamalar = _db.Kiralamalar
                    .Include(k => k.Araba)
                    .Include(k => k.Araba.Marka)
                    .Include(k => k.Musteri)
                    .AsQueryable();
                if (_musteri != null)
                {
                    kiralamalar = kiralamalar.Where(k => k.MusteriId == _musteri.Id);
                }
                var kiralamaListesi = kiralamalar.ToList();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Kiralama No", typeof(int));
                dataTable.Columns.Add("Başlangıç Tarihi", typeof(DateTime));
                dataTable.Columns.Add("Bitiş Tarihi", typeof(DateTime));
                dataTable.Columns.Add("Toplam Tutar (₺)", typeof(decimal));
                dataTable.Columns.Add("Araç Bilgisi", typeof(string));
                dataTable.Columns.Add("Müşteri Bilgisi", typeof(string));

                foreach (var kiralama in kiralamaListesi)
                {
                    string aracBilgisi = kiralama.Araba != null && kiralama.Araba.Marka != null ?
                        $"{kiralama.Araba.Model} " : "Bilinmiyor";
                    string musteriBilgisi = kiralama.Musteri != null ?
                        $"{kiralama.Musteri.AdSoyad} {kiralama.Musteri.Telefon}" : "Bilinmiyor";
                    dataTable.Rows.Add(
                        kiralama.Id,
                        kiralama.BaslangicTarihi,
                        kiralama.BitisTarihi,
                        kiralama.ToplamTutar,
                        aracBilgisi,
                        musteriBilgisi
                        );
                }
                dtg_kiralamalar.DataSource = dataTable;
                dtg_kiralamalar.Columns["Toplam Tutar (₺)"].DefaultCellStyle.Format = "C2";
                if (dtg_kiralamalar.Rows.Count > 0)
                {
                    dtg_kiralamalar.ClearSelection();
                }
                _secilenKiralama = null;
                btn_kiralamaDuzenle.Enabled = false;
                btn_kiralamaSil.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Yüklenecek Araba bilgisi bulunamadı: " + ex.Message);
            }
        }

        private void dtg_kiralamalar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtg_kiralamalar.SelectedRows.Count > 0)
                {
                    int kiralamaId = Convert.ToInt32(dtg_kiralamalar.SelectedRows[0].Cells["Kiralama No"].Value);
                    _secilenKiralama =
                        _db.Kiralamalar.Include(k => k.Araba)
                        .Include(k => k.Araba.Marka)
                        .Include(k => k.Musteri)
                        .FirstOrDefault(k => k.Id == kiralamaId);
                    Console.WriteLine($"Seçilen kiralama Id {kiralamaId}, bulunan: {_secilenKiralama != null} ");
                    btn_kiralamaSil.Enabled = _secilenKiralama != null;
                    btn_kiralamaDuzenle.Enabled = _secilenKiralama != null;
                }
                else
                {
                    _secilenKiralama = null;
                    btn_kiralamaDuzenle.Enabled = false;
                    btn_kiralamaSil.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Seçim Hatası {ex.Message}");
                _secilenKiralama = null;
                btn_kiralamaDuzenle.Enabled = false;
                btn_kiralamaSil.Enabled = false;
            }
        }

        private void btn_kiralamaSil_Click(object sender, EventArgs e)
        {
            if (_secilenKiralama == null)
            {
                MessageBox.Show("Lütfen Silinecek bir kiralama kaydı seçin");
                return;
            }
            DialogResult result = MessageBox.Show($"{_secilenKiralama.Id} numaralı kiralama kaydını silmek istediğinize emin misiniz ? ", "Kiralamayı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_secilenKiralama.Araba != null)
                    {
                        _secilenKiralama.Araba.Aktif = true;

                    }
                    _db.Kiralamalar.Remove(_secilenKiralama);
                    _db.SaveChanges();
                    MessageBox.Show("Kiralama Başarıyla Silindi");
                    KiralamalariYukle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Silme sırasında bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            ArabaForm arabaForm = new ArabaForm(_musteri);
            arabaForm.Show();
        }

        private void btn_kiralamaDuzenle_Click(object sender, EventArgs e)
        {
            if (_secilenKiralama == null)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kiralamayı seçiniz");
                return;
            }
            var guncelKiralama = _db.Kiralamalar
                .Include(k => k.Araba)
                .Include(k => k.Araba.Marka)
                .Include(k => k.Musteri)
                .FirstOrDefault(k => k.Id == _secilenKiralama.Id);
            if (guncelKiralama == null)
            {
                MessageBox.Show("Seçilen Kiralama Kaydı Artık Mevcut Değil");
                KiralamalariYukle();
                return;
            }
            KiralamaDuzenlemeForm duzenlemeForm = new KiralamaDuzenlemeForm(guncelKiralama, _musteri);
            this.Hide();
            if (duzenlemeForm.ShowDialog() == DialogResult.OK)
            {
                KiralamalariYukle();
            }
        }
    }
}
