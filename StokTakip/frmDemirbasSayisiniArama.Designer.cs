namespace StokTakip
{
    partial class frmDemirbasSayisiniArama
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
            this.sbArama = new DevExpress.XtraEditors.SimpleButton();
            this.seaAdet = new DevExpress.XtraEditors.SpinEdit();
            this.dbAAlimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dbAFiyat = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEditDemirbasTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dbADemirbasAdi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.demirbasAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.demirbaşTuru = new DevExpress.XtraLayout.LayoutControlItem();
            this.fiyat = new DevExpress.XtraLayout.LayoutControlItem();
            this.alimTarihi = new DevExpress.XtraLayout.LayoutControlItem();
            this.adet = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcDemirbasArama = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seaAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAAlimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAAlimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDemirbasTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbADemirbasAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbaşTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDemirbasArama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbArama);
            this.layoutControl1.Controls.Add(this.seaAdet);
            this.layoutControl1.Controls.Add(this.dbAAlimTarihi);
            this.layoutControl1.Controls.Add(this.dbAFiyat);
            this.layoutControl1.Controls.Add(this.comboBoxEditDemirbasTuru);
            this.layoutControl1.Controls.Add(this.dbADemirbasAdi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(319, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbArama
            // 
            this.sbArama.Location = new System.Drawing.Point(12, 132);
            this.sbArama.Name = "sbArama";
            this.sbArama.Size = new System.Drawing.Size(295, 22);
            this.sbArama.StyleController = this.layoutControl1;
            this.sbArama.TabIndex = 9;
            this.sbArama.Text = "Arama";
            this.sbArama.Click += new System.EventHandler(this.sbArama_Click);
            // 
            // seaAdet
            // 
            this.seaAdet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seaAdet.Location = new System.Drawing.Point(88, 108);
            this.seaAdet.Name = "seaAdet";
            this.seaAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seaAdet.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.seaAdet.Size = new System.Drawing.Size(219, 20);
            this.seaAdet.StyleController = this.layoutControl1;
            this.seaAdet.TabIndex = 8;
            // 
            // dbAAlimTarihi
            // 
            this.dbAAlimTarihi.EditValue = null;
            this.dbAAlimTarihi.Location = new System.Drawing.Point(88, 84);
            this.dbAAlimTarihi.Name = "dbAAlimTarihi";
            this.dbAAlimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dbAAlimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dbAAlimTarihi.Size = new System.Drawing.Size(219, 20);
            this.dbAAlimTarihi.StyleController = this.layoutControl1;
            this.dbAAlimTarihi.TabIndex = 7;
            // 
            // dbAFiyat
            // 
            this.dbAFiyat.Location = new System.Drawing.Point(88, 60);
            this.dbAFiyat.Name = "dbAFiyat";
            this.dbAFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.dbAFiyat.Size = new System.Drawing.Size(219, 20);
            this.dbAFiyat.StyleController = this.layoutControl1;
            this.dbAFiyat.TabIndex = 6;
            // 
            // comboBoxEditDemirbasTuru
            // 
            this.comboBoxEditDemirbasTuru.Location = new System.Drawing.Point(88, 36);
            this.comboBoxEditDemirbasTuru.Name = "comboBoxEditDemirbasTuru";
            this.comboBoxEditDemirbasTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDemirbasTuru.Size = new System.Drawing.Size(219, 20);
            this.comboBoxEditDemirbasTuru.StyleController = this.layoutControl1;
            this.comboBoxEditDemirbasTuru.TabIndex = 5;
            // 
            // dbADemirbasAdi
            // 
            this.dbADemirbasAdi.Location = new System.Drawing.Point(88, 12);
            this.dbADemirbasAdi.Name = "dbADemirbasAdi";
            this.dbADemirbasAdi.Size = new System.Drawing.Size(219, 20);
            this.dbADemirbasAdi.StyleController = this.layoutControl1;
            this.dbADemirbasAdi.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.demirbasAdi,
            this.emptySpaceItem1,
            this.demirbaşTuru,
            this.fiyat,
            this.alimTarihi,
            this.adet,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(319, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // demirbasAdi
            // 
            this.demirbasAdi.Control = this.dbADemirbasAdi;
            this.demirbasAdi.Location = new System.Drawing.Point(0, 0);
            this.demirbasAdi.Name = "demirbasAdi";
            this.demirbasAdi.Size = new System.Drawing.Size(299, 24);
            this.demirbasAdi.Text = "Demirbaş Adı:";
            this.demirbasAdi.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 146);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(299, 195);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // demirbaşTuru
            // 
            this.demirbaşTuru.Control = this.comboBoxEditDemirbasTuru;
            this.demirbaşTuru.Location = new System.Drawing.Point(0, 24);
            this.demirbaşTuru.Name = "demirbaşTuru";
            this.demirbaşTuru.Size = new System.Drawing.Size(299, 24);
            this.demirbaşTuru.Text = "Demirbaş Türü:";
            this.demirbaşTuru.TextSize = new System.Drawing.Size(73, 13);
            // 
            // fiyat
            // 
            this.fiyat.Control = this.dbAFiyat;
            this.fiyat.Location = new System.Drawing.Point(0, 48);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(299, 24);
            this.fiyat.Text = "Fiyat:";
            this.fiyat.TextSize = new System.Drawing.Size(73, 13);
            // 
            // alimTarihi
            // 
            this.alimTarihi.Control = this.dbAAlimTarihi;
            this.alimTarihi.Location = new System.Drawing.Point(0, 72);
            this.alimTarihi.Name = "alimTarihi";
            this.alimTarihi.Size = new System.Drawing.Size(299, 24);
            this.alimTarihi.Text = "Alım Tarihi";
            this.alimTarihi.TextSize = new System.Drawing.Size(73, 13);
            // 
            // adet
            // 
            this.adet.Control = this.seaAdet;
            this.adet.Location = new System.Drawing.Point(0, 96);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(299, 24);
            this.adet.Text = "Adet:";
            this.adet.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbArama;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(299, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gcDemirbasArama);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(319, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(509, 361);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(509, 361);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // gcDemirbasArama
            // 
            this.gcDemirbasArama.Location = new System.Drawing.Point(12, 12);
            this.gcDemirbasArama.MainView = this.gridView1;
            this.gcDemirbasArama.Name = "gcDemirbasArama";
            this.gcDemirbasArama.Size = new System.Drawing.Size(485, 337);
            this.gcDemirbasArama.TabIndex = 4;
            this.gcDemirbasArama.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDemirbasArama;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcDemirbasArama;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(489, 341);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmDemirbasSayisiniArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 361);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDemirbasSayisiniArama";
            this.Text = "Demirbaş Sayısını Arama";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seaAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAAlimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAAlimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDemirbasTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbADemirbasAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbaşTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDemirbasArama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit dbADemirbasAdi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem demirbasAdi;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDemirbasTuru;
        private DevExpress.XtraLayout.LayoutControlItem demirbaşTuru;
        private DevExpress.XtraEditors.TextEdit dbAFiyat;
        private DevExpress.XtraLayout.LayoutControlItem fiyat;
        private DevExpress.XtraEditors.SimpleButton sbArama;
        private DevExpress.XtraEditors.SpinEdit seaAdet;
        private DevExpress.XtraEditors.DateEdit dbAAlimTarihi;
        private DevExpress.XtraLayout.LayoutControlItem alimTarihi;
        private DevExpress.XtraLayout.LayoutControlItem adet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcDemirbasArama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}