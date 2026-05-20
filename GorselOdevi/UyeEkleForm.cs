using System;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class UyeEkleForm : Form
    {
        public UyeEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO Uyeler (TCKimlik, Ad, Soyad, Telefon, Adres) VALUES ('{txtTC.Text}', '{txtAd.Text}', '{txtSoyad.Text}', '{txtTelefon.Text}', '{txtAdres.Text}')";
                int sonuc = Db.KomutCalistir(sql);
                if (sonuc > 0)
                {
                    MessageBox.Show("Üye başarıyla eklendi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
