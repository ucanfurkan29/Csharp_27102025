namespace _02_Ogrenci_Bilgi_Sistemi
{
    public partial class Form1 : Form
    {
        // Static liste - tüm formlar arasýnda paylaþýlacak
        public static List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
            string.IsNullOrWhiteSpace(txtSoyad.Text) ||
            string.IsNullOrWhiteSpace(txtOgrenciNo.Text) ||
            string.IsNullOrWhiteSpace(txtBolum.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Öðrenci oluþtur ve listeye ekle
            Ogrenci yeniOgrenci = new Ogrenci(
            txtAd.Text,
            txtSoyad.Text,
            txtOgrenciNo.Text,
            txtBolum.Text,
            dtpDogumTarihi.Value
            );

            ogrenciListesi.Add(yeniOgrenci);

            MessageBox.Show("Öðrenci baþarýyla kaydedildi!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu temizle
            TemizleForm();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // Listeleme formunu aç
            OgrenciListeleForm listeleForm = new OgrenciListeleForm();
            listeleForm.ShowDialog();
        }

        private void TemizleForm()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtOgrenciNo.Clear();
            txtBolum.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            txtAd.Focus();
        }
    }
}
