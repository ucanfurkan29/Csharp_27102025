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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHesapMakinesiAc_Click(object sender, EventArgs e)
        {
            frmHesapMakinesi frmHesapMakinesi = new frmHesapMakinesi();
            frmHesapMakinesi.Show();
        }

        private void btnAnketAc_Click(object sender, EventArgs e)
        {
            frmAnket frmAnket = new frmAnket();
            frmAnket.ShowDialog();
        }
    }
}
