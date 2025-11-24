namespace _02_Ogrenci_Bilgi_Sistemi
{
    partial class OgrenciListeleForm
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
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.AllowUserToAddRows = false;
            this.dgvOgrenciler.AllowUserToDeleteRows = false;
            this.dgvOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenciler.BackgroundColor = System.Drawing.Color.White;
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(20, 60);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.ReadOnly = true;
            this.dgvOgrenciler.Size = new System.Drawing.Size(760, 350);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(151, 25);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Öðrenci Listesi";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(680, 420);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // OgrenciListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvOgrenciler);
            this.Name = "OgrenciListeleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öðrenci Listele";
            this.Load += new System.EventHandler(this.OgrenciListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
    }
}
