namespace _12_RentACar
{
    partial class ArabaForm
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
            cmb_Listele = new ComboBox();
            btn_arabaGetir = new Button();
            btn_kiralamalar = new Button();
            dtg_arabalar = new DataGridView();
            groupBox1 = new GroupBox();
            btn_hesapla = new Button();
            btn_kirala = new Button();
            txt_toplamTutar = new TextBox();
            txt_toplamSaat = new TextBox();
            dtp_tSaat = new DateTimePicker();
            dtp_tTarih = new DateTimePicker();
            dtp_kSaat = new DateTimePicker();
            dtp_kTarih = new DateTimePicker();
            txt_kAraba = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_arabalar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Arabalar";
            // 
            // cmb_Listele
            // 
            cmb_Listele.FormattingEnabled = true;
            cmb_Listele.Location = new Point(80, 30);
            cmb_Listele.Name = "cmb_Listele";
            cmb_Listele.Size = new Size(130, 23);
            cmb_Listele.TabIndex = 1;
            // 
            // btn_arabaGetir
            // 
            btn_arabaGetir.Location = new Point(80, 59);
            btn_arabaGetir.Name = "btn_arabaGetir";
            btn_arabaGetir.Size = new Size(130, 23);
            btn_arabaGetir.TabIndex = 2;
            btn_arabaGetir.Text = "Araba Getir";
            btn_arabaGetir.UseVisualStyleBackColor = true;
            btn_arabaGetir.Click += btn_arabaGetir_Click;
            // 
            // btn_kiralamalar
            // 
            btn_kiralamalar.Location = new Point(80, 88);
            btn_kiralamalar.Name = "btn_kiralamalar";
            btn_kiralamalar.Size = new Size(130, 23);
            btn_kiralamalar.TabIndex = 3;
            btn_kiralamalar.Text = "Kiralamalar";
            btn_kiralamalar.UseVisualStyleBackColor = true;
            // 
            // dtg_arabalar
            // 
            dtg_arabalar.BackgroundColor = SystemColors.ButtonHighlight;
            dtg_arabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_arabalar.Location = new Point(12, 117);
            dtg_arabalar.Name = "dtg_arabalar";
            dtg_arabalar.Size = new Size(791, 531);
            dtg_arabalar.TabIndex = 4;
            dtg_arabalar.DoubleClick += dtg_arabalar_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_hesapla);
            groupBox1.Controls.Add(btn_kirala);
            groupBox1.Controls.Add(txt_toplamTutar);
            groupBox1.Controls.Add(txt_toplamSaat);
            groupBox1.Controls.Add(dtp_tSaat);
            groupBox1.Controls.Add(dtp_tTarih);
            groupBox1.Controls.Add(dtp_kSaat);
            groupBox1.Controls.Add(dtp_kTarih);
            groupBox1.Controls.Add(txt_kAraba);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(809, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 640);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Yöntemi";
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(278, 386);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(90, 37);
            btn_hesapla.TabIndex = 13;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            // 
            // btn_kirala
            // 
            btn_kirala.Location = new Point(112, 386);
            btn_kirala.Name = "btn_kirala";
            btn_kirala.Size = new Size(101, 37);
            btn_kirala.TabIndex = 12;
            btn_kirala.Text = "Kirala";
            btn_kirala.UseVisualStyleBackColor = true;
            // 
            // txt_toplamTutar
            // 
            txt_toplamTutar.Location = new Point(138, 293);
            txt_toplamTutar.Name = "txt_toplamTutar";
            txt_toplamTutar.ReadOnly = true;
            txt_toplamTutar.Size = new Size(160, 29);
            txt_toplamTutar.TabIndex = 11;
            // 
            // txt_toplamSaat
            // 
            txt_toplamSaat.Location = new Point(138, 233);
            txt_toplamSaat.Name = "txt_toplamSaat";
            txt_toplamSaat.ReadOnly = true;
            txt_toplamSaat.Size = new Size(160, 29);
            txt_toplamSaat.TabIndex = 10;
            // 
            // dtp_tSaat
            // 
            dtp_tSaat.Format = DateTimePickerFormat.Time;
            dtp_tSaat.Location = new Point(309, 171);
            dtp_tSaat.Name = "dtp_tSaat";
            dtp_tSaat.ShowUpDown = true;
            dtp_tSaat.Size = new Size(114, 29);
            dtp_tSaat.TabIndex = 9;
            // 
            // dtp_tTarih
            // 
            dtp_tTarih.Format = DateTimePickerFormat.Short;
            dtp_tTarih.Location = new Point(138, 169);
            dtp_tTarih.Name = "dtp_tTarih";
            dtp_tTarih.Size = new Size(155, 29);
            dtp_tTarih.TabIndex = 8;
            // 
            // dtp_kSaat
            // 
            dtp_kSaat.Format = DateTimePickerFormat.Time;
            dtp_kSaat.Location = new Point(309, 118);
            dtp_kSaat.Name = "dtp_kSaat";
            dtp_kSaat.ShowUpDown = true;
            dtp_kSaat.Size = new Size(114, 29);
            dtp_kSaat.TabIndex = 7;
            // 
            // dtp_kTarih
            // 
            dtp_kTarih.Format = DateTimePickerFormat.Short;
            dtp_kTarih.Location = new Point(138, 118);
            dtp_kTarih.Name = "dtp_kTarih";
            dtp_kTarih.Size = new Size(154, 29);
            dtp_kTarih.TabIndex = 6;
            // 
            // txt_kAraba
            // 
            txt_kAraba.Location = new Point(138, 47);
            txt_kAraba.Name = "txt_kAraba";
            txt_kAraba.ReadOnly = true;
            txt_kAraba.Size = new Size(285, 29);
            txt_kAraba.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 300);
            label6.Name = "label6";
            label6.Size = new Size(124, 22);
            label6.TabIndex = 4;
            label6.Text = "Toplam Tutar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 240);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 3;
            label5.Text = "Toplam Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Location = new Point(0, 176);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 2;
            label4.Text = "Teslim Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Location = new Point(0, 118);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 1;
            label3.Text = "Kiralama Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 0;
            label2.Text = "Araç:";
            // 
            // ArabaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bertan_rent_acar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1293, 711);
            Controls.Add(groupBox1);
            Controls.Add(dtg_arabalar);
            Controls.Add(btn_kiralamalar);
            Controls.Add(btn_arabaGetir);
            Controls.Add(cmb_Listele);
            Controls.Add(label1);
            Name = "ArabaForm";
            Text = "ArabaForm";
            Load += ArabaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_arabalar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_Listele;
        private Button btn_arabaGetir;
        private Button btn_kiralamalar;
        private DataGridView dtg_arabalar;
        private GroupBox groupBox1;
        private Label label2;
        private Button btn_hesapla;
        private Button btn_kirala;
        private TextBox txt_toplamTutar;
        private TextBox txt_toplamSaat;
        private DateTimePicker dtp_tSaat;
        private DateTimePicker dtp_tTarih;
        private DateTimePicker dtp_kSaat;
        private DateTimePicker dtp_kTarih;
        private TextBox txt_kAraba;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}