namespace _05_Form_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 50m;
            string siparisDetayi = "Sipariþ Detaylarý:\n";
            if (chkKetcap.Checked == true)
            {
                toplamTutar += 2;
                siparisDetayi += "- Ketçap: 2 TL\n";
            }
            if (chkMayonez.Checked == true)
            {
                toplamTutar += 3;
                siparisDetayi += "- Mayonez: 3 TL\n";
            }
            if (chkHardal.Checked == true)
            {
                toplamTutar += 4;
                siparisDetayi += "- Hardal Sos: 4 TL\n";
            }
            lblOzet.Text = $"{siparisDetayi} -Burger: 50tl\n Toplam Tutar: {toplamTutar} TL";
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string secilenKargo = "";
            if (rbStandart.Checked)
            {
                secilenKargo = "Standart Kargo seçildi. Ücret: 15tl";
            }
            else if (rbHizli.Checked)
            {
                secilenKargo = "Hizli Kargo seçildi. Ücret: 30tl";
            }
            else if (rbAyniGun.Checked)
            {
                secilenKargo = "Ayný Gün Kargo seçildi. Ücret : 45tl";
            }
            MessageBox.Show(secilenKargo, "Kargo Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSehirler.Items.Add("Ýstanbul");
            cmbSehirler.Items.Add("Ankara");
            cmbSehirler.Items.Add("Ýzmir");
            cmbSehirler.Items.Add("Bursa");
            cmbSehirler.Items.Add("Antalya");

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (cmbSehirler.SelectedItem != null)
            {
                string secilenSehir = cmbSehirler.SelectedItem.ToString();
                MessageBox.Show($"Seçilen Þehir: {secilenSehir}", "Þehir Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir þehir seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAyarlarAc_Click(object sender, EventArgs e)
        {
            AyarlarFormu ayarlarFormu = new AyarlarFormu();
            //ayarlarFormu.ShowDialog(); // açýlan form ana formu bloke eder.
            ayarlarFormu.Show(); // açýlan form ana formu bloke etmez.
        }
    }
}
