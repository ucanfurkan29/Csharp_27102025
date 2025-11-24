namespace _03_ATM_Otomasyon
{
    public partial class Form1 : Form
    {
        private int yanlisGirisSayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girilenHesapAdi = txtHesapNo.Text.Trim();
            string girilenSifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(girilenHesapAdi) || string.IsNullOrEmpty(girilenSifre))
            {
                lblHata.Text = "Lütfen tüm alanlarý doldurun!";
                return;
            }

            // Hesap yönetimi sistemi ile giriþ kontrolü
            var hesap = HesapYonetimi.GirisYap(girilenHesapAdi, girilenSifre);

            if (hesap != null)
            {
                // Baþarýlý giriþ
                MessageBox.Show($"Giriþ baþarýlý! Hoþ geldiniz {hesap.KullaniciAdi}.\nHesap No: {hesap.HesapNo}", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana menü formunu aç
                FormAnaMenu anaMenu = new FormAnaMenu();
                this.Hide();
                anaMenu.ShowDialog();
    
                // Ana menüden geri dönünce formu temizle ve göster
                FormuTemizle();
                this.Show();
            }
            else
            {
                yanlisGirisSayisi++;
                int kalanHak = 3 - yanlisGirisSayisi;

                if (yanlisGirisSayisi >= 3)
                {
                    MessageBox.Show("3 yanlýþ giriþ yaptýnýz! Hesabýnýz bloke edildi.", "BLOKE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGiris.Enabled = false;
                    txtHesapNo.Enabled = false;
                    txtSifre.Enabled = false;
                    lblHata.Text = "Hesap bloke edildi!";
                }
                else
                {
                    lblHata.Text = $"Hatalý giriþ! Kalan hakkýnýz: {kalanHak}";
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
            }
        }

        private void FormuTemizle()
        {
            // Formu baþlangýç durumuna getir
            txtHesapNo.Clear();
            txtSifre.Clear();
            lblHata.Text = "";
            yanlisGirisSayisi = 0;
            btnGiris.Enabled = true;
            txtHesapNo.Enabled = true;
            txtSifre.Enabled = true;
            txtHesapNo.Focus();
  
            // Aktif hesaptan çýkýþ yap
            HesapYonetimi.CikisYap();
        }
    }
}
