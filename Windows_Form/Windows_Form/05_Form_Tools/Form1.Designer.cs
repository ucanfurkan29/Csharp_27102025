namespace _05_Form_Tools
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
            chkKetcap = new CheckBox();
            chkMayonez = new CheckBox();
            chkHardal = new CheckBox();
            label1 = new Label();
            btnHesapla = new Button();
            lblOzet = new Label();
            groupBox1 = new GroupBox();
            rbAyniGun = new RadioButton();
            rbHizli = new RadioButton();
            rbStandart = new RadioButton();
            btnOnayla = new Button();
            cmbSehirler = new ComboBox();
            btnGoster = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnAyarlarAc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // chkKetcap
            // 
            chkKetcap.AutoSize = true;
            chkKetcap.Location = new Point(12, 65);
            chkKetcap.Name = "chkKetcap";
            chkKetcap.Size = new Size(85, 19);
            chkKetcap.TabIndex = 0;
            chkKetcap.Text = "Ketçap (2₺)";
            chkKetcap.UseVisualStyleBackColor = true;
            // 
            // chkMayonez
            // 
            chkMayonez.AutoSize = true;
            chkMayonez.Location = new Point(12, 90);
            chkMayonez.Name = "chkMayonez";
            chkMayonez.Size = new Size(97, 19);
            chkMayonez.TabIndex = 1;
            chkMayonez.Text = "Mayonez (3₺)";
            chkMayonez.UseVisualStyleBackColor = true;
            // 
            // chkHardal
            // 
            chkHardal.AutoSize = true;
            chkHardal.Location = new Point(12, 115);
            chkHardal.Name = "chkHardal";
            chkHardal.Size = new Size(84, 19);
            chkHardal.TabIndex = 2;
            chkHardal.Text = "Hardal (4₺)";
            chkHardal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Ekstra Malzeme Seçin";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(16, 140);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(93, 34);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Sipariş Özeti";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblOzet
            // 
            lblOzet.BorderStyle = BorderStyle.FixedSingle;
            lblOzet.Location = new Point(130, 41);
            lblOzet.Name = "lblOzet";
            lblOzet.Size = new Size(136, 133);
            lblOzet.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAyniGun);
            groupBox1.Controls.Add(rbHizli);
            groupBox1.Controls.Add(rbStandart);
            groupBox1.Controls.Add(btnOnayla);
            groupBox1.Location = new Point(12, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 98);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kargo Seçeneği";
            // 
            // rbAyniGun
            // 
            rbAyniGun.AutoSize = true;
            rbAyniGun.Location = new Point(21, 70);
            rbAyniGun.Name = "rbAyniGun";
            rbAyniGun.Size = new Size(103, 19);
            rbAyniGun.TabIndex = 2;
            rbAyniGun.TabStop = true;
            rbAyniGun.Text = "Aynı Gün (45₺)";
            rbAyniGun.UseVisualStyleBackColor = true;
            // 
            // rbHizli
            // 
            rbHizli.AutoSize = true;
            rbHizli.Location = new Point(21, 45);
            rbHizli.Name = "rbHizli";
            rbHizli.Size = new Size(77, 19);
            rbHizli.TabIndex = 1;
            rbHizli.TabStop = true;
            rbHizli.Text = "Hizlı (30₺)";
            rbHizli.UseVisualStyleBackColor = true;
            // 
            // rbStandart
            // 
            rbStandart.AutoSize = true;
            rbStandart.Location = new Point(21, 20);
            rbStandart.Name = "rbStandart";
            rbStandart.Size = new Size(98, 19);
            rbStandart.TabIndex = 0;
            rbStandart.TabStop = true;
            rbStandart.Text = "Standart (15₺)";
            rbStandart.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(156, 38);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(90, 33);
            btnOnayla.TabIndex = 7;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // cmbSehirler
            // 
            cmbSehirler.FormattingEnabled = true;
            cmbSehirler.Location = new Point(35, 33);
            cmbSehirler.Name = "cmbSehirler";
            cmbSehirler.Size = new Size(121, 23);
            cmbSehirler.TabIndex = 8;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(48, 62);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(97, 23);
            btnGoster.TabIndex = 9;
            btnGoster.Text = "Seçimi Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGoster);
            groupBox2.Controls.Add(cmbSehirler);
            groupBox2.Location = new Point(301, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şehir Seçimi";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblOzet);
            groupBox3.Controls.Add(chkKetcap);
            groupBox3.Controls.Add(chkMayonez);
            groupBox3.Controls.Add(chkHardal);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnHesapla);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 194);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sipariş";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAyarlarAc);
            groupBox4.Location = new Point(301, 127);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ayarlar";
            // 
            // btnAyarlarAc
            // 
            btnAyarlarAc.Location = new Point(62, 41);
            btnAyarlarAc.Name = "btnAyarlarAc";
            btnAyarlarAc.Size = new Size(75, 23);
            btnAyarlarAc.TabIndex = 0;
            btnAyarlarAc.Text = "Ayarlar";
            btnAyarlarAc.UseVisualStyleBackColor = true;
            btnAyarlarAc.Click += btnAyarlarAc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkKetcap;
        private CheckBox chkMayonez;
        private CheckBox chkHardal;
        private Label label1;
        private Button btnHesapla;
        private Label lblOzet;
        private GroupBox groupBox1;
        private RadioButton rbAyniGun;
        private RadioButton rbHizli;
        private RadioButton rbStandart;
        private Button btnOnayla;
        private ComboBox cmbSehirler;
        private Button btnGoster;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnAyarlarAc;
    }
}
