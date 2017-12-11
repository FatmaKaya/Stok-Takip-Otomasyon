namespace StokTakip
{
    partial class frmKullaniciGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGiris));
            this.TextEditSifre = new DevExpress.XtraEditors.TextEdit();
            this.SimpleButtonGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.LCKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.LCSifre = new DevExpress.XtraEditors.LabelControl();
            this.TextEditKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextEditSifre
            // 
            this.TextEditSifre.EditValue = "";
            this.TextEditSifre.Location = new System.Drawing.Point(52, 238);
            this.TextEditSifre.Name = "TextEditSifre";
            this.TextEditSifre.Properties.PasswordChar = '*';
            this.TextEditSifre.Size = new System.Drawing.Size(167, 20);
            this.TextEditSifre.TabIndex = 3;
            // 
            // SimpleButtonGiris
            // 
            this.SimpleButtonGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SimpleButtonGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SimpleButtonGiris.Appearance.Options.UseFont = true;
            this.SimpleButtonGiris.Appearance.Options.UseForeColor = true;
            this.SimpleButtonGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.SimpleButtonGiris.Location = new System.Drawing.Point(82, 280);
            this.SimpleButtonGiris.Name = "SimpleButtonGiris";
            this.SimpleButtonGiris.Size = new System.Drawing.Size(105, 23);
            this.SimpleButtonGiris.TabIndex = 6;
            this.SimpleButtonGiris.Text = "Giriş";
            this.SimpleButtonGiris.Click += new System.EventHandler(this.Giriş_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(52, 38);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Properties.ZoomPercent = 20D;
            this.pictureEdit1.Size = new System.Drawing.Size(167, 110);
            this.pictureEdit1.TabIndex = 5;
            // 
            // LCKullaniciAdi
            // 
            this.LCKullaniciAdi.Location = new System.Drawing.Point(52, 165);
            this.LCKullaniciAdi.Name = "LCKullaniciAdi";
            this.LCKullaniciAdi.Size = new System.Drawing.Size(55, 13);
            this.LCKullaniciAdi.TabIndex = 7;
            this.LCKullaniciAdi.Text = "Kullanıcı Adi";
            // 
            // LCSifre
            // 
            this.LCSifre.Location = new System.Drawing.Point(52, 219);
            this.LCSifre.Name = "LCSifre";
            this.LCSifre.Size = new System.Drawing.Size(22, 13);
            this.LCSifre.TabIndex = 8;
            this.LCSifre.Text = "Şifre";
            // 
            // TextEditKullaniciAdi
            // 
            this.TextEditKullaniciAdi.EditValue = "";
            this.TextEditKullaniciAdi.Location = new System.Drawing.Point(52, 184);
            this.TextEditKullaniciAdi.Name = "TextEditKullaniciAdi";
            this.TextEditKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEditKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.TextEditKullaniciAdi.Size = new System.Drawing.Size(167, 22);
            this.TextEditKullaniciAdi.TabIndex = 1;
            // 
            // frmKullaniciGiris
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 364);
            this.Controls.Add(this.LCSifre);
            this.Controls.Add(this.LCKullaniciAdi);
            this.Controls.Add(this.SimpleButtonGiris);
            this.Controls.Add(this.TextEditSifre);
            this.Controls.Add(this.TextEditKullaniciAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmKullaniciGiris";
            this.Text = "Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.frmKullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TextEditSifre;
        private DevExpress.XtraEditors.SimpleButton SimpleButtonGiris;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl LCKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl LCSifre;
        private DevExpress.XtraEditors.TextEdit TextEditKullaniciAdi;
    }
}

