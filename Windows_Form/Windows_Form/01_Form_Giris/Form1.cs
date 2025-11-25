namespace _01_Form_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Merhaba Dünya!";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "Güncellendi.";
        }

        private void btnSelamla_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtAd.Text;
            lblSonuc.Text = $"Merhaba {kullaniciAdi}";

            MessageBox.Show($"Merhaba, {kullaniciAdi}",
                            "Pencere Baþlýðý: Selamla",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                );
        }
    }
}
