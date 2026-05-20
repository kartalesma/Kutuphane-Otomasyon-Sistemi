using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GorselOdevi
{
    public static class Db
    {
        // SQL Server LocalDB bağlantı dizesi
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KutuphaneDB;Integrated Security=True";
        // Master veritabanına bağlanmak için (DB oluştururken kullanılır)
        private static string masterConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

        public static void DatabaseOlustur()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(masterConnectionString))
                {
                    conn.Open();
                    string query = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'KutuphaneDB') CREATE DATABASE KutuphaneDB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı oluşturulurken hata: " + ex.Message);
            }
        }

        public static void TablolariOlustur()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kitaplar Tablosu
                    string sqlKitaplar = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kitaplar')
                                         CREATE TABLE Kitaplar (
                                            KitapId INT IDENTITY PRIMARY KEY,
                                            KitapAdi NVARCHAR(100),
                                            YazarAdi NVARCHAR(100),
                                            KitapTuru NVARCHAR(50),
                                            StokSayisi INT,
                                            TeminTarihi DATE
                                         )";
                    
                    // Uyeler Tablosu
                    string sqlUyeler = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Uyeler')
                                       CREATE TABLE Uyeler (
                                            UyeId INT IDENTITY PRIMARY KEY,
                                            TCKimlik NVARCHAR(11),
                                            Ad NVARCHAR(50),
                                            Soyad NVARCHAR(50),
                                            Telefon NVARCHAR(20),
                                            Adres NVARCHAR(200)
                                       )";

                    // Oduncler Tablosu
                    string sqlOduncler = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Oduncler')
                                         CREATE TABLE Oduncler (
                                            OduncId INT IDENTITY PRIMARY KEY,
                                            KitapId INT,
                                            UyeId INT,
                                            AlisTarihi DATE,
                                            TeslimTarihi DATE,
                                            TeslimEdildi BIT DEFAULT 0
                                         )";

                    KomutCalistir(sqlKitaplar);
                    KomutCalistir(sqlUyeler);
                    KomutCalistir(sqlOduncler);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablolar oluşturulurken hata: " + ex.Message);
            }
        }

        public static DataTable Listele(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
            return dt;
        }

        public static int KomutCalistir(string sql)
        {
            int sonuc = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        sonuc = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorgu hatası: " + ex.Message);
            }
            return sonuc;
        }
    }
}
