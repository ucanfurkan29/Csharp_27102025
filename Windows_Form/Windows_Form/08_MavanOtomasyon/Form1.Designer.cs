namespace _08_MavanOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageHal = new TabPage();
            lblHalKilo = new Label();
            lblHalUrun = new Label();
            txtHalKilo = new TextBox();
            txt_urun = new TextBox();
            btnHalEkle = new Button();
            btn_halEkle = new Button();
            lstHalUrunler = new ListBox();
            cmbHalKategori = new ComboBox();
            lblHalKategori = new Label();
            tabPageManav = new TabPage();
            label2 = new Label();
            btnManavSatis = new Button();
            label1 = new Label();
            txtManavKilo = new TextBox();
            lstMusteri = new ListBox();
            lstManavUrunler = new ListBox();
            cmbManavKategori = new ComboBox();
            lblManavKategori = new Label();
            btn_cikis = new Button();
            tabControl1.SuspendLayout();
            tabPageHal.SuspendLayout();
            tabPageManav.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageHal);
            tabControl1.Controls.Add(tabPageManav);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 397);
            tabControl1.TabIndex = 0;
            // 
            // tabPageHal
            // 
            tabPageHal.Controls.Add(lblHalKilo);
            tabPageHal.Controls.Add(lblHalUrun);
            tabPageHal.Controls.Add(txtHalKilo);
            tabPageHal.Controls.Add(txt_urun);
            tabPageHal.Controls.Add(btnHalEkle);
            tabPageHal.Controls.Add(btn_halEkle);
            tabPageHal.Controls.Add(lstHalUrunler);
            tabPageHal.Controls.Add(cmbHalKategori);
            tabPageHal.Controls.Add(lblHalKategori);
            tabPageHal.Location = new Point(4, 24);
            tabPageHal.Name = "tabPageHal";
            tabPageHal.Padding = new Padding(3);
            tabPageHal.Size = new Size(768, 369);
            tabPageHal.TabIndex = 0;
            tabPageHal.Text = "Hal -Toptancı";
            tabPageHal.UseVisualStyleBackColor = true;
            // 
            // lblHalKilo
            // 
            lblHalKilo.AutoSize = true;
            lblHalKilo.Location = new Point(163, 270);
            lblHalKilo.Name = "lblHalKilo";
            lblHalKilo.Size = new Size(30, 15);
            lblHalKilo.TabIndex = 8;
            lblHalKilo.Text = "Kilo:";
            // 
            // lblHalUrun
            // 
            lblHalUrun.AutoSize = true;
            lblHalUrun.Location = new Point(26, 270);
            lblHalUrun.Name = "lblHalUrun";
            lblHalUrun.Size = new Size(33, 15);
            lblHalUrun.TabIndex = 7;
            lblHalUrun.Text = "Ürün";
            // 
            // txtHalKilo
            // 
            txtHalKilo.Location = new Point(138, 288);
            txtHalKilo.Name = "txtHalKilo";
            txtHalKilo.Size = new Size(100, 23);
            txtHalKilo.TabIndex = 6;
            // 
            // txt_urun
            // 
            txt_urun.Location = new Point(17, 288);
            txt_urun.Name = "txt_urun";
            txt_urun.Size = new Size(100, 23);
            txt_urun.TabIndex = 5;
            // 
            // btnHalEkle
            // 
            btnHalEkle.Location = new Point(138, 317);
            btnHalEkle.Name = "btnHalEkle";
            btnHalEkle.Size = new Size(100, 34);
            btnHalEkle.TabIndex = 4;
            btnHalEkle.Text = "Ekle";
            btnHalEkle.UseVisualStyleBackColor = true;
            // 
            // btn_halEkle
            // 
            btn_halEkle.Location = new Point(17, 317);
            btn_halEkle.Name = "btn_halEkle";
            btn_halEkle.Size = new Size(100, 34);
            btn_halEkle.TabIndex = 3;
            btn_halEkle.Text = "Hal Ekle";
            btn_halEkle.UseVisualStyleBackColor = true;
            // 
            // lstHalUrunler
            // 
            lstHalUrunler.FormattingEnabled = true;
            lstHalUrunler.ItemHeight = 15;
            lstHalUrunler.Location = new Point(17, 58);
            lstHalUrunler.Name = "lstHalUrunler";
            lstHalUrunler.Size = new Size(280, 199);
            lstHalUrunler.TabIndex = 2;
            // 
            // cmbHalKategori
            // 
            cmbHalKategori.FormattingEnabled = true;
            cmbHalKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbHalKategori.Location = new Point(86, 29);
            cmbHalKategori.Name = "cmbHalKategori";
            cmbHalKategori.Size = new Size(121, 23);
            cmbHalKategori.TabIndex = 1;
            // 
            // lblHalKategori
            // 
            lblHalKategori.AutoSize = true;
            lblHalKategori.Location = new Point(17, 32);
            lblHalKategori.Name = "lblHalKategori";
            lblHalKategori.Size = new Size(54, 15);
            lblHalKategori.TabIndex = 0;
            lblHalKategori.Text = "Kategori:";
            // 
            // tabPageManav
            // 
            tabPageManav.Controls.Add(label2);
            tabPageManav.Controls.Add(btnManavSatis);
            tabPageManav.Controls.Add(label1);
            tabPageManav.Controls.Add(txtManavKilo);
            tabPageManav.Controls.Add(lstMusteri);
            tabPageManav.Controls.Add(lstManavUrunler);
            tabPageManav.Controls.Add(cmbManavKategori);
            tabPageManav.Controls.Add(lblManavKategori);
            tabPageManav.Location = new Point(4, 24);
            tabPageManav.Name = "tabPageManav";
            tabPageManav.Padding = new Padding(3);
            tabPageManav.Size = new Size(768, 369);
            tabPageManav.TabIndex = 1;
            tabPageManav.Text = "Manav";
            tabPageManav.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 33);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 7;
            label2.Text = "Müşterinin Aldığı Ürünler";
            // 
            // btnManavSatis
            // 
            btnManavSatis.Location = new Point(87, 286);
            btnManavSatis.Name = "btnManavSatis";
            btnManavSatis.Size = new Size(100, 30);
            btnManavSatis.TabIndex = 6;
            btnManavSatis.Text = "Satış Yap";
            btnManavSatis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 248);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Kilo:";
            // 
            // txtManavKilo
            // 
            txtManavKilo.Location = new Point(87, 248);
            txtManavKilo.Name = "txtManavKilo";
            txtManavKilo.Size = new Size(100, 23);
            txtManavKilo.TabIndex = 4;
            // 
            // lstMusteri
            // 
            lstMusteri.FormattingEnabled = true;
            lstMusteri.ItemHeight = 15;
            lstMusteri.Location = new Point(453, 66);
            lstMusteri.Name = "lstMusteri";
            lstMusteri.Size = new Size(260, 154);
            lstMusteri.TabIndex = 3;
            // 
            // lstManavUrunler
            // 
            lstManavUrunler.FormattingEnabled = true;
            lstManavUrunler.ItemHeight = 15;
            lstManavUrunler.Location = new Point(27, 66);
            lstManavUrunler.Name = "lstManavUrunler";
            lstManavUrunler.Size = new Size(235, 154);
            lstManavUrunler.TabIndex = 2;
            // 
            // cmbManavKategori
            // 
            cmbManavKategori.FormattingEnabled = true;
            cmbManavKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbManavKategori.Location = new Point(87, 25);
            cmbManavKategori.Name = "cmbManavKategori";
            cmbManavKategori.Size = new Size(121, 23);
            cmbManavKategori.TabIndex = 1;
            // 
            // lblManavKategori
            // 
            lblManavKategori.AutoSize = true;
            lblManavKategori.Location = new Point(27, 28);
            lblManavKategori.Name = "lblManavKategori";
            lblManavKategori.Size = new Size(54, 15);
            lblManavKategori.TabIndex = 0;
            lblManavKategori.Text = "Kategori:";
            // 
            // btn_cikis
            // 
            btn_cikis.Location = new Point(673, 415);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(75, 23);
            btn_cikis.TabIndex = 1;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cikis);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Manav Otomasyonu";
            tabControl1.ResumeLayout(false);
            tabPageHal.ResumeLayout(false);
            tabPageHal.PerformLayout();
            tabPageManav.ResumeLayout(false);
            tabPageManav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageHal;
        private Label lblHalKilo;
        private Label lblHalUrun;
        private TextBox txtHalKilo;
        private TextBox txt_urun;
        private Button btnHalEkle;
        private Button btn_halEkle;
        private ListBox lstHalUrunler;
        private ComboBox cmbHalKategori;
        private Label lblHalKategori;
        private TabPage tabPageManav;
        private Button btn_cikis;
        private ListBox lstMusteri;
        private ListBox lstManavUrunler;
        private ComboBox cmbManavKategori;
        private Label lblManavKategori;
        private Button btnManavSatis;
        private Label label1;
        private TextBox txtManavKilo;
        private Label label2;
    }
}
