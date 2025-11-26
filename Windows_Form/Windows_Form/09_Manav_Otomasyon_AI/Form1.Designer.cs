namespace _09_Manav_Otomasyon_AI
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
            tabStokYonetimi = new TabPage();
            groupBox2 = new GroupBox();
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dtpSonKullanma = new DateTimePicker();
            txtTedarikci = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cmbBirim = new ComboBox();
            label6 = new Label();
            txtStokMiktar = new TextBox();
            label5 = new Label();
            txtBirimFiyat = new TextBox();
            label4 = new Label();
            cmbKategori = new ComboBox();
            label3 = new Label();
            txtUrunAd = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnAra = new Button();
            txtArama = new TextBox();
            label9 = new Label();
            cmbKategoriFiltre = new ComboBox();
            label1 = new Label();
            dgvUrunler = new DataGridView();
            tabSatisIslemleri = new TabPage();
            groupBox4 = new GroupBox();
            lblToplamTutar = new Label();
            label14 = new Label();
            btnSatisYap = new Button();
            txtMusteriAd = new TextBox();
            label13 = new Label();
            txtSatisMiktar = new TextBox();
            label12 = new Label();
            cmbSatisUrun = new ComboBox();
            label11 = new Label();
            groupBox3 = new GroupBox();
            dgvSatislar = new DataGridView();
            tabRaporlar = new TabPage();
            groupBox7 = new GroupBox();
            dgvEnCokSatan = new DataGridView();
            label22 = new Label();
            groupBox6 = new GroupBox();
            lblToplamStokDegeri = new Label();
            label21 = new Label();
            lblAylikCiro = new Label();
            label19 = new Label();
            lblAylikSatisSayisi = new Label();
            label17 = new Label();
            lblGunlukCiro = new Label();
            label20 = new Label();
            lblGunlukSatisSayisi = new Label();
            label18 = new Label();
            groupBox5 = new GroupBox();
            dgvKritikStok = new DataGridView();
            label16 = new Label();
            dgvSonKullanma = new DataGridView();
            label15 = new Label();
            tabControl1.SuspendLayout();
            tabStokYonetimi.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            tabSatisIslemleri.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).BeginInit();
            tabRaporlar.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokSatan).BeginInit();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKritikStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSonKullanma).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStokYonetimi);
            tabControl1.Controls.Add(tabSatisIslemleri);
            tabControl1.Controls.Add(tabRaporlar);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1200, 700);
            tabControl1.TabIndex = 0;
            // 
            // tabStokYonetimi
            // 
            tabStokYonetimi.Controls.Add(groupBox2);
            tabStokYonetimi.Controls.Add(groupBox1);
            tabStokYonetimi.Controls.Add(dgvUrunler);
            tabStokYonetimi.Location = new Point(4, 26);
            tabStokYonetimi.Name = "tabStokYonetimi";
            tabStokYonetimi.Padding = new Padding(3);
            tabStokYonetimi.Size = new Size(1192, 670);
            tabStokYonetimi.TabIndex = 0;
            tabStokYonetimi.Text = "Stok Yönetimi";
            tabStokYonetimi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(dtpSonKullanma);
            groupBox2.Controls.Add(txtTedarikci);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbBirim);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtStokMiktar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtBirimFiyat);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbKategori);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtUrunAd);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(8, 460);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1176, 200);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Gray;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(950, 150);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(200, 35);
            btnTemizle.TabIndex = 17;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(660, 150);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 35);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Orange;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(410, 150);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 35);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Green;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(20, 150);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 35);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Yeni Ürün Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dtpSonKullanma
            // 
            dtpSonKullanma.Format = DateTimePickerFormat.Short;
            dtpSonKullanma.Location = new Point(950, 65);
            dtpSonKullanma.Name = "dtpSonKullanma";
            dtpSonKullanma.Size = new Size(200, 25);
            dtpSonKullanma.TabIndex = 13;
            // 
            // txtTedarikci
            // 
            txtTedarikci.Location = new Point(950, 105);
            txtTedarikci.Name = "txtTedarikci";
            txtTedarikci.Size = new Size(200, 25);
            txtTedarikci.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(850, 108);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 11;
            label8.Text = "Tedarikçi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(850, 68);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 10;
            label7.Text = "Son Kul. Tarihi:";
            // 
            // cmbBirim
            // 
            cmbBirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "KG", "Adet", "Litre" });
            cmbBirim.Location = new Point(660, 105);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(150, 25);
            cmbBirim.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 108);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 8;
            label6.Text = "Birim:";
            // 
            // txtStokMiktar
            // 
            txtStokMiktar.Location = new Point(660, 65);
            txtStokMiktar.Name = "txtStokMiktar";
            txtStokMiktar.Size = new Size(150, 25);
            txtStokMiktar.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 68);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 6;
            label5.Text = "Miktar:";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(410, 105);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(150, 25);
            txtBirimFiyat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 108);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 4;
            label4.Text = "Birim Fiyat:";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Sebze", "Meyve", "Kuruyemiş", "Diğer" });
            cmbKategori.Location = new Point(410, 65);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(150, 25);
            cmbKategori.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 68);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Kategori:";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(100, 65);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(200, 25);
            txtUrunAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adı:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(txtArama);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbKategoriFiltre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 80);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreleme ve Arama";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.SteelBlue;
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(850, 30);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(100, 30);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(520, 33);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Ürün adı, kategori veya tedarikçi ara...";
            txtArama.Size = new Size(300, 25);
            txtArama.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(450, 36);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 2;
            label9.Text = "Arama:";
            // 
            // cmbKategoriFiltre
            // 
            cmbKategoriFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriFiltre.FormattingEnabled = true;
            cmbKategoriFiltre.Location = new Point(100, 33);
            cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            cmbKategoriFiltre.Size = new Size(200, 25);
            cmbKategoriFiltre.TabIndex = 1;
            cmbKategoriFiltre.SelectedIndexChanged += cmbKategoriFiltre_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "Kategori:";
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.BackgroundColor = Color.White;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(8, 92);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(1176, 362);
            dgvUrunler.TabIndex = 0;
            dgvUrunler.SelectionChanged += dgvUrunler_SelectionChanged;
            // 
            // tabSatisIslemleri
            // 
            tabSatisIslemleri.Controls.Add(groupBox4);
            tabSatisIslemleri.Controls.Add(groupBox3);
            tabSatisIslemleri.Location = new Point(4, 26);
            tabSatisIslemleri.Name = "tabSatisIslemleri";
            tabSatisIslemleri.Padding = new Padding(3);
            tabSatisIslemleri.Size = new Size(1192, 670);
            tabSatisIslemleri.TabIndex = 1;
            tabSatisIslemleri.Text = "Satış İşlemleri";
            tabSatisIslemleri.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblToplamTutar);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(btnSatisYap);
            groupBox4.Controls.Add(txtMusteriAd);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtSatisMiktar);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cmbSatisUrun);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(8, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1176, 180);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satış Yap";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Green;
            lblToplamTutar.Location = new Point(950, 95);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(59, 25);
            lblToplamTutar.TabIndex = 8;
            lblToplamTutar.Text = "0,00₺";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(820, 97);
            label14.Name = "label14";
            label14.Size = new Size(110, 21);
            label14.TabIndex = 7;
            label14.Text = "Toplam Tutar:";
            // 
            // btnSatisYap
            // 
            btnSatisYap.BackColor = Color.Green;
            btnSatisYap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSatisYap.ForeColor = Color.White;
            btnSatisYap.Location = new Point(820, 130);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(330, 40);
            btnSatisYap.TabIndex = 6;
            btnSatisYap.Text = "SATIŞ YAP";
            btnSatisYap.UseVisualStyleBackColor = false;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // txtMusteriAd
            // 
            txtMusteriAd.Location = new Point(140, 120);
            txtMusteriAd.Name = "txtMusteriAd";
            txtMusteriAd.PlaceholderText = "Opsiyonel";
            txtMusteriAd.Size = new Size(300, 25);
            txtMusteriAd.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 123);
            label13.Name = "label13";
            label13.Size = new Size(81, 17);
            label13.TabIndex = 4;
            label13.Text = "Müşteri Adı:";
            // 
            // txtSatisMiktar
            // 
            txtSatisMiktar.Location = new Point(140, 80);
            txtSatisMiktar.Name = "txtSatisMiktar";
            txtSatisMiktar.Size = new Size(200, 25);
            txtSatisMiktar.TabIndex = 3;
            txtSatisMiktar.TextChanged += txtSatisMiktar_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 83);
            label12.Name = "label12";
            label12.Size = new Size(93, 17);
            label12.TabIndex = 2;
            label12.Text = "Satış Miktarı:";
            // 
            // cmbSatisUrun
            // 
            cmbSatisUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSatisUrun.FormattingEnabled = true;
            cmbSatisUrun.Location = new Point(140, 40);
            cmbSatisUrun.Name = "cmbSatisUrun";
            cmbSatisUrun.Size = new Size(400, 25);
            cmbSatisUrun.TabIndex = 1;
            cmbSatisUrun.SelectedIndexChanged += cmbSatisUrun_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 43);
            label11.Name = "label11";
            label11.Size = new Size(79, 17);
            label11.TabIndex = 0;
            label11.Text = "Ürün Seçin:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSatislar);
            groupBox3.Location = new Point(8, 192);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1176, 468);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Satış Geçmişi";
            // 
            // dgvSatislar
            // 
            dgvSatislar.AllowUserToAddRows = false;
            dgvSatislar.AllowUserToDeleteRows = false;
            dgvSatislar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSatislar.BackgroundColor = Color.White;
            dgvSatislar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatislar.Dock = DockStyle.Fill;
            dgvSatislar.Location = new Point(3, 21);
            dgvSatislar.Name = "dgvSatislar";
            dgvSatislar.ReadOnly = true;
            dgvSatislar.RowTemplate.Height = 25;
            dgvSatislar.Size = new Size(1170, 444);
            dgvSatislar.TabIndex = 0;
            // 
            // tabRaporlar
            // 
            tabRaporlar.Controls.Add(groupBox7);
            tabRaporlar.Controls.Add(groupBox6);
            tabRaporlar.Controls.Add(groupBox5);
            tabRaporlar.Location = new Point(4, 26);
            tabRaporlar.Name = "tabRaporlar";
            tabRaporlar.Size = new Size(1192, 670);
            tabRaporlar.TabIndex = 2;
            tabRaporlar.Text = "Raporlar ve İstatistikler";
            tabRaporlar.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dgvEnCokSatan);
            groupBox7.Controls.Add(label22);
            groupBox7.Location = new Point(620, 220);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(564, 440);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ürün Analizleri";
            // 
            // dgvEnCokSatan
            // 
            dgvEnCokSatan.AllowUserToAddRows = false;
            dgvEnCokSatan.AllowUserToDeleteRows = false;
            dgvEnCokSatan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnCokSatan.BackgroundColor = Color.White;
            dgvEnCokSatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnCokSatan.Location = new Point(15, 50);
            dgvEnCokSatan.Name = "dgvEnCokSatan";
            dgvEnCokSatan.ReadOnly = true;
            dgvEnCokSatan.RowTemplate.Height = 25;
            dgvEnCokSatan.Size = new Size(540, 380);
            dgvEnCokSatan.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(15, 25);
            label22.Name = "label22";
            label22.Size = new Size(138, 20);
            label22.TabIndex = 0;
            label22.Text = "En Çok Satanlar:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblToplamStokDegeri);
            groupBox6.Controls.Add(label21);
            groupBox6.Controls.Add(lblAylikCiro);
            groupBox6.Controls.Add(label19);
            groupBox6.Controls.Add(lblAylikSatisSayisi);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(lblGunlukCiro);
            groupBox6.Controls.Add(label20);
            groupBox6.Controls.Add(lblGunlukSatisSayisi);
            groupBox6.Controls.Add(label18);
            groupBox6.Location = new Point(8, 8);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1176, 200);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Genel İstatistikler";
            // 
            // lblToplamStokDegeri
            // 
            lblToplamStokDegeri.AutoSize = true;
            lblToplamStokDegeri.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamStokDegeri.ForeColor = Color.Purple;
            lblToplamStokDegeri.Location = new Point(850, 120);
            lblToplamStokDegeri.Name = "lblToplamStokDegeri";
            lblToplamStokDegeri.Size = new Size(91, 37);
            lblToplamStokDegeri.TabIndex = 9;
            lblToplamStokDegeri.Text = "0,00₺";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(850, 90);
            label21.Name = "label21";
            label21.Size = new Size(147, 20);
            label21.TabIndex = 8;
            label21.Text = "Toplam Stok Değeri:";
            // 
            // lblAylikCiro
            // 
            lblAylikCiro.AutoSize = true;
            lblAylikCiro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAylikCiro.ForeColor = Color.Green;
            lblAylikCiro.Location = new Point(450, 120);
            lblAylikCiro.Name = "lblAylikCiro";
            lblAylikCiro.Size = new Size(91, 37);
            lblAylikCiro.TabIndex = 7;
            lblAylikCiro.Text = "0,00₺";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(450, 90);
            label19.Name = "label19";
            label19.Size = new Size(79, 20);
            label19.TabIndex = 6;
            label19.Text = "Aylık Ciro:";
            // 
            // lblAylikSatisSayisi
            // 
            lblAylikSatisSayisi.AutoSize = true;
            lblAylikSatisSayisi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAylikSatisSayisi.ForeColor = Color.Blue;
            lblAylikSatisSayisi.Location = new Point(450, 50);
            lblAylikSatisSayisi.Name = "lblAylikSatisSayisi";
            lblAylikSatisSayisi.Size = new Size(33, 37);
            lblAylikSatisSayisi.TabIndex = 5;
            lblAylikSatisSayisi.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(450, 25);
            label17.Name = "label17";
            label17.Size = new Size(120, 20);
            label17.TabIndex = 4;
            label17.Text = "Aylık Satış Sayısı:";
            // 
            // lblGunlukCiro
            // 
            lblGunlukCiro.AutoSize = true;
            lblGunlukCiro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukCiro.ForeColor = Color.Green;
            lblGunlukCiro.Location = new Point(50, 120);
            lblGunlukCiro.Name = "lblGunlukCiro";
            lblGunlukCiro.Size = new Size(91, 37);
            lblGunlukCiro.TabIndex = 3;
            lblGunlukCiro.Text = "0,00₺";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(50, 90);
            label20.Name = "label20";
            label20.Size = new Size(94, 20);
            label20.TabIndex = 2;
            label20.Text = "Günlük Ciro:";
            // 
            // lblGunlukSatisSayisi
            // 
            lblGunlukSatisSayisi.AutoSize = true;
            lblGunlukSatisSayisi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSatisSayisi.ForeColor = Color.Blue;
            lblGunlukSatisSayisi.Location = new Point(50, 50);
            lblGunlukSatisSayisi.Name = "lblGunlukSatisSayisi";
            lblGunlukSatisSayisi.Size = new Size(33, 37);
            lblGunlukSatisSayisi.TabIndex = 1;
            lblGunlukSatisSayisi.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(50, 25);
            label18.Name = "label18";
            label18.Size = new Size(135, 20);
            label18.TabIndex = 0;
            label18.Text = "Günlük Satış Sayısı:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvKritikStok);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(dgvSonKullanma);
            groupBox5.Controls.Add(label15);
            groupBox5.Location = new Point(8, 220);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(600, 440);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Uyarılar";
            // 
            // dgvKritikStok
            // 
            dgvKritikStok.AllowUserToAddRows = false;
            dgvKritikStok.AllowUserToDeleteRows = false;
            dgvKritikStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKritikStok.BackgroundColor = Color.White;
            dgvKritikStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKritikStok.Location = new Point(15, 260);
            dgvKritikStok.Name = "dgvKritikStok";
            dgvKritikStok.ReadOnly = true;
            dgvKritikStok.RowTemplate.Height = 25;
            dgvKritikStok.Size = new Size(570, 170);
            dgvKritikStok.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(15, 235);
            label16.Name = "label16";
            label16.Size = new Size(180, 20);
            label16.TabIndex = 2;
            label16.Text = "Kritik Stok Seviyesinde:";
            // 
            // dgvSonKullanma
            // 
            dgvSonKullanma.AllowUserToAddRows = false;
            dgvSonKullanma.AllowUserToDeleteRows = false;
            dgvSonKullanma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonKullanma.BackgroundColor = Color.White;
            dgvSonKullanma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonKullanma.Location = new Point(15, 50);
            dgvSonKullanma.Name = "dgvSonKullanma";
            dgvSonKullanma.ReadOnly = true;
            dgvSonKullanma.RowTemplate.Height = 25;
            dgvSonKullanma.Size = new Size(570, 170);
            dgvSonKullanma.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.OrangeRed;
            label15.Location = new Point(15, 25);
            label15.Name = "label15";
            label15.Size = new Size(232, 20);
            label15.TabIndex = 0;
            label15.Text = "Son Kullanma Tarihi Yaklaşan:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manav Stok Yönetim Sistemi";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabStokYonetimi.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            tabSatisIslemleri.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).EndInit();
            tabRaporlar.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokSatan).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKritikStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSonKullanma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabStokYonetimi;
        private TabPage tabSatisIslemleri;
        private DataGridView dgvUrunler;
        private GroupBox groupBox1;
        private ComboBox cmbKategoriFiltre;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtUrunAd;
        private Label label2;
        private ComboBox cmbKategori;
        private Label label3;
        private TextBox txtBirimFiyat;
        private Label label4;
        private TextBox txtStokMiktar;
        private Label label5;
        private ComboBox cmbBirim;
        private Label label6;
        private DateTimePicker dtpSonKullanma;
        private TextBox txtTedarikci;
        private Label label8;
        private Label label7;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private TextBox txtArama;
        private Label label9;
        private Button btnAra;
        private GroupBox groupBox3;
        private DataGridView dgvSatislar;
        private GroupBox groupBox4;
        private ComboBox cmbSatisUrun;
        private Label label11;
        private TextBox txtSatisMiktar;
        private Label label12;
        private TextBox txtMusteriAd;
        private Label label13;
        private Button btnSatisYap;
        private Label lblToplamTutar;
        private Label label14;
        private TabPage tabRaporlar;
        private GroupBox groupBox5;
        private DataGridView dgvSonKullanma;
        private Label label15;
        private DataGridView dgvKritikStok;
        private Label label16;
        private GroupBox groupBox6;
        private Label lblGunlukSatisSayisi;
        private Label label18;
        private Label lblGunlukCiro;
        private Label label20;
        private Label lblAylikSatisSayisi;
        private Label label17;
        private Label lblAylikCiro;
        private Label label19;
        private Label lblToplamStokDegeri;
        private Label label21;
        private GroupBox groupBox7;
        private DataGridView dgvEnCokSatan;
        private Label label22;
    }
}
