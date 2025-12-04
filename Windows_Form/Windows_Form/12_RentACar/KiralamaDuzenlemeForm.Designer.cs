namespace _12_RentACar
{
    partial class KiralamaDuzenlemeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_arac = new TextBox();
            txt_toplamSaat = new TextBox();
            txt_toplamTutar = new TextBox();
            dtp_baslaTarih = new DateTimePicker();
            dtp_baslaSaat = new DateTimePicker();
            dtp_bitisTarih = new DateTimePicker();
            dtp_bitisSaat = new DateTimePicker();
            btn_kaydet = new Button();
            btn_Hesapla = new Button();
            btn_iptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Araç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(11, 41);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 1;
            label2.Text = "Kiralama Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 70);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 108);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 150);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Toplam Saat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 183);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Toplam Tutar";
            // 
            // txt_arac
            // 
            txt_arac.Location = new Point(105, 6);
            txt_arac.Name = "txt_arac";
            txt_arac.ReadOnly = true;
            txt_arac.Size = new Size(180, 23);
            txt_arac.TabIndex = 6;
            // 
            // txt_toplamSaat
            // 
            txt_toplamSaat.Location = new Point(105, 147);
            txt_toplamSaat.Name = "txt_toplamSaat";
            txt_toplamSaat.ReadOnly = true;
            txt_toplamSaat.Size = new Size(100, 23);
            txt_toplamSaat.TabIndex = 7;
            // 
            // txt_toplamTutar
            // 
            txt_toplamTutar.Location = new Point(104, 183);
            txt_toplamTutar.Name = "txt_toplamTutar";
            txt_toplamTutar.ReadOnly = true;
            txt_toplamTutar.Size = new Size(100, 23);
            txt_toplamTutar.TabIndex = 8;
            // 
            // dtp_baslaTarih
            // 
            dtp_baslaTarih.Format = DateTimePickerFormat.Short;
            dtp_baslaTarih.Location = new Point(105, 70);
            dtp_baslaTarih.Name = "dtp_baslaTarih";
            dtp_baslaTarih.Size = new Size(87, 23);
            dtp_baslaTarih.TabIndex = 9;
            // 
            // dtp_baslaSaat
            // 
            dtp_baslaSaat.Format = DateTimePickerFormat.Time;
            dtp_baslaSaat.Location = new Point(198, 70);
            dtp_baslaSaat.Name = "dtp_baslaSaat";
            dtp_baslaSaat.Size = new Size(87, 23);
            dtp_baslaSaat.TabIndex = 10;
            // 
            // dtp_bitisTarih
            // 
            dtp_bitisTarih.Format = DateTimePickerFormat.Short;
            dtp_bitisTarih.Location = new Point(105, 100);
            dtp_bitisTarih.Name = "dtp_bitisTarih";
            dtp_bitisTarih.Size = new Size(87, 23);
            dtp_bitisTarih.TabIndex = 11;
            // 
            // dtp_bitisSaat
            // 
            dtp_bitisSaat.Format = DateTimePickerFormat.Time;
            dtp_bitisSaat.Location = new Point(198, 102);
            dtp_bitisSaat.Name = "dtp_bitisSaat";
            dtp_bitisSaat.Size = new Size(87, 23);
            dtp_bitisSaat.TabIndex = 12;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(105, 222);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(99, 23);
            btn_kaydet.TabIndex = 13;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_Hesapla
            // 
            btn_Hesapla.Location = new Point(210, 146);
            btn_Hesapla.Name = "btn_Hesapla";
            btn_Hesapla.Size = new Size(75, 23);
            btn_Hesapla.TabIndex = 14;
            btn_Hesapla.Text = "Hesapla";
            btn_Hesapla.UseVisualStyleBackColor = true;
            btn_Hesapla.Click += btn_Hesapla_Click;
            // 
            // btn_iptal
            // 
            btn_iptal.Location = new Point(210, 183);
            btn_iptal.Name = "btn_iptal";
            btn_iptal.Size = new Size(75, 23);
            btn_iptal.TabIndex = 15;
            btn_iptal.Text = "İptal";
            btn_iptal.UseVisualStyleBackColor = true;
            btn_iptal.Click += btn_iptal_Click;
            // 
            // KiralamaDuzenlemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1916729901_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(511, 267);
            Controls.Add(btn_iptal);
            Controls.Add(btn_Hesapla);
            Controls.Add(btn_kaydet);
            Controls.Add(dtp_bitisSaat);
            Controls.Add(dtp_bitisTarih);
            Controls.Add(dtp_baslaSaat);
            Controls.Add(dtp_baslaTarih);
            Controls.Add(txt_toplamTutar);
            Controls.Add(txt_toplamSaat);
            Controls.Add(txt_arac);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KiralamaDuzenlemeForm";
            Text = "KiralamaDuzenlemeForm";
            Load += KiralamaDuzenlemeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_arac;
        private TextBox txt_toplamSaat;
        private TextBox txt_toplamTutar;
        private DateTimePicker dtp_baslaTarih;
        private DateTimePicker dtp_baslaSaat;
        private DateTimePicker dtp_bitisTarih;
        private DateTimePicker dtp_bitisSaat;
        private Button btn_kaydet;
        private Button btn_Hesapla;
        private Button btn_iptal;
    }
}