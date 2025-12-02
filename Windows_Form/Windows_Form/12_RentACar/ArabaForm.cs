using _12_RentACar.Data;
using _12_RentACar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_RentACar
{
    public partial class ArabaForm : Form
    {
        DataContext _context;
        Araba _kiralikAraba;
        Musteri _musteri;
        DateTime finisDate;
        DateTime startDate;

        public ArabaForm(Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            this._musteri = musteri;
            dtp_kTarih.MinDate = DateTime.Now;
            dtp_tTarih.MinDate = DateTime.Now;

        }

        private void ArabaForm_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            cmb_Listele.DataSource = _context.Markalar.ToList();
            cmb_Listele.DisplayMember = "Ad";
            cmb_Listele.ValueMember = "Id";
            cmb_Listele.SelectedIndex = -1;
            dtp_kTarih.Value = time;
            dtp_tTarih.Value = time.AddDays(1);
            dtp_kSaat.Value = time;
            dtp_tSaat.Value = time;

            YukleAktifAraclar();
        }
        private void YukleAktifAraclar()
        {
            var arabaList = _context.Arabalar.Where(a => a.Aktif)
                .Include(i => i.Marka)
                .Select(a => new
                {
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret,
                    Marka = a.Marka.Ad,
                    Aktif = a.Aktif
                }).ToList();
            dtg_arabalar.DataSource = arabaList;
        }

        private void btn_arabaGetir_Click(object sender, EventArgs e)
        {
            cmb_Listele.BackColor = Color.White;

            var arabaList = _context.Arabalar.Where(a => a.Aktif).AsQueryable();
            if (cmb_Listele.SelectedValue != null)
            {
                arabaList = arabaList.Where(i => i.MarkaId == (int)cmb_Listele.SelectedValue);
            }
            dtg_arabalar.DataSource = arabaList.Include(i => i.Marka)
                .Select(a => new
                {
                    Id = a.Id,
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret,
                    Marka = a.Marka.Ad,
                    Aktif = a.Aktif
                }).ToList();
        }

        private void dtg_arabalar_DoubleClick(object sender, EventArgs e)
        {
            int id = 0; //seçilen aracın id değerini tutacak.
            cmb_Listele.BackColor = Color.White;
            if (dtg_arabalar.SelectedRows.Count > 0)
            {
                try
                {
                    id = (int)dtg_arabalar.SelectedRows[0].Cells[0].Value; //seçilen aracın id sini alıyoruz.
                    _kiralikAraba = _context.Arabalar.Include(a => a.Marka).FirstOrDefault(a => a.Id == id); //seçilen aracı veritabanından çekiyoruz.
                    if (_kiralikAraba == null)
                    {
                        MessageBox.Show("Araba bulunamadı");
                        return;
                    }
                    txt_kAraba.Text = _kiralikAraba.Marka.Ad + " " + _kiralikAraba.Model;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Marka Seçin");
                    cmb_Listele.BackColor = Color.Red;
                    return;
                }
            }
        }
    }
}
