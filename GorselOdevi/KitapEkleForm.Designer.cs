namespace GorselOdevi
{
    partial class KitapEkleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.lblKitapTuru = new System.Windows.Forms.Label();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.lblStokSayisi = new System.Windows.Forms.Label();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.lblTeminTarihi = new System.Windows.Forms.Label();
            this.dtpTeminTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.Location = new System.Drawing.Point(50, 40);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(120, 23);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı:";
            this.lblKitapAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(180, 40);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(200, 22);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.Location = new System.Drawing.Point(50, 80);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(120, 23);
            this.lblYazarAdi.TabIndex = 2;
            this.lblYazarAdi.Text = "Yazar Adı:";
            this.lblYazarAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(180, 80);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(200, 22);
            this.txtYazarAdi.TabIndex = 3;
            // 
            // lblKitapTuru
            // 
            this.lblKitapTuru.Location = new System.Drawing.Point(50, 120);
            this.lblKitapTuru.Name = "lblKitapTuru";
            this.lblKitapTuru.Size = new System.Drawing.Size(120, 23);
            this.lblKitapTuru.TabIndex = 4;
            this.lblKitapTuru.Text = "Kitap Türü:";
            this.lblKitapTuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Location = new System.Drawing.Point(180, 120);
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(200, 22);
            this.txtKitapTuru.TabIndex = 5;
            // 
            // lblStokSayisi
            // 
            this.lblStokSayisi.Location = new System.Drawing.Point(50, 160);
            this.lblStokSayisi.Name = "lblStokSayisi";
            this.lblStokSayisi.Size = new System.Drawing.Size(120, 23);
            this.lblStokSayisi.TabIndex = 6;
            this.lblStokSayisi.Text = "Stok Sayısı:";
            this.lblStokSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Location = new System.Drawing.Point(180, 160);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(200, 22);
            this.txtStokSayisi.TabIndex = 7;
            // 
            // lblTeminTarihi
            // 
            this.lblTeminTarihi.Location = new System.Drawing.Point(50, 200);
            this.lblTeminTarihi.Name = "lblTeminTarihi";
            this.lblTeminTarihi.Size = new System.Drawing.Size(120, 23);
            this.lblTeminTarihi.TabIndex = 8;
            this.lblTeminTarihi.Text = "Temin Tarihi:";
            this.lblTeminTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTeminTarihi
            // 
            this.dtpTeminTarihi.Location = new System.Drawing.Point(180, 200);
            this.dtpTeminTarihi.Name = "dtpTeminTarihi";
            this.dtpTeminTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpTeminTarihi.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(180, 260);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 50);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // KitapEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpTeminTarihi);
            this.Controls.Add(this.lblTeminTarihi);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.lblStokSayisi);
            this.Controls.Add(this.txtKitapTuru);
            this.Controls.Add(this.lblKitapTuru);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.lblYazarAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.lblKitapAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KitapEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label lblKitapTuru;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.Label lblStokSayisi;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.Label lblTeminTarihi;
        private System.Windows.Forms.DateTimePicker dtpTeminTarihi;
        private System.Windows.Forms.Button btnKaydet;
    }
}
