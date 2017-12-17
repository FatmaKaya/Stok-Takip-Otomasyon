namespace StokTakip
{
    partial class frmOdaDemirbasListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaDemirbasListesi));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButtonODLRapor = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOdaDemirbasListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditODLOdaAdi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.OdaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdaDemirbasListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditODLOdaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.simpleButtonODLRapor);
            this.layoutControl1.Controls.Add(this.gridControlOdaDemirbasListesi);
            this.layoutControl1.Controls.Add(this.textEditODLOdaAdi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(583, 488);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(12, 438);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.Root;
            this.layoutControl2.Size = new System.Drawing.Size(395, 38);
            this.layoutControl2.TabIndex = 8;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(395, 38);
            this.Root.TextVisible = false;
            // 
            // simpleButtonODLRapor
            // 
            this.simpleButtonODLRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonODLRapor.ImageOptions.Image")));
            this.simpleButtonODLRapor.Location = new System.Drawing.Point(411, 438);
            this.simpleButtonODLRapor.Name = "simpleButtonODLRapor";
            this.simpleButtonODLRapor.Size = new System.Drawing.Size(160, 38);
            this.simpleButtonODLRapor.StyleController = this.layoutControl1;
            this.simpleButtonODLRapor.TabIndex = 7;
            this.simpleButtonODLRapor.Text = "Rapor Al";
            this.simpleButtonODLRapor.Click += new System.EventHandler(this.simpleButtonODLRapor_Click);
            // 
            // gridControlOdaDemirbasListesi
            // 
            this.gridControlOdaDemirbasListesi.Location = new System.Drawing.Point(12, 36);
            this.gridControlOdaDemirbasListesi.MainView = this.gridView1;
            this.gridControlOdaDemirbasListesi.Name = "gridControlOdaDemirbasListesi";
            this.gridControlOdaDemirbasListesi.Size = new System.Drawing.Size(559, 398);
            this.gridControlOdaDemirbasListesi.TabIndex = 5;
            this.gridControlOdaDemirbasListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControlOdaDemirbasListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Oda Adı";
            this.gridColumn1.FieldName = "OdaAdi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fakülte Adı";
            this.gridColumn2.FieldName = "FakulteAdi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Departman Adı";
            this.gridColumn3.FieldName = "DepartmanAdi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Oda Sorumlusu";
            this.gridColumn4.FieldName = "PersonelAdi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Oda ID";
            this.gridColumn5.FieldName = "OdaID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // textEditODLOdaAdi
            // 
            this.textEditODLOdaAdi.Location = new System.Drawing.Point(60, 12);
            this.textEditODLOdaAdi.Name = "textEditODLOdaAdi";
            this.textEditODLOdaAdi.Properties.MaxLength = 25;
            this.textEditODLOdaAdi.Size = new System.Drawing.Size(511, 20);
            this.textEditODLOdaAdi.StyleController = this.layoutControl1;
            this.textEditODLOdaAdi.TabIndex = 4;
            this.textEditODLOdaAdi.EditValueChanged += new System.EventHandler(this.textEditODLOdaAdi_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.OdaAdi,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(583, 488);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // OdaAdi
            // 
            this.OdaAdi.Control = this.textEditODLOdaAdi;
            this.OdaAdi.Location = new System.Drawing.Point(0, 0);
            this.OdaAdi.Name = "OdaAdi";
            this.OdaAdi.Size = new System.Drawing.Size(563, 24);
            this.OdaAdi.Text = "Oda Adı: ";
            this.OdaAdi.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlOdaDemirbasListesi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(563, 402);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonODLRapor;
            this.layoutControlItem3.Location = new System.Drawing.Point(399, 426);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(164, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 426);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(399, 42);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmOdaDemirbasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 488);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmOdaDemirbasListesi";
            this.Text = "Oda Demirbaş Listesi";
            this.Load += new System.EventHandler(this.frmOdaDemirbasListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdaDemirbasListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditODLOdaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonODLRapor;
        private DevExpress.XtraGrid.GridControl gridControlOdaDemirbasListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEditODLOdaAdi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem OdaAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}