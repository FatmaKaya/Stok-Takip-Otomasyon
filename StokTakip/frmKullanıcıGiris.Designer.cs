namespace StokTakip
{
    partial class FRMGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGiris));
            this.TEKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.TESifre = new DevExpress.XtraEditors.TextEdit();
            this.SBGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.LCKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.LCSifre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TEKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TEKullaniciAdi
            // 
            this.TEKullaniciAdi.EditValue = "";
            this.TEKullaniciAdi.Location = new System.Drawing.Point(52, 184);
            this.TEKullaniciAdi.Name = "TEKullaniciAdi";
            this.TEKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.TEKullaniciAdi.Size = new System.Drawing.Size(167, 22);
            this.TEKullaniciAdi.TabIndex = 1;
            // 
            // TESifre
            // 
            this.TESifre.EditValue = "";
            this.TESifre.Location = new System.Drawing.Point(52, 238);
            this.TESifre.Name = "TESifre";
            this.TESifre.Properties.PasswordChar = '*';
            this.TESifre.Size = new System.Drawing.Size(167, 20);
            this.TESifre.TabIndex = 3;
            // 
            // SBGiris
            // 
            this.SBGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SBGiris.Appearance.Options.UseFont = true;
            this.SBGiris.Appearance.Options.UseForeColor = true;
            this.SBGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.SBGiris.Location = new System.Drawing.Point(82, 280);
            this.SBGiris.Name = "SBGiris";
            this.SBGiris.Size = new System.Drawing.Size(105, 23);
            this.SBGiris.TabIndex = 6;
            this.SBGiris.Text = "Giriş";
            this.SBGiris.Click += new System.EventHandler(this.Giriş_Click);
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
            // FRMGiris
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 364);
            this.Controls.Add(this.LCSifre);
            this.Controls.Add(this.LCKullaniciAdi);
            this.Controls.Add(this.SBGiris);
            this.Controls.Add(this.TESifre);
            this.Controls.Add(this.TEKullaniciAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FRMGiris";
            this.Text = "Stok Takip Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.TEKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TEKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit TESifre;
        private DevExpress.XtraEditors.SimpleButton SBGiris;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl LCKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl LCSifre;
    }
}

