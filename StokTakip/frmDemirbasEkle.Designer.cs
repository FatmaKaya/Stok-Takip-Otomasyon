namespace StokTakip
{
    partial class frmDemirbasEkle
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
            this.lookUpEditDemirbasTur = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditDemirbasEkleDepartmanAdi = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditDemirbasEkleFakulteAdi = new DevExpress.XtraEditors.LookUpEdit();
            this.SpinEditEkleDemirbasAdet = new DevExpress.XtraEditors.SpinEdit();
            this.SimpleButtonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TextEditEkleDemirbasFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TextEditEkleDemirbasAd = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.demirbasAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.demirbasFiyati = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DemirbasAdet = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDemirbasTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDemirbasEkleDepartmanAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDemirbasEkleFakulteAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditEkleDemirbasAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditEkleDemirbasFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditEkleDemirbasAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpEditDemirbasTur);
            this.layoutControl1.Controls.Add(this.lookUpEditDemirbasEkleDepartmanAdi);
            this.layoutControl1.Controls.Add(this.lookUpEditDemirbasEkleFakulteAdi);
            this.layoutControl1.Controls.Add(this.SpinEditEkleDemirbasAdet);
            this.layoutControl1.Controls.Add(this.SimpleButtonEkle);
            this.layoutControl1.Controls.Add(this.TextEditEkleDemirbasFiyat);
            this.layoutControl1.Controls.Add(this.TextEditEkleDemirbasAd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(364, 470);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpEditDemirbasTur
            // 
            this.lookUpEditDemirbasTur.Location = new System.Drawing.Point(90, 60);
            this.lookUpEditDemirbasTur.Name = "lookUpEditDemirbasTur";
            this.lookUpEditDemirbasTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDemirbasTur.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DemirbasTurAdi", "Tür")});
            this.lookUpEditDemirbasTur.Properties.DisplayMember = "DemirbasTurAdi";
            this.lookUpEditDemirbasTur.Properties.NullText = "";
            this.lookUpEditDemirbasTur.Properties.ValueMember = "DemirbasTurID";
            this.lookUpEditDemirbasTur.Size = new System.Drawing.Size(262, 20);
            this.lookUpEditDemirbasTur.StyleController = this.layoutControl1;
            this.lookUpEditDemirbasTur.TabIndex = 13;
            this.lookUpEditDemirbasTur.EditValueChanged += new System.EventHandler(this.lookUpEditDemirbasTur_EditValueChanged);
            // 
            // lookUpEditDemirbasEkleDepartmanAdi
            // 
            this.lookUpEditDemirbasEkleDepartmanAdi.Location = new System.Drawing.Point(90, 36);
            this.lookUpEditDemirbasEkleDepartmanAdi.Name = "lookUpEditDemirbasEkleDepartmanAdi";
            this.lookUpEditDemirbasEkleDepartmanAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDemirbasEkleDepartmanAdi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmanAdi", "Departman")});
            this.lookUpEditDemirbasEkleDepartmanAdi.Properties.DisplayMember = "DepartmanAdi";
            this.lookUpEditDemirbasEkleDepartmanAdi.Properties.DropDownRows = 5;
            this.lookUpEditDemirbasEkleDepartmanAdi.Properties.NullText = "";
            this.lookUpEditDemirbasEkleDepartmanAdi.Properties.ValueMember = "DepartmanID";
            this.lookUpEditDemirbasEkleDepartmanAdi.Size = new System.Drawing.Size(262, 20);
            this.lookUpEditDemirbasEkleDepartmanAdi.StyleController = this.layoutControl1;
            this.lookUpEditDemirbasEkleDepartmanAdi.TabIndex = 12;
            this.lookUpEditDemirbasEkleDepartmanAdi.EditValueChanged += new System.EventHandler(this.lookUpEditDemirbasEkleDepartmanAdi_EditValueChanged);
            // 
            // lookUpEditDemirbasEkleFakulteAdi
            // 
            this.lookUpEditDemirbasEkleFakulteAdi.Location = new System.Drawing.Point(90, 12);
            this.lookUpEditDemirbasEkleFakulteAdi.Name = "lookUpEditDemirbasEkleFakulteAdi";
            this.lookUpEditDemirbasEkleFakulteAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDemirbasEkleFakulteAdi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FakulteAdi", "Fakülte")});
            this.lookUpEditDemirbasEkleFakulteAdi.Properties.DisplayMember = "FakulteAdi";
            this.lookUpEditDemirbasEkleFakulteAdi.Properties.DropDownRows = 5;
            this.lookUpEditDemirbasEkleFakulteAdi.Properties.NullText = "";
            this.lookUpEditDemirbasEkleFakulteAdi.Properties.ValueMember = "FakulteID";
            this.lookUpEditDemirbasEkleFakulteAdi.Size = new System.Drawing.Size(262, 20);
            this.lookUpEditDemirbasEkleFakulteAdi.StyleController = this.layoutControl1;
            this.lookUpEditDemirbasEkleFakulteAdi.TabIndex = 11;
            this.lookUpEditDemirbasEkleFakulteAdi.EditValueChanged += new System.EventHandler(this.lookUpEditDemirbasEkleFakulteAdi_EditValueChanged);
            // 
            // SpinEditEkleDemirbasAdet
            // 
            this.SpinEditEkleDemirbasAdet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpinEditEkleDemirbasAdet.Location = new System.Drawing.Point(90, 132);
            this.SpinEditEkleDemirbasAdet.Name = "SpinEditEkleDemirbasAdet";
            this.SpinEditEkleDemirbasAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEditEkleDemirbasAdet.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SpinEditEkleDemirbasAdet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpinEditEkleDemirbasAdet.Size = new System.Drawing.Size(262, 20);
            this.SpinEditEkleDemirbasAdet.StyleController = this.layoutControl1;
            this.SpinEditEkleDemirbasAdet.TabIndex = 10;
            // 
            // SimpleButtonEkle
            // 
            this.SimpleButtonEkle.Location = new System.Drawing.Point(12, 156);
            this.SimpleButtonEkle.Name = "SimpleButtonEkle";
            this.SimpleButtonEkle.Size = new System.Drawing.Size(340, 22);
            this.SimpleButtonEkle.StyleController = this.layoutControl1;
            this.SimpleButtonEkle.TabIndex = 1;
            this.SimpleButtonEkle.Text = "Ekle";
            this.SimpleButtonEkle.Click += new System.EventHandler(this.SimpleButtonEkle_Click);
            // 
            // TextEditEkleDemirbasFiyat
            // 
            this.TextEditEkleDemirbasFiyat.Location = new System.Drawing.Point(90, 108);
            this.TextEditEkleDemirbasFiyat.Name = "TextEditEkleDemirbasFiyat";
            this.TextEditEkleDemirbasFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TextEditEkleDemirbasFiyat.Size = new System.Drawing.Size(262, 20);
            this.TextEditEkleDemirbasFiyat.StyleController = this.layoutControl1;
            this.TextEditEkleDemirbasFiyat.TabIndex = 8;
            // 
            // TextEditEkleDemirbasAd
            // 
            this.TextEditEkleDemirbasAd.Location = new System.Drawing.Point(90, 84);
            this.TextEditEkleDemirbasAd.Name = "TextEditEkleDemirbasAd";
            this.TextEditEkleDemirbasAd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextEditEkleDemirbasAd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TextEditEkleDemirbasAd.Size = new System.Drawing.Size(262, 20);
            this.TextEditEkleDemirbasAd.StyleController = this.layoutControl1;
            this.TextEditEkleDemirbasAd.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.demirbasAdi,
            this.demirbasFiyati,
            this.layoutControlItem1,
            this.DemirbasAdet,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(364, 470);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(344, 280);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // demirbasAdi
            // 
            this.demirbasAdi.Control = this.TextEditEkleDemirbasAd;
            this.demirbasAdi.Location = new System.Drawing.Point(0, 72);
            this.demirbasAdi.Name = "demirbasAdi";
            this.demirbasAdi.Size = new System.Drawing.Size(344, 24);
            this.demirbasAdi.Text = "Demirbaş Adı:";
            this.demirbasAdi.TextSize = new System.Drawing.Size(75, 13);
            // 
            // demirbasFiyati
            // 
            this.demirbasFiyati.Control = this.TextEditEkleDemirbasFiyat;
            this.demirbasFiyati.Location = new System.Drawing.Point(0, 96);
            this.demirbasFiyati.Name = "demirbasFiyati";
            this.demirbasFiyati.Size = new System.Drawing.Size(344, 24);
            this.demirbasFiyati.Text = "Fiyat:";
            this.demirbasFiyati.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.SimpleButtonEkle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(344, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // DemirbasAdet
            // 
            this.DemirbasAdet.Control = this.SpinEditEkleDemirbasAdet;
            this.DemirbasAdet.Location = new System.Drawing.Point(0, 120);
            this.DemirbasAdet.Name = "DemirbasAdet";
            this.DemirbasAdet.Size = new System.Drawing.Size(344, 24);
            this.DemirbasAdet.Text = "Demirbaş Adet";
            this.DemirbasAdet.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEditDemirbasEkleFakulteAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(344, 24);
            this.layoutControlItem2.Text = "Fakülte Adı:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEditDemirbasEkleDepartmanAdi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(344, 24);
            this.layoutControlItem3.Text = "Departman Adı:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lookUpEditDemirbasTur;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(344, 24);
            this.layoutControlItem4.Text = "Demirbaş Türü";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // frmDemirbasEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 470);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDemirbasEkle";
            this.Text = "Demirbaş Ekle";
            this.Load += new System.EventHandler(this.frmDemirbasEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDemirbasTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDemirbasEkleDepartmanAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDemirbasEkleFakulteAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditEkleDemirbasAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditEkleDemirbasFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditEkleDemirbasAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit TextEditEkleDemirbasAd;
        private DevExpress.XtraLayout.LayoutControlItem demirbasAdi;
        private DevExpress.XtraEditors.TextEdit TextEditEkleDemirbasFiyat;
        private DevExpress.XtraLayout.LayoutControlItem demirbasFiyati;
        private DevExpress.XtraEditors.SimpleButton SimpleButtonEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit SpinEditEkleDemirbasAdet;
        private DevExpress.XtraLayout.LayoutControlItem DemirbasAdet;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDemirbasEkleDepartmanAdi;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDemirbasEkleFakulteAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDemirbasTur;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}