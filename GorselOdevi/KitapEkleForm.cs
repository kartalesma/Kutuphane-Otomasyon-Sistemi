using System;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO Kitaplar (KitapAdi, YazarAdi, KitapTuru, StokSayisi, TeminTarihi) VALUES ('{txtKitapAdi.Text}', '{txtYazarAdi.Text}', '{txtKitapTuru.Text}', {txtStokSayisi.Text}, '{dtpTeminTarihi.Value.ToString("yyyy-MM-dd")}')";
                int sonuc = Db.KomutCalistir(sql);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kitap başarıyla eklendi.");
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
