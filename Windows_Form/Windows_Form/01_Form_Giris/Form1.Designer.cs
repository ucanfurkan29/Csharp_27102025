namespace _01_Form_Giris
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
            btnTikla = new Button();
            lblMesaj = new Label();
            btnSil = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblSonuc = new Label();
            btnSelamla = new Button();
            txtAd = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTikla
            // 
            btnTikla.BackColor = SystemColors.ActiveCaption;
            btnTikla.Cursor = Cursors.Hand;
            btnTikla.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTikla.ForeColor = Color.Red;
            btnTikla.Location = new Point(19, 22);
            btnTikla.Name = "btnTikla";
            btnTikla.Size = new Size(80, 53);
            btnTikla.TabIndex = 0;
            btnTikla.Text = "BANA TIKLA";
            btnTikla.UseVisualStyleBackColor = false;
            btnTikla.Click += btnTikla_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Font = new Font("Algerian", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMesaj.Location = new Point(105, 67);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(242, 21);
            lblMesaj.TabIndex = 1;
            lblMesaj.Text = "Sayfa Açıldığında silinir";
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(19, 81);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 46);
            btnSil.TabIndex = 2;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Adınızı Girin:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTikla);
            groupBox1.Controls.Add(lblMesaj);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 142);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSonuc);
            groupBox2.Controls.Add(btnSelamla);
            groupBox2.Controls.Add(txtAd);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 116);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(48, 59);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 25);
            lblSonuc.TabIndex = 6;
            // 
            // btnSelamla
            // 
            btnSelamla.Location = new Point(254, 19);
            btnSelamla.Name = "btnSelamla";
            btnSelamla.Size = new Size(75, 23);
            btnSelamla.TabIndex = 5;
            btnSelamla.Text = "Selamla";
            btnSelamla.UseVisualStyleBackColor = true;
            btnSelamla.Click += btnSelamla_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(86, 19);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(153, 23);
            txtAd.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(391, 300);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "İlk Uygulama";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTikla;
        private Label lblMesaj;
        private Button btnSil;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblSonuc;
        private Button btnSelamla;
        private TextBox txtAd;
    }
}
