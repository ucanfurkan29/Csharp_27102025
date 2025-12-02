using _12_RentACar.Data;
using _12_RentACar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_RentACar
{
    public partial class Login : Form
    {
        private readonly DataContext _db;
        public Login()
        {
            InitializeComponent();
            _db = new DataContext();
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_kPassword.Text != txt_kRePassword.Text)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                    txt_kPassword.Clear();
                    txt_kRePassword.Clear();
                    return;
                }
                var customer = _db.Musteriler.Where(i => i.Telefon == txt_kTel.Text).FirstOrDefault();
                if (customer != null)
                {
                    MessageBox.Show("Telefon numarası daha önce kayıt olmuş.");
                    txt_kTel.Clear();
                    txt_kPassword.Clear();
                    txt_kRePassword.Clear();
                    return;
                }
                Musteri musteri = new Musteri()
                {
                    AdSoyad = txt_kAdAsoyad.Text,
                    Telefon = txt_kTel.Text,
                    Bakiye = Convert.ToDouble(txt_kBakiye.Text),
                    Password = txt_kPassword.Text
                };

                //doğrulama işlemi başlangıcı
                var validationContext = new ValidationContext(musteri); // doğrulama bağlamı oluştur
                var validationResults = new List<ValidationResult>(); // doğrulama sonuçlarını tutacak liste
                bool isValid = Validator.TryValidateObject(musteri, validationContext, validationResults, true); // doğrulama işlemi
                if (!isValid)
                {
                    MessageBox.Show("Kayıt başarısız:\n" + validationResults[0].ErrorMessage);
                    return;
                }
                //doğrulama işlemi sonu

                _db.Musteriler.Add(musteri);
                int eks = _db.SaveChanges(); // değişiklikleri kaydederken etkilenen satır sayısını döner
                if (eks > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı");
                    txt_kAdAsoyad.Clear();
                    txt_kTel.Clear();
                    txt_kBakiye.Clear();
                    txt_kPassword.Clear();
                    txt_kRePassword.Clear();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            string telefon = txt_GirisTel.Text;
            string sifre = txt_GirisSifre.Text;
            var musteri = _db.Musteriler.FirstOrDefault(m => m.Telefon == telefon && m.Password == sifre);
            if (musteri == null)
            {
                MessageBox.Show("Giriş bilgileri hatalıdır");
            }
            else if (sifre == musteri.Password && telefon == musteri.Telefon)
            {
                MessageBox.Show("Giriş başarılı","bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();// Login formunu gizle
                ArabaForm form = new ArabaForm(musteri);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }
        }
    }
}
