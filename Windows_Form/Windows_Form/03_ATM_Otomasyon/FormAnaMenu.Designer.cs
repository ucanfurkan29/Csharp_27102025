namespace _03_ATM_Otomasyon
{
    partial class FormAnaMenu
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
       lblBaslik = new Label();
  lblBakiyeBaslik = new Label();
        lblBakiyeTutar = new Label();
       btnParaYatir = new Button();
   btnParaCek = new Button();
       btnParaGonder = new Button();
       btnKartIade = new Button();
       panelBakiye = new Panel();
  panelIslemler = new Panel();
 panelBakiye.SuspendLayout();
     panelIslemler.SuspendLayout();
        SuspendLayout();
      // 
            // lblBaslik
      // 
     lblBaslik.AutoSize = true;
      lblBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
   lblBaslik.ForeColor = Color.DarkBlue;
 lblBaslik.Location = new Point(250, 20);
   lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(200, 37);
     lblBaslik.TabIndex = 0;
   lblBaslik.Text = "ANA MENÜ";
        // 
     // lblBakiyeBaslik
  // 
       lblBakiyeBaslik.AutoSize = true;
    lblBakiyeBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
          lblBakiyeBaslik.ForeColor = Color.DarkGreen;
  lblBakiyeBaslik.Location = new Point(15, 15);
            lblBakiyeBaslik.Name = "lblBakiyeBaslik";
   lblBakiyeBaslik.Size = new Size(156, 25);
     lblBakiyeBaslik.TabIndex = 0;
       lblBakiyeBaslik.Text = "Toplam Bakiye:";
      // 
     // lblBakiyeTutar
 // 
 lblBakiyeTutar.AutoSize = true;
    lblBakiyeTutar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
  lblBakiyeTutar.ForeColor = Color.Green;
       lblBakiyeTutar.Location = new Point(15, 50);
            lblBakiyeTutar.Name = "lblBakiyeTutar";
       lblBakiyeTutar.Size = new Size(100, 32);
     lblBakiyeTutar.TabIndex = 1;
 lblBakiyeTutar.Text = "0,00 ?";
       // 
  // panelBakiye
            // 
    panelBakiye.BackColor = Color.LightGreen;
            panelBakiye.BorderStyle = BorderStyle.FixedSingle;
            panelBakiye.Controls.Add(lblBakiyeBaslik);
            panelBakiye.Controls.Add(lblBakiyeTutar);
  panelBakiye.Location = new Point(200, 80);
     panelBakiye.Name = "panelBakiye";
       panelBakiye.Size = new Size(300, 100);
        panelBakiye.TabIndex = 1;
// 
         // panelIslemler
        // 
   panelIslemler.BackColor = Color.AliceBlue;
       panelIslemler.BorderStyle = BorderStyle.FixedSingle;
    panelIslemler.Controls.Add(btnParaYatir);
panelIslemler.Controls.Add(btnParaCek);
    panelIslemler.Controls.Add(btnParaGonder);
 panelIslemler.Controls.Add(btnKartIade);
  panelIslemler.Location = new Point(150, 210);
            panelIslemler.Name = "panelIslemler";
       panelIslemler.Size = new Size(400, 240);
    panelIslemler.TabIndex = 2;
    // 
       // btnParaYatir
   // 
       btnParaYatir.BackColor = Color.LightBlue;
       btnParaYatir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnParaYatir.Location = new Point(30, 20);
         btnParaYatir.Name = "btnParaYatir";
 btnParaYatir.Size = new Size(340, 45);
    btnParaYatir.TabIndex = 0;
   btnParaYatir.Text = "?? PARA YATIR";
  btnParaYatir.UseVisualStyleBackColor = false;
         btnParaYatir.Click += btnParaYatir_Click;
     // 
     // btnParaCek
            // 
       btnParaCek.BackColor = Color.LightCoral;
     btnParaCek.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnParaCek.Location = new Point(30, 75);
            btnParaCek.Name = "btnParaCek";
    btnParaCek.Size = new Size(340, 45);
            btnParaCek.TabIndex = 1;
  btnParaCek.Text = "?? PARA ÇEK";
     btnParaCek.UseVisualStyleBackColor = false;
   btnParaCek.Click += btnParaCek_Click;
      // 
  // btnParaGonder
   // 
     btnParaGonder.BackColor = Color.LightYellow;
 btnParaGonder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
   btnParaGonder.Location = new Point(30, 130);
    btnParaGonder.Name = "btnParaGonder";
       btnParaGonder.Size = new Size(340, 45);
        btnParaGonder.TabIndex = 2;
  btnParaGonder.Text = "?? PARA GÖNDER";
        btnParaGonder.UseVisualStyleBackColor = false;
            btnParaGonder.Click += btnParaGonder_Click;
   // 
   // btnKartIade
  // 
       btnKartIade.BackColor = Color.Orange;
 btnKartIade.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnKartIade.Location = new Point(30, 185);
      btnKartIade.Name = "btnKartIade";
     btnKartIade.Size = new Size(340, 45);
     btnKartIade.TabIndex = 3;
    btnKartIade.Text = "?? KART ÝADE / ÇIKIÞ";
    btnKartIade.UseVisualStyleBackColor = false;
       btnKartIade.Click += btnKartIade_Click;
 // 
 // FormAnaMenu
   // 
     AutoScaleDimensions = new SizeF(7F, 15F);
   AutoScaleMode = AutoScaleMode.Font;
     BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 500);
   Controls.Add(panelIslemler);
       Controls.Add(panelBakiye);
       Controls.Add(lblBaslik);
  Name = "FormAnaMenu";
StartPosition = FormStartPosition.CenterScreen;
      Text = "ATM Ana Menü";
     panelBakiye.ResumeLayout(false);
            panelBakiye.PerformLayout();
    panelIslemler.ResumeLayout(false);
       ResumeLayout(false);
      PerformLayout();
 }

        #endregion

        private Label lblBaslik;
    private Label lblBakiyeBaslik;
     private Label lblBakiyeTutar;
        private Button btnParaYatir;
    private Button btnParaCek;
    private Button btnParaGonder;
    private Button btnKartIade;
  private Panel panelBakiye;
        private Panel panelIslemler;
    }
}
