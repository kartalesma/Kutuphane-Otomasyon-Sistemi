using System;
using System.Data;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class KitapListeleForm : Form
    {
        public KitapListeleForm()
        {
            InitializeComponent();
        }

        private void KitapListeleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Listele("SELECT * FROM Kitaplar");
        }
    }
}
