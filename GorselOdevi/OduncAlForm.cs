using System;
using System.Data;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class OduncAlForm : Form
    {
        public OduncAlForm()
        {
            InitializeComponent();
        }

        private void OduncAlForm_Load(object sender, EventArgs e)
        {
            KitaplariYukle();
            UyeleriYukle();
        }

        private void KitaplariYukle()
        {
            DataTable dt = Db.Listele("SELECT KitapId, KitapAdi FROM Kitaplar WHERE StokSayisi > 0");
            cmbKitap.DataSource = dt;
            cmbKitap.DisplayMember = "KitapAdi";
            cmbKitap.ValueMember = "KitapId";
        }

        private void UyeleriYukle()
        {
            DataTable dt = Db.Listele("SELECT UyeId, (Ad + ' ' + Soyad) AS AdSoyad FROM Uyeler");
            cmbUye.DataSource = dt;
            cmbUye.DisplayMember = "AdSoyad";
            cmbUye.ValueMember = "UyeId";
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKitap.SelectedValue == null || cmbUye.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen kitap ve üye seçiniz.");
                    return;
                }

                int kitapId = (int)cmbKitap.SelectedValue;
                int uyeId = (int)cmbUye.SelectedValue;

                string sqlOdunc = $"INSERT INTO Oduncler (KitapId, UyeId, AlisTarihi, TeslimTarihi) VALUES ({kitapId}, {uyeId}, '{dtpAlisTarihi.Value.ToString("yyyy-MM-dd")}', '{dtpTeslimTarihi.Value.ToString("yyyy-MM-dd")}')";
                string sqlStok = $"UPDATE Kitaplar SET StokSayisi = StokSayisi - 1 WHERE KitapId = {kitapId}";

                Db.KomutCalistir(sqlOdunc);
                Db.KomutCalistir(sqlStok);

                MessageBox.Show("Kitap ödünç verildi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
