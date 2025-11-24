using System;
using System.Windows.Forms;

namespace _02_Ogrenci_Bilgi_Sistemi
{
    public partial class OgrenciListeleForm : Form
    {
        public OgrenciListeleForm()
        {
            InitializeComponent();
        }

        private void OgrenciListeleForm_Load(object sender, EventArgs e)
        {
            // DataGridView'i yapýlandýr
            dgvOgrenciler.AutoGenerateColumns = false;

            // Kolonlarý manuel olarak ekle
            dgvOgrenciler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Öðrenci No",
                DataPropertyName = "OgrenciNo",
                Name = "colOgrenciNo"
            });

            dgvOgrenciler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ad",
                DataPropertyName = "Ad",
                Name = "colAd"
            });

            dgvOgrenciler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Soyad",
                DataPropertyName = "Soyad",
                Name = "colSoyad"
            });

            dgvOgrenciler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Bölüm",
                DataPropertyName = "Bolum",
                Name = "colBolum"
            });

            dgvOgrenciler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Doðum Tarihi",
                DataPropertyName = "DogumTarihi",
                Name = "colDogumTarihi",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });

            // Veri kaynaðýný ayarla
            dgvOgrenciler.DataSource = null;
            dgvOgrenciler.DataSource = Form1.ogrenciListesi;

            // Eðer liste boþsa bilgi ver
            if (Form1.ogrenciListesi.Count == 0)
            {
                MessageBox.Show("Henüz kayýtlý öðrenci bulunmamaktadýr.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
