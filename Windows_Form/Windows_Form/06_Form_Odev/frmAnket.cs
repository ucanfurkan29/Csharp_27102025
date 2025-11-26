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
    public partial class frmAnket : Form
    {
        public frmAnket()
        {
            InitializeComponent();
        }

        private void frmAnket_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cmbPuan.Items.Add(i);
            }
        }

        private void btnAnketiGonder_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder anketSonuc = new System.Text.StringBuilder();

            //1.Kişi Bilgileri
            anketSonuc.AppendLine($"Ad Soyad: {txtAdSoyad.Text}");
            anketSonuc.AppendLine("-------------------------------");

            //2. Kullanım sıklığı
            if (rbHergun.Checked)
            {
                anketSonuc.AppendLine("Kullanım Sıklığı: Her Gün");
            }
            else if (rbHaftadabir.Checked)
            {
                anketSonuc.AppendLine("Kullanım Sıklığı: Haftada Bir");
            }
            else if (rbAydabir.Checked)
            {
                anketSonuc.AppendLine("Kullanım Sıklığı: Aylık");
            }
            else
            {
                anketSonuc.AppendLine("Kullanım Sıklığı: Belirtilmemiş");
            }
            anketSonuc.AppendLine("-------------------------------");

            //3.Beğenilen özellik
            anketSonuc.AppendLine("Beğenilen Özellikler:");
            if (chkAnket.Checked)
            {
                anketSonuc.AppendLine("- Anket Özelliği");
            }
            if (chkHesapMakinesi.Checked)
            {
                anketSonuc.AppendLine("- Hesap Makinesi Özelliği");
            }
            anketSonuc.AppendLine("-------------------------------");

            //4.Puanlama
            if (cmbPuan.SelectedItem != null)
            {
                anketSonuc.AppendLine($"Puanlama: {cmbPuan.SelectedItem}");
            }
            else
            {
                anketSonuc.AppendLine("Puanlama: Belirtilmemiş");
            }

            MessageBox.Show(anketSonuc.ToString(), "Anket Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSayfaKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFullKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
