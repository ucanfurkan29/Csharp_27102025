namespace _03_ATM_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Clean up any resources being used.
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
          lblBaslik = new Label();
  lblHesapNo = new Label();
  lblSifre = new Label();
            txtHesapNo = new TextBox();
       txtSifre = new TextBox();
    btnGiris = new Button();
          lblHata = new Label();
     SuspendLayout();
            // 
            // lblBaslik
     // 
  lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
   lblBaslik.ForeColor = Color.DarkBlue;
   lblBaslik.Location = new Point(200, 30);
     lblBaslik.Name = "lblBaslik";
       lblBaslik.Size = new Size(250, 32);
        lblBaslik.TabIndex = 0;
       lblBaslik.Text = "ATM SİSTEMİNE HOŞ GELDİNİZ";
        // 
     // lblHesapNo
        // 
     lblHesapNo.AutoSize = true;
     lblHesapNo.Font = new Font("Segoe UI", 12F);
        lblHesapNo.Location = new Point(150, 120);
            lblHesapNo.Name = "lblHesapNo";
          lblHesapNo.Size = new Size(100, 21);
        lblHesapNo.TabIndex = 1;
        lblHesapNo.Text = "Hesap Adı:";
            // 
      // lblSifre
         // 
            lblSifre.AutoSize = true;
    lblSifre.Font = new Font("Segoe UI", 12F);
    lblSifre.Location = new Point(150, 170);
       lblSifre.Name = "lblSifre";
        lblSifre.Size = new Size(50, 21);
    lblSifre.TabIndex = 2;
 lblSifre.Text = "Şifre:";
     // 
            // txtHesapNo
            // 
            txtHesapNo.Font = new Font("Segoe UI", 12F);
            txtHesapNo.Location = new Point(280, 117);
            txtHesapNo.Name = "txtHesapNo";
         txtHesapNo.Size = new Size(200, 29);
        txtHesapNo.TabIndex = 3;
            // 
  // txtSifre
      // 
    txtSifre.Font = new Font("Segoe UI", 12F);
         txtSifre.Location = new Point(280, 167);
            txtSifre.Name = "txtSifre";
     txtSifre.PasswordChar = '*';
   txtSifre.Size = new Size(200, 29);
            txtSifre.TabIndex = 4;
            // 
            // btnGiris
    // 
    btnGiris.BackColor = Color.Green;
         btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
     btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(280, 220);
 btnGiris.Name = "btnGiris";
 btnGiris.Size = new Size(200, 40);
        btnGiris.TabIndex = 5;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
          btnGiris.Click += btnGiris_Click;
            // 
    // lblHata
            // 
            lblHata.AutoSize = true;
     lblHata.Font = new Font("Segoe UI", 10F);
   lblHata.ForeColor = Color.Red;
            lblHata.Location = new Point(200, 280);
            lblHata.Name = "lblHata";
   lblHata.Size = new Size(0, 19);
            lblHata.TabIndex = 6;
       // 
        // Form1
       // 
 AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
    BackColor = Color.LightCyan;
       ClientSize = new Size(700, 400);
            Controls.Add(lblHata);
   Controls.Add(btnGiris);
            Controls.Add(txtSifre);
      Controls.Add(txtHesapNo);
       Controls.Add(lblSifre);
            Controls.Add(lblHesapNo);
          Controls.Add(lblBaslik);
            Name = "Form1";
       StartPosition = FormStartPosition.CenterScreen;
   Text = "ATM Giriş Ekranı";
   ResumeLayout(false);
            PerformLayout();
  }

     #endregion

      private Label lblBaslik;
 private Label lblHesapNo;
        private Label lblSifre;
        private TextBox txtHesapNo;
      private TextBox txtSifre;
        private Button btnGiris;
  private Label lblHata;
    }
}
