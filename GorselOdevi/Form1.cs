using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleForm frm = new KitapEkleForm();
            frm.ShowDialog();
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            OduncAlForm frm = new OduncAlForm();
            frm.ShowDialog();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkleForm frm = new UyeEkleForm();
            frm.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListeleForm frm = new KitapListeleForm();
            frm.ShowDialog();
        }

        private void btnGecikenKitaplar_Click(object sender, EventArgs e)
        {
            GecikenKitaplarForm frm = new GecikenKitaplarForm();
            frm.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListeleForm frm = new UyeListeleForm();
            frm.ShowDialog();
        }
    }
}
