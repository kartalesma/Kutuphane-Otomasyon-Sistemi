using System;
using System.Data;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class GecikenKitaplarForm : Form
    {
        public GecikenKitaplarForm()
        {
            InitializeComponent();
        }

        private void GecikenKitaplarForm_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT k.KitapAdi, u.Ad, u.Soyad, o.AlisTarihi, o.TeslimTarihi 
                           FROM Oduncler o
                           JOIN Kitaplar k ON o.KitapId = k.KitapId
                           JOIN Uyeler u ON o.UyeId = u.UyeId
                           WHERE o.TeslimEdildi = 0 AND o.TeslimTarihi < GETDATE()";
            dataGridView1.DataSource = Db.Listele(sql);
        }
    }
}
