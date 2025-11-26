namespace _06_Form_Odev
{
    partial class frmAnaSayfa
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
            btnKapat = new Button();
            btnHesapMakinesiAc = new Button();
            btnAnketAc = new Button();
            SuspendLayout();
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(63, 115);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(140, 40);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnHesapMakinesiAc
            // 
            btnHesapMakinesiAc.Location = new Point(63, 23);
            btnHesapMakinesiAc.Name = "btnHesapMakinesiAc";
            btnHesapMakinesiAc.Size = new Size(140, 40);
            btnHesapMakinesiAc.TabIndex = 1;
            btnHesapMakinesiAc.Text = "Hesap Makinesi";
            btnHesapMakinesiAc.UseVisualStyleBackColor = true;
            btnHesapMakinesiAc.Click += btnHesapMakinesiAc_Click;
            // 
            // btnAnketAc
            // 
            btnAnketAc.Location = new Point(63, 69);
            btnAnketAc.Name = "btnAnketAc";
            btnAnketAc.Size = new Size(140, 40);
            btnAnketAc.TabIndex = 2;
            btnAnketAc.Text = "Anket";
            btnAnketAc.UseVisualStyleBackColor = true;
            btnAnketAc.Click += btnAnketAc_Click;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 171);
            Controls.Add(btnAnketAc);
            Controls.Add(btnHesapMakinesiAc);
            Controls.Add(btnKapat);
            Name = "frmAnaSayfa";
            Text = "Ana Sayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKapat;
        private Button btnHesapMakinesiAc;
        private Button btnAnketAc;
    }
}