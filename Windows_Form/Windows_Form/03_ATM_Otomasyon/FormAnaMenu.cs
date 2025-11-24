namespace _03_ATM_Otomasyon
{
    public partial class FormAnaMenu : Form
    {
        public FormAnaMenu()
        {
   InitializeComponent();
BakiyeGuncelle();
        }

        private void BakiyeGuncelle()
        {
      if (HesapYonetimi.AktifHesap != null)
         {
  lblBakiyeTutar.Text = HesapYonetimi.AktifHesap.Bakiye.ToString("C2");
             // Hesap bilgisini de göster
this.Text = $"ATM Ana Menü - Hesap No: {HesapYonetimi.AktifHesap.HesapNo} ({HesapYonetimi.AktifHesap.KullaniciAdi})";
         }
   }

 private void btnParaYatir_Click(object sender, EventArgs e)
     {
          string input = Microsoft.VisualBasic.Interaction.InputBox("Yatýrmak istediðiniz tutarý giriniz:", "Para Yatýr", "0");
          
      if (decimal.TryParse(input, out decimal tutar) && tutar > 0)
         {
          if (HesapYonetimi.ParaYatir(tutar))
        {
         BakiyeGuncelle();
       MessageBox.Show($"{tutar:C2} hesabýnýza yatýrýldý.\nYeni bakiyeniz: {HesapYonetimi.AktifHesap.Bakiye:C2}", "Ýþlem Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
          {
      MessageBox.Show("Ýþlem gerçekleþtirilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
  else if (!string.IsNullOrEmpty(input))
            {
     MessageBox.Show("Geçersiz tutar!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     }
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
 string input = Microsoft.VisualBasic.Interaction.InputBox("Çekmek istediðiniz tutarý giriniz:", "Para Çek", "0");
   
            if (decimal.TryParse(input, out decimal tutar) && tutar > 0)
            {
      if (HesapYonetimi.ParaCek(tutar))
         {
  BakiyeGuncelle();
          MessageBox.Show($"{tutar:C2} hesabýnýzdan çekildi.\nKalan bakiyeniz: {HesapYonetimi.AktifHesap.Bakiye:C2}", "Ýþlem Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
        else
    {
      MessageBox.Show("Yetersiz bakiye!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
       }
   else if (!string.IsNullOrEmpty(input))
 {
      MessageBox.Show("Geçersiz tutar!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
        }

        private void btnParaGonder_Click(object sender, EventArgs e)
        {
         // Önce mevcut hesaplarý göster
     string hesapListesi = "Mevcut Hesaplar:\n\n";
            foreach (var hesap in HesapYonetimi.Hesaplar)
  {
     if (hesap.HesapNo != HesapYonetimi.AktifHesap.HesapNo)
          {
        hesapListesi += $"Hesap No: {hesap.HesapNo} - {hesap.KullaniciAdi}\n";
}
         }
        
      MessageBox.Show(hesapListesi, "Hesap Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
            string hesapNoInput = Microsoft.VisualBasic.Interaction.InputBox("Alýcý hesap numarasýný giriniz:", "Para Gönder", "");
            
            if (string.IsNullOrEmpty(hesapNoInput))
 return;

    if (!int.TryParse(hesapNoInput, out int aliciHesapNo))
    {
       MessageBox.Show("Geçersiz hesap numarasý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
        }

          // Alýcý hesabý kontrol et
      var aliciHesap = HesapYonetimi.HesapNoylaBul(aliciHesapNo);
       if (aliciHesap == null)
            {
  MessageBox.Show("Hesap bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return;
            }

  if (aliciHesapNo == HesapYonetimi.AktifHesap.HesapNo)
            {
        MessageBox.Show("Kendi hesabýnýza para gönderemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   return;
      }

            string input = Microsoft.VisualBasic.Interaction.InputBox($"Alýcý: {aliciHesap.KullaniciAdi} (Hesap No: {aliciHesap.HesapNo})\n\nGöndermek istediðiniz tutarý giriniz:", "Para Gönder", "0");
            
       if (decimal.TryParse(input, out decimal tutar) && tutar > 0)
            {
      decimal oncekiBakiye = aliciHesap.Bakiye;
                
      if (HesapYonetimi.ParaGonder(aliciHesapNo, tutar))
          {
       BakiyeGuncelle();
   MessageBox.Show($"{tutar:C2} baþarýyla {aliciHesap.KullaniciAdi} ({aliciHesap.HesapNo}) numaralý hesaba gönderildi.\n\n" +
  $"Kalan bakiyeniz: {HesapYonetimi.AktifHesap.Bakiye:C2}\n" +
           $"Alýcýnýn yeni bakiyesi: {aliciHesap.Bakiye:C2} (Önceki: {oncekiBakiye:C2})", 
                 "Ýþlem Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
       else
        {
       MessageBox.Show("Yetersiz bakiye!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     }
            }
            else if (!string.IsNullOrEmpty(input))
       {
          MessageBox.Show("Geçersiz tutar!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 }
        }

     private void btnKartIade_Click(object sender, EventArgs e)
    {
            DialogResult result = MessageBox.Show("Çýkýþ yapmak istediðinize emin misiniz?", "Kart Ýade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
   
     if (result == DialogResult.Yes)
            {
      MessageBox.Show($"Kartýnýz iade ediliyor.\nSon bakiyeniz: {HesapYonetimi.AktifHesap.Bakiye:C2}\n\nÝyi günler dileriz!", "Çýkýþ", MessageBoxButtons.OK, MessageBoxIcon.Information);
      // Ana menüyü kapat, giriþ ekranýna dön
                this.Close();
     }
        }
    }
}
