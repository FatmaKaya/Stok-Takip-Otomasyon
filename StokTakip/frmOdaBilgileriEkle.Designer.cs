namespace StokTakip
{
    partial class frmOdaBilgileriEkle
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
            this.textEditOdaAdiEkle = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditBolumAdiEkle = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditFakulteAdiEkle = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditOdaSorumlusuEkle = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButtonOdaKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.OdaSorumlusu = new DevExpress.XtraLayout.LayoutControlItem();
            this.FakulteAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.DepartmanAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.OdaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOdaAdiEkle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBolumAdiEkle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFakulteAdiEkle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditOdaSorumlusuEkle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaSorumlusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakulteAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditOdaAdiEkle);
            this.layoutControl1.Controls.Add(this.lookUpEditBolumAdiEkle);
            this.layoutControl1.Controls.Add(this.lookUpEditFakulteAdiEkle);
            this.layoutControl1.Controls.Add(this.lookUpEditOdaSorumlusuEkle);
            this.layoutControl1.Controls.Add(this.simpleButtonOdaKaydet);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(340, 261);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEditOdaAdiEkle
            // 
            this.textEditOdaAdiEkle.Location = new System.Drawing.Point(94, 84);
            this.textEditOdaAdiEkle.Name = "textEditOdaAdiEkle";
            this.textEditOdaAdiEkle.Properties.MaxLength = 25;
            this.textEditOdaAdiEkle.Size = new System.Drawing.Size(234, 20);
            this.textEditOdaAdiEkle.StyleController = this.layoutControl1;
            this.textEditOdaAdiEkle.TabIndex = 10;
            // 
            // lookUpEditBolumAdiEkle
            // 
            this.lookUpEditBolumAdiEkle.Location = new System.Drawing.Point(94, 36);
            this.lookUpEditBolumAdiEkle.Name = "lookUpEditBolumAdiEkle";
            this.lookUpEditBolumAdiEkle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditBolumAdiEkle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmanAdi", "Departman")});
            this.lookUpEditBolumAdiEkle.Properties.DisplayMember = "DepartmanAdi";
            this.lookUpEditBolumAdiEkle.Properties.DropDownRows = 5;
            this.lookUpEditBolumAdiEkle.Properties.NullText = "";
            this.lookUpEditBolumAdiEkle.Properties.ValueMember = "DepartmanID";
            this.lookUpEditBolumAdiEkle.Size = new System.Drawing.Size(234, 20);
            this.lookUpEditBolumAdiEkle.StyleController = this.layoutControl1;
            this.lookUpEditBolumAdiEkle.TabIndex = 9;
            this.lookUpEditBolumAdiEkle.EditValueChanged += new System.EventHandler(this.lookUpEditBolumAdiEkle_EditValueChanged);
            // 
            // lookUpEditFakulteAdiEkle
            // 
            this.lookUpEditFakulteAdiEkle.Location = new System.Drawing.Point(94, 12);
            this.lookUpEditFakulteAdiEkle.Name = "lookUpEditFakulteAdiEkle";
            this.lookUpEditFakulteAdiEkle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFakulteAdiEkle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FakulteAdi", "Fakülte")});
            this.lookUpEditFakulteAdiEkle.Properties.DisplayMember = "FakulteAdi";
            this.lookUpEditFakulteAdiEkle.Properties.DropDownRows = 5;
            this.lookUpEditFakulteAdiEkle.Properties.NullText = "";
            this.lookUpEditFakulteAdiEkle.Properties.ValueMember = "FakulteID";
            this.lookUpEditFakulteAdiEkle.Size = new System.Drawing.Size(234, 20);
            this.lookUpEditFakulteAdiEkle.StyleController = this.layoutControl1;
            this.lookUpEditFakulteAdiEkle.TabIndex = 8;
            this.lookUpEditFakulteAdiEkle.EditValueChanged += new System.EventHandler(this.lookUpEditFakulteAdiEkle_EditValueChanged);
            // 
            // lookUpEditOdaSorumlusuEkle
            // 
            this.lookUpEditOdaSorumlusuEkle.Location = new System.Drawing.Point(94, 60);
            this.lookUpEditOdaSorumlusuEkle.Name = "lookUpEditOdaSorumlusuEkle";
            this.lookUpEditOdaSorumlusuEkle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditOdaSorumlusuEkle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonelAdi", "Personel Adı")});
            this.lookUpEditOdaSorumlusuEkle.Properties.DisplayMember = "PersonelAdi";
            this.lookUpEditOdaSorumlusuEkle.Properties.DropDownRows = 5;
            this.lookUpEditOdaSorumlusuEkle.Properties.NullText = "";
            this.lookUpEditOdaSorumlusuEkle.Properties.ValueMember = "PersonelID";
            this.lookUpEditOdaSorumlusuEkle.Size = new System.Drawing.Size(234, 20);
            this.lookUpEditOdaSorumlusuEkle.StyleController = this.layoutControl1;
            this.lookUpEditOdaSorumlusuEkle.TabIndex = 7;
            this.lookUpEditOdaSorumlusuEkle.EditValueChanged += new System.EventHandler(this.lookUpEditOdaSorumlusuEkle_EditValueChanged);
            // 
            // simpleButtonOdaKaydet
            // 
            this.simpleButtonOdaKaydet.Location = new System.Drawing.Point(12, 108);
            this.simpleButtonOdaKaydet.Name = "simpleButtonOdaKaydet";
            this.simpleButtonOdaKaydet.Size = new System.Drawing.Size(316, 22);
            this.simpleButtonOdaKaydet.StyleController = this.layoutControl1;
            this.simpleButtonOdaKaydet.TabIndex = 6;
            this.simpleButtonOdaKaydet.Text = "Kaydet";
            this.simpleButtonOdaKaydet.Click += new System.EventHandler(this.simpleButtonOdaKaydet_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.OdaSorumlusu,
            this.FakulteAdi,
            this.DepartmanAdi,
            this.OdaAdi});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(340, 261);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(320, 119);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButtonOdaKaydet;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(320, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // OdaSorumlusu
            // 
            this.OdaSorumlusu.Control = this.lookUpEditOdaSorumlusuEkle;
            this.OdaSorumlusu.Location = new System.Drawing.Point(0, 48);
            this.OdaSorumlusu.Name = "OdaSorumlusu";
            this.OdaSorumlusu.Size = new System.Drawing.Size(320, 24);
            this.OdaSorumlusu.Text = "Oda Sorumlusu: ";
            this.OdaSorumlusu.TextSize = new System.Drawing.Size(79, 13);
            // 
            // FakulteAdi
            // 
            this.FakulteAdi.Control = this.lookUpEditFakulteAdiEkle;
            this.FakulteAdi.Location = new System.Drawing.Point(0, 0);
            this.FakulteAdi.Name = "FakulteAdi";
            this.FakulteAdi.Size = new System.Drawing.Size(320, 24);
            this.FakulteAdi.Text = "Fakülte Adı: ";
            this.FakulteAdi.TextSize = new System.Drawing.Size(79, 13);
            // 
            // DepartmanAdi
            // 
            this.DepartmanAdi.Control = this.lookUpEditBolumAdiEkle;
            this.DepartmanAdi.Location = new System.Drawing.Point(0, 24);
            this.DepartmanAdi.Name = "DepartmanAdi";
            this.DepartmanAdi.Size = new System.Drawing.Size(320, 24);
            this.DepartmanAdi.Text = "Departman Adı: ";
            this.DepartmanAdi.TextSize = new System.Drawing.Size(79, 13);
            // 
            // OdaAdi
            // 
            this.OdaAdi.Control = this.textEditOdaAdiEkle;
            this.OdaAdi.Location = new System.Drawing.Point(0, 72);
            this.OdaAdi.Name = "OdaAdi";
            this.OdaAdi.Size = new System.Drawing.Size(320, 24);
            this.OdaAdi.Text = "Oda Adı: ";
            this.OdaAdi.TextSize = new System.Drawing.Size(79, 13);
            // 
            // frmOdaBilgileriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmOdaBilgileriEkle";
            this.Text = "Oda Bilgileri Ekle";
            this.Load += new System.EventHandler(this.frmOdaBilgileriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditOdaAdiEkle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBolumAdiEkle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFakulteAdiEkle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditOdaSorumlusuEkle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaSorumlusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakulteAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOdaKaydet;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditOdaSorumlusuEkle;
        private DevExpress.XtraLayout.LayoutControlItem OdaSorumlusu;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditBolumAdiEkle;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFakulteAdiEkle;
        private DevExpress.XtraLayout.LayoutControlItem FakulteAdi;
        private DevExpress.XtraLayout.LayoutControlItem DepartmanAdi;
        private DevExpress.XtraEditors.TextEdit textEditOdaAdiEkle;
        private DevExpress.XtraLayout.LayoutControlItem OdaAdi;
    }
}