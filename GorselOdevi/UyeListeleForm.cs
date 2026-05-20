using System;
using System.Data;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class UyeListeleForm : Form
    {
        public UyeListeleForm()
        {
            InitializeComponent();
        }

        private void UyeListeleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Listele("SELECT * FROM Uyeler");
        }
    }
}
