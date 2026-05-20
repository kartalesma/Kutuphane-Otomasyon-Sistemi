namespace GorselOdevi
{
    partial class Form1
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
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnGecikenKitaplar = new System.Windows.Forms.Button();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(60, 60);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(130, 80);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.Location = new System.Drawing.Point(210, 60);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(130, 80);
            this.btnOduncAl.TabIndex = 1;
            this.btnOduncAl.Text = "Ödünç Al";
            this.btnOduncAl.UseVisualStyleBackColor = true;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(360, 60);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(130, 80);
            this.btnUyeEkle.TabIndex = 2;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(60, 160);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(130, 80);
            this.btnKitapListele.TabIndex = 3;
            this.btnKitapListele.Text = "Kitap Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnGecikenKitaplar
            // 
            this.btnGecikenKitaplar.Location = new System.Drawing.Point(210, 160);
            this.btnGecikenKitaplar.Name = "btnGecikenKitaplar";
            this.btnGecikenKitaplar.Size = new System.Drawing.Size(130, 80);
            this.btnGecikenKitaplar.TabIndex = 4;
            this.btnGecikenKitaplar.Text = "Geciken Kitaplar";
            this.btnGecikenKitaplar.UseVisualStyleBackColor = true;
            this.btnGecikenKitaplar.Click += new System.EventHandler(this.btnGecikenKitaplar_Click);
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Location = new System.Drawing.Point(360, 160);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(130, 80);
            this.btnUyeListele.TabIndex = 5;
            this.btnUyeListele.Text = "Üye Listele";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.btnUyeListele);
            this.Controls.Add(this.btnGecikenKitaplar);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.btnOduncAl);
            this.Controls.Add(this.btnKitapEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnOduncAl;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnGecikenKitaplar;
        private System.Windows.Forms.Button btnUyeListele;
    }
}
