namespace _07_Sekmeli_Stok_Yonetimi
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
            TabControl = new TabControl();
            tabPageUrunListesi = new TabPage();
            label2 = new Label();
            label1 = new Label();
            lblUrunAdi = new Label();
            lblUrunId = new Label();
            lstUrunler = new ListBox();
            tabPageUrunEkle = new TabPage();
            btnUrunEkle = new Button();
            txtYeniUrunAdi = new TextBox();
            txtYeniUrunId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TabControl.SuspendLayout();
            tabPageUrunListesi.SuspendLayout();
            tabPageUrunEkle.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPageUrunListesi);
            TabControl.Controls.Add(tabPageUrunEkle);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(776, 426);
            TabControl.TabIndex = 0;
            // 
            // tabPageUrunListesi
            // 
            tabPageUrunListesi.Controls.Add(label2);
            tabPageUrunListesi.Controls.Add(label1);
            tabPageUrunListesi.Controls.Add(lblUrunAdi);
            tabPageUrunListesi.Controls.Add(lblUrunId);
            tabPageUrunListesi.Controls.Add(lstUrunler);
            tabPageUrunListesi.Location = new Point(4, 24);
            tabPageUrunListesi.Name = "tabPageUrunListesi";
            tabPageUrunListesi.Padding = new Padding(3);
            tabPageUrunListesi.Size = new Size(768, 398);
            tabPageUrunListesi.TabIndex = 0;
            tabPageUrunListesi.Text = "Ürün Listesi";
            tabPageUrunListesi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(474, 177);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 4;
            label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(474, 46);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 3;
            label1.Text = "Ürün ID:";
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Font = new Font("Segoe UI", 16F);
            lblUrunAdi.Location = new Point(580, 177);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(0, 30);
            lblUrunAdi.TabIndex = 2;
            // 
            // lblUrunId
            // 
            lblUrunId.AutoSize = true;
            lblUrunId.Font = new Font("Segoe UI", 16F);
            lblUrunId.Location = new Point(572, 46);
            lblUrunId.Name = "lblUrunId";
            lblUrunId.Size = new Size(0, 30);
            lblUrunId.TabIndex = 1;
            // 
            // lstUrunler
            // 
            lstUrunler.FormattingEnabled = true;
            lstUrunler.ItemHeight = 15;
            lstUrunler.Location = new Point(6, 10);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(462, 379);
            lstUrunler.TabIndex = 0;
            lstUrunler.SelectedIndexChanged += lstUrunler_SelectedIndexChanged;
            // 
            // tabPageUrunEkle
            // 
            tabPageUrunEkle.Controls.Add(btnUrunEkle);
            tabPageUrunEkle.Controls.Add(txtYeniUrunAdi);
            tabPageUrunEkle.Controls.Add(txtYeniUrunId);
            tabPageUrunEkle.Controls.Add(label4);
            tabPageUrunEkle.Controls.Add(label3);
            tabPageUrunEkle.Location = new Point(4, 24);
            tabPageUrunEkle.Name = "tabPageUrunEkle";
            tabPageUrunEkle.Padding = new Padding(3);
            tabPageUrunEkle.Size = new Size(768, 398);
            tabPageUrunEkle.TabIndex = 1;
            tabPageUrunEkle.Text = "Yeni Ürün Ekle";
            tabPageUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Font = new Font("Segoe UI", 16F);
            btnUrunEkle.Location = new Point(266, 257);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(133, 64);
            btnUrunEkle.TabIndex = 4;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // txtYeniUrunAdi
            // 
            txtYeniUrunAdi.Location = new Point(327, 194);
            txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            txtYeniUrunAdi.Size = new Size(124, 23);
            txtYeniUrunAdi.TabIndex = 3;
            // 
            // txtYeniUrunId
            // 
            txtYeniUrunId.Location = new Point(327, 127);
            txtYeniUrunId.Name = "txtYeniUrunId";
            txtYeniUrunId.Size = new Size(124, 23);
            txtYeniUrunId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(192, 189);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 1;
            label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(192, 118);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 0;
            label3.Text = "Ürün ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            tabPageUrunListesi.ResumeLayout(false);
            tabPageUrunListesi.PerformLayout();
            tabPageUrunEkle.ResumeLayout(false);
            tabPageUrunEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPageUrunListesi;
        private Label lblUrunAdi;
        private Label lblUrunId;
        private ListBox lstUrunler;
        private TabPage tabPageUrunEkle;
        private Label label2;
        private Label label1;
        private Button btnUrunEkle;
        private TextBox txtYeniUrunAdi;
        private TextBox txtYeniUrunId;
        private Label label4;
        private Label label3;
    }
}
