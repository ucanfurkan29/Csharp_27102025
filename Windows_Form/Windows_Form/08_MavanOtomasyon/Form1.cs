using System.Collections;

namespace _08_MavanOtomasyon
{
    public partial class Form1 : Form
    {
        ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "MUZ", "PORTAKAL", "MANDALÝNA" };
        ArrayList halSebzeler = new ArrayList() { "DOMATES", "BÝBER", "PATLICAN", "PATATES", "KEREVÝZ" };
        ArrayList manavMeyveler = new ArrayList();
        ArrayList manavMeyveKilo = new ArrayList();
        ArrayList manavSebze = new ArrayList();
        ArrayList manavSebzeKilo = new ArrayList();
        ArrayList musteri = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void GuncelleHalUrunler()
        {
            lstHalUrunler.Items.Clear();
            if (cmbHalKategori.SelectedItem.ToString() == "Meyve")
            {
                foreach (var meyve in halMeyveler)
                {
                    lstHalUrunler.Items.Add(meyve);
                }
            }
            else
            {
                foreach (var sebze in halSebzeler)
                {
                    lstHalUrunler.Items.Add(sebze);
                }
            }
        }
        private void GuncelleManavUrunler()
        {
            lstManavUrunler.Items.Clear();
            if (cmbManavKategori.SelectedItem.ToString() == "Meyve")
            {
                for (int i = 0; i < manavMeyveler.Count; i++)
                {
                    lstManavUrunler.Items.Add($"{manavMeyveler[i]} - {manavMeyveKilo[i]} KG");
                }
            }
            else
            {
                for (int i = 0; i < manavSebze.Count; i++)
                {
                    lstManavUrunler.Items.Add($"{manavSebze[i]} - {manavSebzeKilo[i]} KG");
                }
            }
        }
        private void UrunAl(ArrayList list, string urun, ArrayList kiloList, int eklenenKilo)
        {
            if (!list.Contains(urun))
            {
                list.Add(urun);
                kiloList.Add(eklenenKilo);
            }
            else
            {
                int index = list.IndexOf(urun);
                int mevcutKilo = (int)kiloList[index];
                kiloList[index] = mevcutKilo + eklenenKilo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHalKategori.SelectedIndex = 0;
            GuncelleHalUrunler();
            cmbManavKategori.SelectedIndex = 0;
            GuncelleManavUrunler();

        }

        private void cmbHalKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleHalUrunler();
        }
        private void cmbManavKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleManavUrunler();
        }

        private void btnHalEkle_Click(object sender, EventArgs e)
        {
            string kategori = cmbHalKategori.SelectedItem.ToString(); // Seçilen kategori al
            string urun = lstHalUrunler.SelectedItem.ToString(); // Seçilen ürünü al

            //seçilen ürün boþ ise uyarý ver
            if (urun == null)
            {
                MessageBox.Show("Lütfen Listeden Bir Ürün Seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //girilen kilo 0dan küçük veya geçerli bir sayý deðilse uyarý ver
            if (!int.TryParse(txtHalKilo.Text, out int kilo) || kilo <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir kilo giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (kategori == "Meyve")
            {
                UrunAl(manavMeyveler, urun, manavMeyveKilo, kilo);
                GuncelleManavUrunler();
                MessageBox.Show($"{urun} - {kilo} kilo manav meyveye eklendi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UrunAl(manavSebze, urun, manavSebzeKilo, kilo);
                GuncelleManavUrunler();
                MessageBox.Show($"{urun} - {kilo} kilo manav sebzeye eklendi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtHalKilo.Clear();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_halEkle_Click(object sender, EventArgs e)
        {
            string urun = txt_urun.Text.ToUpper();
            if (cmbHalKategori.SelectedIndex == 0)
            {
                if (!string.IsNullOrEmpty(urun))
                {
                    if (!halMeyveler.Contains(urun))
                    {
                        halMeyveler.Add(urun);
                        MessageBox.Show($"{urun} Hal Meyve Stoðuna Eklendi!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{urun} Zaten Mevcut!", "Baþarýsýz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Adý Boþ Býrakýlamaz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cmbHalKategori.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(urun))
                {
                    if (!halSebzeler.Contains(urun))
                    {
                        halSebzeler.Add(urun);
                        MessageBox.Show($"{urun} Hal Sebze Stoðuna Eklendi!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{urun} Zaten Mevcut!", "Baþarýsýz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Adý Boþ Býrakýlamaz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txt_urun.Clear();
            GuncelleHalUrunler();
        }

        private void btnManavSatis_Click(object sender, EventArgs e)
        {
            string kategori = cmbManavKategori.SelectedItem.ToString();
            string secilenUrunFull = lstManavUrunler.SelectedItem?.ToString();
            if (secilenUrunFull == null)
            {
                MessageBox.Show("Lütfen Bir ürün seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] urunParts = secilenUrunFull.Split('-');
            if (urunParts.Length < 2)
            {
                MessageBox.Show("Geçersiz ürün formatý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string secilenUrun = urunParts[0].Trim(); //trim boþluklarý kaldýrýr
            if (!int.TryParse(txtManavKilo.Text, out int kilo) || kilo <= 0)
            {
                MessageBox.Show("Geçersiz kilo girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool satildi = false;

            if (kategori == "Meyve")
            {
                int index = manavMeyveler.IndexOf(secilenUrun);
                if (index >= 0)
                {
                    int mevcutKilo = (int)manavMeyveKilo[index];
                    if (mevcutKilo >= kilo)
                    {
                        manavMeyveKilo[index] = mevcutKilo - kilo;
                        musteri.Add($"{secilenUrun} - {kilo} KG");
                        if ((int)manavMeyveKilo[index] == 0)
                        {
                            manavMeyveler.RemoveAt(index);
                            manavMeyveKilo.RemoveAt(index);
                        }
                        satildi = true;
                        MessageBox.Show($"Satýþ Baþarýlý", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Yeterli stok yok. Mevcut: {mevcutKilo} kg", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                int index = manavSebze.IndexOf(secilenUrun);
                if (index >= 0)
                {
                    int mevcutKilo = (int)manavSebzeKilo[index];
                    if (mevcutKilo >= kilo)
                    {
                        manavSebzeKilo[index] = mevcutKilo - kilo;
                        musteri.Add($"{secilenUrun} - {kilo} KG");
                        if ((int)manavSebzeKilo[index] == 0)
                        {
                            manavSebze.RemoveAt(index);
                            manavSebzeKilo.RemoveAt(index);
                        }
                        satildi = true;
                        MessageBox.Show($"Satýþ Baþarýlý", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Yeterli stok yok. Mevcut: {mevcutKilo} kg", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (satildi)
            {
                GuncelleManavUrunler();
                GuncelleMusteriListesi();
            }

            txtManavKilo.Clear();
        }
        private void GuncelleMusteriListesi()
        {
            lstMusteri.Items.Clear();
            foreach (var item in musteri)
            {
                lstMusteri.Items.Add(item.ToString());
            }
        }
    }
}
