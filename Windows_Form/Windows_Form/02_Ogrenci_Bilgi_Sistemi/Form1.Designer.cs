namespace _02_Ogrenci_Bilgi_Sistemi
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
            lblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblOgrenciNo = new Label();
            txtOgrenciNo = new TextBox();
            lblBolum = new Label();
            txtBolum = new TextBox();
            lblDogumTarihi = new Label();
            dtpDogumTarihi = new DateTimePicker();
            btnKaydet = new Button();
            btnListele = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F);
            lblAd.Location = new Point(50, 50);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 19);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10F);
            txtAd.Location = new Point(180, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 25);
            txtAd.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10F);
            lblSoyad.Location = new Point(50, 90);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(49, 19);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10F);
            txtSoyad.Location = new Point(180, 87);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 25);
            txtSoyad.TabIndex = 3;
            // 
            // lblOgrenciNo
            // 
            lblOgrenciNo.AutoSize = true;
            lblOgrenciNo.Font = new Font("Segoe UI", 10F);
            lblOgrenciNo.Location = new Point(50, 130);
            lblOgrenciNo.Name = "lblOgrenciNo";
            lblOgrenciNo.Size = new Size(82, 19);
            lblOgrenciNo.TabIndex = 4;
            lblOgrenciNo.Text = "Öğrenci No:";
            // 
            // txtOgrenciNo
            // 
            txtOgrenciNo.Font = new Font("Segoe UI", 10F);
            txtOgrenciNo.Location = new Point(180, 127);
            txtOgrenciNo.Name = "txtOgrenciNo";
            txtOgrenciNo.Size = new Size(250, 25);
            txtOgrenciNo.TabIndex = 5;
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Font = new Font("Segoe UI", 10F);
            lblBolum.Location = new Point(50, 170);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(51, 19);
            lblBolum.TabIndex = 6;
            lblBolum.Text = "Bölüm:";
            // 
            // txtBolum
            // 
            txtBolum.Font = new Font("Segoe UI", 10F);
            txtBolum.Location = new Point(180, 167);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(250, 25);
            txtBolum.TabIndex = 7;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Segoe UI", 10F);
            lblDogumTarihi.Location = new Point(50, 210);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(93, 19);
            lblDogumTarihi.TabIndex = 8;
            lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 10F);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(180, 207);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 25);
            dtpDogumTarihi.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 122, 204);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(180, 260);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 40);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(46, 204, 113);
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(310, 260);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(120, 40);
            btnListele.TabIndex = 11;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnListele);
            Controls.Add(btnKaydet);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(lblDogumTarihi);
            Controls.Add(txtBolum);
            Controls.Add(lblBolum);
            Controls.Add(txtOgrenciNo);
            Controls.Add(lblOgrenciNo);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgi Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
    }
}
