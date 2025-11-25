namespace _04_Hesap_Makinesi
{
    public partial class frmHesapMakinesi : Form
    {
        private decimal _ilkSayi;
        private char _islem;
        private bool _ekranTemizlenecekMi;

        public frmHesapMakinesi()
        {
            InitializeComponent();
        }

        private void RakamButon_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0" || _ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }

            Button tiklananButon = (Button)sender; // Gönderilen butonu al
                                                   //sender parametresi bu olayý hangi butonun tetiklediði bilgisini taþýr
            lblSonuc.Text += tiklananButon.Text; // Butonun üzerindeki metni ekrana ekle
        }

        private void IslemButon_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            _islem = Convert.ToChar(tiklananButon.Text); // Ýþlem türünü al
            lblIslemGoster.Text = _islem.ToString(); // Mevcut iþlemi göster
            _ekranTemizlenecekMi = true; // Sonraki rakam giriþinde ekran temizlenecek
            _ilkSayi = Convert.ToDecimal(lblSonuc.Text); // Ýlk sayýyý al

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0"; // Ekraný sýfýrla
            _ilkSayi = 0; // Ýlk sayýyý sýfýrla
            _islem = '\0'; // Ýþlem türünü sýfýrla
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            decimal ikinciSayi = Convert.ToDecimal(lblSonuc.Text);
            decimal sonuc = 0;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    if (ikinciSayi != 0)
                    {
                        sonuc = _ilkSayi / ikinciSayi;
                    }
                    else
                    {
                        MessageBox.Show("Bir sayý sýfýra bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
            lblSonuc.Text = sonuc.ToString();
            _ekranTemizlenecekMi = true; // Sonraki rakam giriþinde ekran temizlenecek
            lblIslemGoster.Text = ""; // Ýþlem gösterimini temizle
        }


    }
}
