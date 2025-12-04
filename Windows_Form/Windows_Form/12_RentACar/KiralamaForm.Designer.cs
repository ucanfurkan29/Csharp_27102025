namespace _12_RentACar
{
    partial class KiralamaForm
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
            dtg_kiralamalar = new DataGridView();
            btn_yeniKiralama = new Button();
            btn_kiralamaDuzenle = new Button();
            btn_kiralamaSil = new Button();
            btn_kapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_kiralamalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Kiralama İşlemleri";
            // 
            // dtg_kiralamalar
            // 
            dtg_kiralamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kiralamalar.Location = new Point(12, 27);
            dtg_kiralamalar.Name = "dtg_kiralamalar";
            dtg_kiralamalar.Size = new Size(776, 420);
            dtg_kiralamalar.TabIndex = 1;
            dtg_kiralamalar.SelectionChanged += dtg_kiralamalar_SelectionChanged;
            // 
            // btn_yeniKiralama
            // 
            btn_yeniKiralama.Location = new Point(1, 453);
            btn_yeniKiralama.Name = "btn_yeniKiralama";
            btn_yeniKiralama.Size = new Size(100, 39);
            btn_yeniKiralama.TabIndex = 2;
            btn_yeniKiralama.Text = "Yeni Kiralama";
            btn_yeniKiralama.UseVisualStyleBackColor = true;
            // 
            // btn_kiralamaDuzenle
            // 
            btn_kiralamaDuzenle.Location = new Point(119, 453);
            btn_kiralamaDuzenle.Name = "btn_kiralamaDuzenle";
            btn_kiralamaDuzenle.Size = new Size(100, 39);
            btn_kiralamaDuzenle.TabIndex = 2;
            btn_kiralamaDuzenle.Text = "Düzenle";
            btn_kiralamaDuzenle.UseVisualStyleBackColor = true;
            btn_kiralamaDuzenle.Click += btn_kiralamaDuzenle_Click;
            // 
            // btn_kiralamaSil
            // 
            btn_kiralamaSil.Location = new Point(239, 453);
            btn_kiralamaSil.Name = "btn_kiralamaSil";
            btn_kiralamaSil.Size = new Size(100, 39);
            btn_kiralamaSil.TabIndex = 2;
            btn_kiralamaSil.Text = "Sil";
            btn_kiralamaSil.UseVisualStyleBackColor = true;
            btn_kiralamaSil.Click += btn_kiralamaSil_Click;
            // 
            // btn_kapat
            // 
            btn_kapat.Location = new Point(688, 453);
            btn_kapat.Name = "btn_kapat";
            btn_kapat.Size = new Size(100, 39);
            btn_kapat.TabIndex = 2;
            btn_kapat.Text = "Kapat";
            btn_kapat.UseVisualStyleBackColor = true;
            btn_kapat.Click += btn_kapat_Click;
            // 
            // KiralamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(btn_kapat);
            Controls.Add(btn_kiralamaSil);
            Controls.Add(btn_kiralamaDuzenle);
            Controls.Add(btn_yeniKiralama);
            Controls.Add(dtg_kiralamalar);
            Controls.Add(label1);
            Name = "KiralamaForm";
            Text = "KiralamaForm";
            Load += KiralamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_kiralamalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtg_kiralamalar;
        private Button btn_yeniKiralama;
        private Button btn_kiralamaDuzenle;
        private Button btn_kiralamaSil;
        private Button btn_kapat;
    }
}