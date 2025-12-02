namespace _12_RentACar
{
    partial class Login
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
            grp_girisYap = new GroupBox();
            btn_GirisYap = new Button();
            txt_GirisSifre = new TextBox();
            txt_GirisTel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_kBakiye = new TextBox();
            txt_kRePassword = new TextBox();
            txt_kPassword = new TextBox();
            txt_kTel = new TextBox();
            txt_kAdAsoyad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_KayitOl = new Button();
            grp_girisYap.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grp_girisYap
            // 
            grp_girisYap.BackColor = Color.Transparent;
            grp_girisYap.Controls.Add(btn_GirisYap);
            grp_girisYap.Controls.Add(txt_GirisSifre);
            grp_girisYap.Controls.Add(txt_GirisTel);
            grp_girisYap.Controls.Add(label2);
            grp_girisYap.Controls.Add(label1);
            grp_girisYap.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grp_girisYap.Location = new Point(12, 12);
            grp_girisYap.Name = "grp_girisYap";
            grp_girisYap.Size = new Size(297, 203);
            grp_girisYap.TabIndex = 0;
            grp_girisYap.TabStop = false;
            grp_girisYap.Text = "Giriş";
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.BackColor = SystemColors.Menu;
            btn_GirisYap.BackgroundImageLayout = ImageLayout.Stretch;
            btn_GirisYap.ForeColor = SystemColors.ControlText;
            btn_GirisYap.Location = new Point(103, 131);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(119, 30);
            btn_GirisYap.TabIndex = 4;
            btn_GirisYap.Text = "Giriş Yap";
            btn_GirisYap.UseVisualStyleBackColor = false;
            btn_GirisYap.Click += btn_GirisYap_Click;
            // 
            // txt_GirisSifre
            // 
            txt_GirisSifre.Location = new Point(88, 85);
            txt_GirisSifre.Name = "txt_GirisSifre";
            txt_GirisSifre.PasswordChar = '*';
            txt_GirisSifre.PlaceholderText = "Password";
            txt_GirisSifre.Size = new Size(159, 26);
            txt_GirisSifre.TabIndex = 3;
            txt_GirisSifre.Text = "12345";
            // 
            // txt_GirisTel
            // 
            txt_GirisTel.Location = new Point(88, 35);
            txt_GirisTel.Name = "txt_GirisTel";
            txt_GirisTel.PlaceholderText = "Phone Number";
            txt_GirisTel.Size = new Size(159, 26);
            txt_GirisTel.TabIndex = 2;
            txt_GirisTel.Text = "5102208329";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 93);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 0;
            label1.Text = "Telefon";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txt_kBakiye);
            groupBox2.Controls.Add(txt_kRePassword);
            groupBox2.Controls.Add(txt_kPassword);
            groupBox2.Controls.Add(txt_kTel);
            groupBox2.Controls.Add(txt_kAdAsoyad);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btn_KayitOl);
            groupBox2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(883, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 747);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kayıt Form";
            // 
            // txt_kBakiye
            // 
            txt_kBakiye.Location = new Point(146, 257);
            txt_kBakiye.Name = "txt_kBakiye";
            txt_kBakiye.PlaceholderText = "Balance";
            txt_kBakiye.Size = new Size(185, 29);
            txt_kBakiye.TabIndex = 10;
            // 
            // txt_kRePassword
            // 
            txt_kRePassword.Location = new Point(146, 197);
            txt_kRePassword.Name = "txt_kRePassword";
            txt_kRePassword.PlaceholderText = "RePassword";
            txt_kRePassword.Size = new Size(185, 29);
            txt_kRePassword.TabIndex = 9;
            // 
            // txt_kPassword
            // 
            txt_kPassword.Location = new Point(146, 141);
            txt_kPassword.Name = "txt_kPassword";
            txt_kPassword.PlaceholderText = "Password";
            txt_kPassword.Size = new Size(185, 29);
            txt_kPassword.TabIndex = 8;
            // 
            // txt_kTel
            // 
            txt_kTel.Location = new Point(146, 87);
            txt_kTel.Name = "txt_kTel";
            txt_kTel.PlaceholderText = "Phone Number";
            txt_kTel.Size = new Size(185, 29);
            txt_kTel.TabIndex = 7;
            // 
            // txt_kAdAsoyad
            // 
            txt_kAdAsoyad.Location = new Point(146, 39);
            txt_kAdAsoyad.Name = "txt_kAdAsoyad";
            txt_kAdAsoyad.PlaceholderText = "Name Surname";
            txt_kAdAsoyad.Size = new Size(185, 29);
            txt_kAdAsoyad.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 253);
            label7.Name = "label7";
            label7.Size = new Size(66, 22);
            label7.TabIndex = 5;
            label7.Text = "Bakiye";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 200);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 4;
            label6.Text = "ReŞifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 148);
            label5.Name = "label5";
            label5.Size = new Size(50, 22);
            label5.TabIndex = 3;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 93);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 2;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 39);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 1;
            label3.Text = "Ad Soyad";
            // 
            // btn_KayitOl
            // 
            btn_KayitOl.Location = new Point(174, 312);
            btn_KayitOl.Name = "btn_KayitOl";
            btn_KayitOl.Size = new Size(117, 44);
            btn_KayitOl.TabIndex = 0;
            btn_KayitOl.Text = "Kayıt Ol";
            btn_KayitOl.UseVisualStyleBackColor = true;
            btn_KayitOl.Click += btn_KayitOl_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hazir_rent_a_car;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1289, 762);
            Controls.Add(groupBox2);
            Controls.Add(grp_girisYap);
            Name = "Login";
            Text = "Login";
            grp_girisYap.ResumeLayout(false);
            grp_girisYap.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_girisYap;
        private GroupBox groupBox2;
        private Button btn_GirisYap;
        private TextBox txt_GirisSifre;
        private TextBox txt_GirisTel;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_KayitOl;
        private TextBox txt_kBakiye;
        private TextBox txt_kRePassword;
        private TextBox txt_kPassword;
        private TextBox txt_kTel;
        private TextBox txt_kAdAsoyad;
    }
}