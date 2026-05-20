namespace GorselOdevi
{
    partial class OduncAlForm
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
            this.lblKitap = new System.Windows.Forms.Label();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.lblUye = new System.Windows.Forms.Label();
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.lblAlisTarihi = new System.Windows.Forms.Label();
            this.dtpAlisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKitap
            // 
            this.lblKitap.Location = new System.Drawing.Point(50, 40);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(120, 23);
            this.lblKitap.TabIndex = 0;
            this.lblKitap.Text = "Kitap Seç:";
            this.lblKitap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbKitap
            // 
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.Location = new System.Drawing.Point(180, 40);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(220, 24);
            this.cmbKitap.TabIndex = 1;
            // 
            // lblUye
            // 
            this.lblUye.Location = new System.Drawing.Point(50, 80);
            this.lblUye.Name = "lblUye";
            this.lblUye.Size = new System.Drawing.Size(120, 23);
            this.lblUye.TabIndex = 2;
            this.lblUye.Text = "Üye Seç:";
            this.lblUye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUye
            // 
            this.cmbUye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUye.Location = new System.Drawing.Point(180, 80);
            this.cmbUye.Name = "cmbUye";
            this.cmbUye.Size = new System.Drawing.Size(220, 24);
            this.cmbUye.TabIndex = 3;
            // 
            // lblAlisTarihi
            // 
            this.lblAlisTarihi.Location = new System.Drawing.Point(50, 120);
            this.lblAlisTarihi.Name = "lblAlisTarihi";
            this.lblAlisTarihi.Size = new System.Drawing.Size(120, 23);
            this.lblAlisTarihi.TabIndex = 4;
            this.lblAlisTarihi.Text = "Alış Tarihi:";
            this.lblAlisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpAlisTarihi
            // 
            this.dtpAlisTarihi.Location = new System.Drawing.Point(180, 120);
            this.dtpAlisTarihi.Name = "dtpAlisTarihi";
            this.dtpAlisTarihi.Size = new System.Drawing.Size(220, 22);
            this.dtpAlisTarihi.TabIndex = 5;
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.Location = new System.Drawing.Point(50, 160);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(120, 23);
            this.lblTeslimTarihi.TabIndex = 6;
            this.lblTeslimTarihi.Text = "Teslim Tarihi:";
            this.lblTeslimTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(180, 160);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(220, 22);
            this.dtpTeslimTarihi.TabIndex = 7;
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.Location = new System.Drawing.Point(180, 220);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(140, 50);
            this.btnOduncAl.TabIndex = 8;
            this.btnOduncAl.Text = "Ödünç Al";
            this.btnOduncAl.UseVisualStyleBackColor = true;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // OduncAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnOduncAl);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.lblTeslimTarihi);
            this.Controls.Add(this.dtpAlisTarihi);
            this.Controls.Add(this.lblAlisTarihi);
            this.Controls.Add(this.cmbUye);
            this.Controls.Add(this.lblUye);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.lblKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OduncAlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Al";
            this.Load += new System.EventHandler(this.OduncAlForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.Label lblAlisTarihi;
        private System.Windows.Forms.DateTimePicker dtpAlisTarihi;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Button btnOduncAl;
    }
}
