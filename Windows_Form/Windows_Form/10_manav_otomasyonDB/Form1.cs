using Microsoft.Data.SqlClient;

namespace _10_manav_otomasyonDB
{
    public partial class Form1 : Form
    {
        string masterConnectionString = "Data Source=204-HOCAPC1;Initial Catalog=master;Integrated Security=True; TrustServerCertificate=True;";
        string manavConnectionString = "Data Source=204-HOCAPC1;Initial Catalog=ManavDB;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            VeritabaniniKontrolEtVeOlustur();
            InitializeComponent();
        }

        private void VeritabaniniKontrolEtVeOlustur()
        {
            string dbCreateQuery = "IF DB_ID('ManavDB') IS NULL CREATE DATABASE ManavDB;";

            using (SqlConnection connection = new SqlConnection(masterConnectionString)) //dbye baðlantý kuruyor
            {
                using (SqlCommand command = new SqlCommand(dbCreateQuery, connection))
                {
                    connection.Open(); //baðlantýyý açýyor
                    command.ExecuteNonQuery();//sorguyu çalýþtýrýyor
                }
            }

            string tablesCreateQuery = @"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Urunler]') AND type in (N'U'))
                CREATE TABLE Urunler(
                UrunID INT PRIMARY KEY IDENTITY(1,1),
                UrunAdi NVARCHAR(50) NOT NULL UNIQUE,
                Kategori NVARCHAR(50) NOT NULL
                );

                IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ManavStok]') AND type in (N'U'))
                CREATE TABLE ManavStok (
                StokID INT PRIMARY KEY IDENTITY(1,1),
                UrunID INT FOREIGN KEY REFERENCES Urunler(UrunID),
                Kilo DECIMAL(10, 2) NOT NULL
                );

                IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Satislar]') AND type in (N'U'))
                CREATE TABLE Satislar (
                SatisID INT PRIMARY KEY IDENTITY(1,1),
                UrunAdi NVARCHAR(50) NOT NULL,
                Kilo DECIMAL(10, 2) NOT NULL,
                SatisTarihi DATETIME DEFAULT GETDATE()
                );";

            using (SqlConnection connection = new SqlConnection(manavConnectionString))
            {
                using (SqlCommand command = new SqlCommand(tablesCreateQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }
        private void GuncelleHalUrunler()
        {
            lstHalUrunler.Items.Clear();
            string seciliKategori = cmbHalKategori.SelectedItem.ToString();

            string query = "SELECT UrunAdi FROM Urunler WHERE Kategori = @kategori ORDER BY UrunAdi";
            //UrunAdi ni Kategoriye göre seç ve sýrala

            using (SqlConnection connection = new SqlConnection(manavConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kategori", seciliKategori); //parametre ekleme, sql injection a karþý koruma saðlar
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(); //sorguyu çalýþtýrýr ve veri okuma iþlemi yapar
                    while (reader.Read()) //okuma iþlemi devam ettiði sürece
                    {
                        lstHalUrunler.Items.Add(reader["UrunAdi"].ToString()); //okunan veriyi listeye ekler
                    }
                }
            }
        }
        private void GuncelleManavUrunler()
        {
            lstManavUrunler.Items.Clear();
            if (cmbManavKategori.SelectedItem == null) return;

            string seciliKategori = cmbManavKategori.SelectedItem.ToString();
            string query = @"
                SELECT U.UrunAdi, MS.Kilo
                FROM ManavStok MS
                JOIN Urunler U ON MS.UrunID = U.UrunID
                WHERE U.Kategori = @kategori AND  MS.Kilo > 0;";

            using (SqlConnection connection = new SqlConnection(manavConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kategori", seciliKategori);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string urunAdi = reader["UrunAdi"].ToString();
                        decimal kilo = Convert.ToDecimal(reader["kilo"]);
                        lstManavUrunler.Items.Add($"{urunAdi} - {kilo:F2} KG");
                    }
                }
            }

        }

        private void cmbHalKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleHalUrunler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHalKategori.SelectedIndex = 0;
            GuncelleHalUrunler();

            cmbManavKategori.SelectedIndex = 0;
            GuncelleManavUrunler();
        }

        private void btn_halEkle_Click(object sender, EventArgs e)
        {
            string urun = txt_urun.Text.ToUpper().Trim();
            string kategori = cmbHalKategori.SelectedItem.ToString();
            if (string.IsNullOrEmpty(urun))
            {
                MessageBox.Show("Ürün Adý Boþ Býrakýlamaz", "Uyarý");
                return;
            }

            string query = "INSERT INTO Urunler (UrunAdi, Kategori) VALUES (@urunAdi, @kategori);";

            using (SqlConnection connection = new SqlConnection(manavConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@urunAdi", urun);
                    command.Parameters.AddWithValue("@kategori", kategori);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün baþarýyla eklendi");
                        txt_urun.Clear();
                        GuncelleHalUrunler();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Bu ürün zaten mevcut");
                            txt_urun.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Veritabaný Hatasý: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnHalEkle_Click(object sender, EventArgs e)
        {
            if (lstHalUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Listeden Bir Ürün Seçiniz.", "Uyarý");
                return;
            }
            if (!decimal.TryParse(txtHalKilo.Text, out decimal kilo) || kilo <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir kilo giriniz.", "Hata");
                return;
            }

            string secilenUrunAdi = lstHalUrunler.SelectedItem.ToString();
            int urunID = -1;

            using (SqlConnection conn = new SqlConnection(manavConnectionString))
            {
                conn.Open();
                string queryGetID = "SELECT UrunID FROM Urunler WHERE UrunAdi = @urunAdi;";
                using (SqlCommand cmdGetId = new SqlCommand(queryGetID, conn))
                {
                    cmdGetId.Parameters.AddWithValue("@urunAdi", secilenUrunAdi);
                    object result = cmdGetId.ExecuteScalar(); // tek bir deðer döndürür
                    if (result != null)
                    {
                        urunID = Convert.ToInt32(result);
                    }
                    if (urunID == -1)
                    {
                        MessageBox.Show("Ürün ID'si bulunamadý");
                        return;
                    }
                }
                string queryCheckStock = "SELECT Kilo FROM ManavStok WHERE UrunID = @urunID;";
                decimal mevcutKilo = 0;
                bool stoktaVar = false;
                using (SqlCommand cmdCheck = new SqlCommand(queryCheckStock, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@urunID", urunID);
                    object result = cmdCheck.ExecuteScalar();
                    if (result != null)
                    {
                        mevcutKilo = Convert.ToDecimal(result);
                        stoktaVar = true;
                    }
                }
                if (stoktaVar)
                {
                    string queryUpdateStock = "UPDATE ManavStok SET Kilo = Kilo + @eklenecekKilo WHERE UrunID = @urunID;";
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdateStock, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@eklenecekKilo", kilo);
                        cmdUpdate.Parameters.AddWithValue("@urunID", urunID);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                else
                {
                    string queryInsertStock = "INSERT INTO ManavStok (UrunID, Kilo) VALUES (@urunID, @kilo);";
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsertStock, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@urunID", urunID);
                        cmdInsert.Parameters.AddWithValue("@kilo", kilo);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                txtHalKilo.Clear();
                MessageBox.Show("Stok Güncellendi");

            }

        }

        private void cmbManavKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleManavUrunler();
        }

        private void btnManavSatis_Click(object sender, EventArgs e)
        {
            if (lstManavUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }
            if (!decimal.TryParse(txtManavKilo.Text, out decimal satilanKilo) || satilanKilo <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir kilo seçin.");
            }

            string secilenUrunAdi = lstManavUrunler.SelectedItem.ToString().Split('-')[0].Trim();
            int urunID = -1;
            decimal mevcutKilo = 0;
            using (SqlConnection conn = new SqlConnection(manavConnectionString))
            {
                try
                {
                    conn.Open();
                    string queryGetInfo = @"SELECT U.UrunID, MS.Kilo
                                            FROM ManavStok MS
                                            JOIN Urunler U ON MS.UrunID = U.UrunID
                                            WHERE U.UrunAdi = @urunAdi;";
                    using (SqlCommand cmdGetInfo = new SqlCommand(queryGetInfo, conn))
                    {
                        cmdGetInfo.Parameters.AddWithValue("@urunAdi", secilenUrunAdi);
                        SqlDataReader reader = cmdGetInfo.ExecuteReader();
                        if (reader.Read())
                        {
                            urunID = Convert.ToInt32(reader["UrunID"]);
                            mevcutKilo = Convert.ToDecimal(reader["Kilo"]);
                        }
                        reader.Close();
                        if ( satilanKilo > mevcutKilo)
                        {
                            MessageBox.Show("Yeterli stok yok.");
                            return;
                        }
                        decimal yeniKilo = mevcutKilo - satilanKilo;
                        if (yeniKilo > 0)
                        {
                            string queryUpdate = "UPDATE ManavStok SET Kilo = @yeniKilo WHERE UrunID = @urunID";
                            using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@yeniKilo", yeniKilo);
                                cmdUpdate.Parameters.AddWithValue("@urunID", urunID);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string queryDelete = "DELETE FROM ManavStok WHERE UrunID = @urunID";
                            using (SqlCommand cmdDelete = new SqlCommand(queryDelete, conn))
                            {
                                cmdDelete.Parameters.AddWithValue("@urunID", urunID);
                                cmdDelete.ExecuteNonQuery();
                            }
                        }
                        string queryInsertSale = "INSERT INTO Satislar (UrunAdi, Kilo) VALUES (@urunAdi, @kilo);";

                        using (SqlCommand cmdInsertSale = new SqlCommand(queryInsertSale, conn))
                        {
                            cmdInsertSale.Parameters.AddWithValue("@urunAdi", secilenUrunAdi);
                            cmdInsertSale.Parameters.AddWithValue("@kilo", satilanKilo);
                            cmdInsertSale.ExecuteNonQuery();
                        }
                        MessageBox.Show("Satýþ baþarýlý.");
                        GuncelleManavUrunler();
                        GuncelleMusteriListesi();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void GuncelleMusteriListesi()
        {
            lstMusteri.Items.Clear();

            string query = @"SELECT UrunAdi, Kilo, SatisTarihi FROM Satislar ORDER BY SatisTarihi DESC";

            using (SqlConnection connection = new SqlConnection(manavConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string urunAdi = reader["UrunAdi"].ToString();
                        decimal kilo = Convert.ToDecimal(reader["kilo"]);
                        DateTime satisTarihi = Convert.ToDateTime(reader["SatisTarihi"]);
                        lstMusteri.Items.Add($"Satýþ Tarihi: {satisTarihi} - {urunAdi} - {kilo:F2} KG");
                    }
                }
            }

        }
    }
}
