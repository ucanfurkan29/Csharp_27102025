namespace _07_Sekmeli_Stok_Yonetimi
{
    public partial class Form1 : Form
    {
        List<Urun> urunListesi = new List<Urun>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urunListesi.Add(new Urun { Id = 101, Ad = "Laptop" });
            urunListesi.Add(new Urun { Id = 102, Ad = "Klavye" });
            urunListesi.Add(new Urun { Id = 103, Ad = "Monitor" });

            lstUrunler.DataSource = urunListesi; // Listeyi veri kaynaðý olarak atýyoruz
            lstUrunler.DisplayMember = "Ad"; // Görüntülenecek alan
            lstUrunler.ValueMember = "Id"; // Deðer alaný
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem != null)
            {
                Urun secilenUrun = (Urun)lstUrunler.SelectedItem;
                lblUrunId.Text = secilenUrun.Id.ToString();
                lblUrunAdi.Text = secilenUrun.Ad;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int yeniId = int.Parse(txtYeniUrunId.Text);
                string yeniAd = txtYeniUrunAdi.Text;
                urunListesi.Add(new Urun { Id = yeniId, Ad = yeniAd });

                lstUrunler.DataSource = null; // Veri kaynaðýný sýfýrla
                lstUrunler.DataSource = urunListesi; // Yeniden ata
                lstUrunler.DisplayMember = "Ad";
                lstUrunler.ValueMember = "Id";

                MessageBox.Show("Ürün baþarýyla eklendi.");

                txtYeniUrunId.Clear();
                txtYeniUrunAdi.Clear();

                TabControl.SelectedTab = tabPageUrunListesi; // Ürün listesi sekmesine geç

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
