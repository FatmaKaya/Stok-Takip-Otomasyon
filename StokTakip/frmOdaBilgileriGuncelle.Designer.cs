namespace StokTakip
{
    partial class frmOdaBilgileriGuncelle
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlGuncelleOdaBilgileri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditGuncelleAramaOdaAdi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.OdaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEditGuncelleOdaAdi = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonGuncelleOdaBilgileri = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GuncelleOdaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.GuncelleOdaSorumlusu = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonGuncelleOdaAra = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuncelleOdaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGuncelleAramaOdaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGuncelleOdaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuncelleOdaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuncelleOdaSorumlusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonGuncelleOdaAra);
            this.layoutControl1.Controls.Add(this.gridControlGuncelleOdaBilgileri);
            this.layoutControl1.Controls.Add(this.textEditGuncelleAramaOdaAdi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(443, 297);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlGuncelleOdaBilgileri
            // 
            this.gridControlGuncelleOdaBilgileri.Location = new System.Drawing.Point(12, 38);
            this.gridControlGuncelleOdaBilgileri.MainView = this.gridView1;
            this.gridControlGuncelleOdaBilgileri.Name = "gridControlGuncelleOdaBilgileri";
            this.gridControlGuncelleOdaBilgileri.Size = new System.Drawing.Size(419, 247);
            this.gridControlGuncelleOdaBilgileri.TabIndex = 6;
            this.gridControlGuncelleOdaBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlGuncelleOdaBilgileri;
            this.gridView1.Name = "gridView1";
            // 
            // textEditGuncelleAramaOdaAdi
            // 
            this.textEditGuncelleAramaOdaAdi.Location = new System.Drawing.Point(60, 12);
            this.textEditGuncelleAramaOdaAdi.Name = "textEditGuncelleAramaOdaAdi";
            this.textEditGuncelleAramaOdaAdi.Size = new System.Drawing.Size(261, 20);
            this.textEditGuncelleAramaOdaAdi.StyleController = this.layoutControl1;
            this.textEditGuncelleAramaOdaAdi.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.OdaAdi,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(443, 297);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // OdaAdi
            // 
            this.OdaAdi.Control = this.textEditGuncelleAramaOdaAdi;
            this.OdaAdi.Location = new System.Drawing.Point(0, 0);
            this.OdaAdi.Name = "OdaAdi";
            this.OdaAdi.Size = new System.Drawing.Size(313, 26);
            this.OdaAdi.Text = "Oda Adı: ";
            this.OdaAdi.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlGuncelleOdaBilgileri;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 251);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.textEditGuncelleOdaAdi);
            this.layoutControl2.Controls.Add(this.comboBoxEdit1);
            this.layoutControl2.Controls.Add(this.simpleButtonGuncelleOdaBilgileri);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(443, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(235, 297);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GuncelleOdaAdi,
            this.GuncelleOdaSorumlusu,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(235, 297);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // textEditGuncelleOdaAdi
            // 
            this.textEditGuncelleOdaAdi.Location = new System.Drawing.Point(95, 12);
            this.textEditGuncelleOdaAdi.Name = "textEditGuncelleOdaAdi";
            this.textEditGuncelleOdaAdi.Size = new System.Drawing.Size(128, 20);
            this.textEditGuncelleOdaAdi.StyleController = this.layoutControl2;
            this.textEditGuncelleOdaAdi.TabIndex = 4;
            // 
            // simpleButtonGuncelleOdaBilgileri
            // 
            this.simpleButtonGuncelleOdaBilgileri.Location = new System.Drawing.Point(12, 60);
            this.simpleButtonGuncelleOdaBilgileri.Name = "simpleButtonGuncelleOdaBilgileri";
            this.simpleButtonGuncelleOdaBilgileri.Size = new System.Drawing.Size(211, 22);
            this.simpleButtonGuncelleOdaBilgileri.StyleController = this.layoutControl2;
            this.simpleButtonGuncelleOdaBilgileri.TabIndex = 6;
            this.simpleButtonGuncelleOdaBilgileri.Text = "Güncelle";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(95, 36);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(128, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl2;
            this.comboBoxEdit1.TabIndex = 5;
            // 
            // GuncelleOdaAdi
            // 
            this.GuncelleOdaAdi.Control = this.textEditGuncelleOdaAdi;
            this.GuncelleOdaAdi.CustomizationFormText = "Oda Adı: ";
            this.GuncelleOdaAdi.Location = new System.Drawing.Point(0, 0);
            this.GuncelleOdaAdi.Name = "GuncelleOdaAdi";
            this.GuncelleOdaAdi.Size = new System.Drawing.Size(215, 24);
            this.GuncelleOdaAdi.Text = "Oda Adı: ";
            this.GuncelleOdaAdi.TextSize = new System.Drawing.Size(79, 13);
            // 
            // GuncelleOdaSorumlusu
            // 
            this.GuncelleOdaSorumlusu.Control = this.comboBoxEdit1;
            this.GuncelleOdaSorumlusu.CustomizationFormText = "Oda Sorumlusu: ";
            this.GuncelleOdaSorumlusu.Location = new System.Drawing.Point(0, 24);
            this.GuncelleOdaSorumlusu.Name = "GuncelleOdaSorumlusu";
            this.GuncelleOdaSorumlusu.Size = new System.Drawing.Size(215, 24);
            this.GuncelleOdaSorumlusu.Text = "Oda Sorumlusu: ";
            this.GuncelleOdaSorumlusu.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonGuncelleOdaBilgileri;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(215, 229);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleButtonGuncelleOdaAra
            // 
            this.simpleButtonGuncelleOdaAra.Location = new System.Drawing.Point(325, 12);
            this.simpleButtonGuncelleOdaAra.Name = "simpleButtonGuncelleOdaAra";
            this.simpleButtonGuncelleOdaAra.Size = new System.Drawing.Size(106, 22);
            this.simpleButtonGuncelleOdaAra.StyleController = this.layoutControl1;
            this.simpleButtonGuncelleOdaAra.TabIndex = 7;
            this.simpleButtonGuncelleOdaAra.Text = "Ara";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButtonGuncelleOdaAra;
            this.layoutControlItem1.Location = new System.Drawing.Point(313, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(110, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmOdaBilgileriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 297);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmOdaBilgileriGuncelle";
            this.Text = "Oda Bilgileri Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuncelleOdaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGuncelleAramaOdaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGuncelleOdaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuncelleOdaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuncelleOdaSorumlusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlGuncelleOdaBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEditGuncelleAramaOdaAdi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem OdaAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit textEditGuncelleOdaAdi;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelleOdaBilgileri;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem GuncelleOdaAdi;
        private DevExpress.XtraLayout.LayoutControlItem GuncelleOdaSorumlusu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelleOdaAra;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}