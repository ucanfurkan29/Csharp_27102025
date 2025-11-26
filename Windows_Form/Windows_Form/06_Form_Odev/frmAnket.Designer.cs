namespace _06_Form_Odev
{
    partial class frmAnket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chkHesapMakinesi = new CheckBox();
            chkAnket = new CheckBox();
            groupBox3 = new GroupBox();
            rbAydabir = new RadioButton();
            rbHergun = new RadioButton();
            rbHaftadabir = new RadioButton();
            groupBox4 = new GroupBox();
            label2 = new Label();
            cmbPuan = new ComboBox();
            btnAnketiGonder = new Button();
            btnFullKapat = new Button();
            btnSayfaKapat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(125, 33);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(148, 23);
            txtAdSoyad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Ad-Soyad Giriniz:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkHesapMakinesi);
            groupBox2.Controls.Add(chkAnket);
            groupBox2.Location = new Point(34, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Uygulamamızda En Sevdiğiniz Özellik";
            // 
            // chkHesapMakinesi
            // 
            chkHesapMakinesi.AutoSize = true;
            chkHesapMakinesi.Location = new Point(18, 62);
            chkHesapMakinesi.Name = "chkHesapMakinesi";
            chkHesapMakinesi.Size = new Size(109, 19);
            chkHesapMakinesi.TabIndex = 1;
            chkHesapMakinesi.Text = "Hesap Makinesi";
            chkHesapMakinesi.UseVisualStyleBackColor = true;
            // 
            // chkAnket
            // 
            chkAnket.AutoSize = true;
            chkAnket.Location = new Point(18, 37);
            chkAnket.Name = "chkAnket";
            chkAnket.Size = new Size(102, 19);
            chkAnket.TabIndex = 0;
            chkAnket.Text = "Anket Modülü";
            chkAnket.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbAydabir);
            groupBox3.Controls.Add(rbHergun);
            groupBox3.Controls.Add(rbHaftadabir);
            groupBox3.Location = new Point(354, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(299, 127);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Uygulamayı Ne Sıklıkla Kullanıyorsun";
            // 
            // rbAydabir
            // 
            rbAydabir.AutoSize = true;
            rbAydabir.Location = new Point(24, 86);
            rbAydabir.Name = "rbAydabir";
            rbAydabir.Size = new Size(108, 19);
            rbAydabir.TabIndex = 2;
            rbAydabir.TabStop = true;
            rbAydabir.Text = "Ayda Birkaç Kez";
            rbAydabir.UseVisualStyleBackColor = true;
            // 
            // rbHergun
            // 
            rbHergun.AutoSize = true;
            rbHergun.Location = new Point(24, 36);
            rbHergun.Name = "rbHergun";
            rbHergun.Size = new Size(69, 19);
            rbHergun.TabIndex = 0;
            rbHergun.TabStop = true;
            rbHergun.Text = "Her Gün";
            rbHergun.UseVisualStyleBackColor = true;
            // 
            // rbHaftadabir
            // 
            rbHaftadabir.AutoSize = true;
            rbHaftadabir.Location = new Point(24, 61);
            rbHaftadabir.Name = "rbHaftadabir";
            rbHaftadabir.Size = new Size(123, 19);
            rbHaftadabir.TabIndex = 1;
            rbHaftadabir.TabStop = true;
            rbHaftadabir.Text = "Haftada Birkaç Kez";
            rbHaftadabir.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cmbPuan);
            groupBox4.Location = new Point(354, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(299, 127);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Genel Değerlendirme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Puanınız";
            // 
            // cmbPuan
            // 
            cmbPuan.FormattingEnabled = true;
            cmbPuan.Location = new Point(120, 58);
            cmbPuan.Name = "cmbPuan";
            cmbPuan.Size = new Size(121, 23);
            cmbPuan.TabIndex = 0;
            // 
            // btnAnketiGonder
            // 
            btnAnketiGonder.Location = new Point(269, 358);
            btnAnketiGonder.Name = "btnAnketiGonder";
            btnAnketiGonder.Size = new Size(140, 40);
            btnAnketiGonder.TabIndex = 4;
            btnAnketiGonder.Text = "Anket Gönder";
            btnAnketiGonder.UseVisualStyleBackColor = true;
            btnAnketiGonder.Click += btnAnketiGonder_Click;
            // 
            // btnFullKapat
            // 
            btnFullKapat.Location = new Point(576, 386);
            btnFullKapat.Name = "btnFullKapat";
            btnFullKapat.Size = new Size(99, 23);
            btnFullKapat.TabIndex = 5;
            btnFullKapat.Text = "Full Kapat";
            btnFullKapat.UseVisualStyleBackColor = true;
            btnFullKapat.Click += btnFullKapat_Click;
            // 
            // btnSayfaKapat
            // 
            btnSayfaKapat.Location = new Point(576, 415);
            btnSayfaKapat.Name = "btnSayfaKapat";
            btnSayfaKapat.Size = new Size(99, 23);
            btnSayfaKapat.TabIndex = 6;
            btnSayfaKapat.Text = "Sayfa Kapat";
            btnSayfaKapat.UseVisualStyleBackColor = true;
            btnSayfaKapat.Click += btnSayfaKapat_Click;
            // 
            // frmAnket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(btnSayfaKapat);
            Controls.Add(btnFullKapat);
            Controls.Add(btnAnketiGonder);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmAnket";
            Text = "Anket";
            Load += frmAnket_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtAdSoyad;
        private Label label1;
        private Button btnAnketiGonder;
        private CheckBox chkHesapMakinesi;
        private CheckBox chkAnket;
        private RadioButton rbAydabir;
        private RadioButton rbHergun;
        private RadioButton rbHaftadabir;
        private Label label2;
        private ComboBox cmbPuan;
        private Button btnFullKapat;
        private Button btnSayfaKapat;
    }
}