using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Form_Odev
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
                                                   //sender parametresi bu olayı hangi butonun tetiklediği bilgisini taşır
            lblSonuc.Text += tiklananButon.Text; // Butonun üzerindeki metni ekrana ekle
        }

        private void IslemButon_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            _islem = Convert.ToChar(tiklananButon.Text); // İşlem türünü al
            lblIslemGoster.Text = _islem.ToString(); // Mevcut işlemi göster
            _ekranTemizlenecekMi = true; // Sonraki rakam girişinde ekran temizlenecek
            _ilkSayi = Convert.ToDecimal(lblSonuc.Text); // İlk sayıyı al

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0"; // Ekranı sıfırla
            _ilkSayi = 0; // İlk sayıyı sıfırla
            _islem = '\0'; // İşlem türünü sıfırla
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
                        MessageBox.Show("Bir sayı sıfıra bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
            lblSonuc.Text = sonuc.ToString();
            _ekranTemizlenecekMi = true; // Sonraki rakam girişinde ekran temizlenecek
            lblIslemGoster.Text = ""; // İşlem gösterimini temizle
        }
    }
}
