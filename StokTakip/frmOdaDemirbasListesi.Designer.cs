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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonODLRapor = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonODLArama = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOdaDemirbasListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditODLOdaAdi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.OdaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdaDemirbasListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditODLOdaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonODLRapor);
            this.layoutControl1.Controls.Add(this.simpleButtonODLArama);
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
            // simpleButtonODLRapor
            // 
            this.simpleButtonODLRapor.Location = new System.Drawing.Point(12, 454);
            this.simpleButtonODLRapor.Name = "simpleButtonODLRapor";
            this.simpleButtonODLRapor.Size = new System.Drawing.Size(559, 22);
            this.simpleButtonODLRapor.StyleController = this.layoutControl1;
            this.simpleButtonODLRapor.TabIndex = 7;
            this.simpleButtonODLRapor.Text = "Rapor Al";
            // 
            // simpleButtonODLArama
            // 
            this.simpleButtonODLArama.Location = new System.Drawing.Point(431, 12);
            this.simpleButtonODLArama.Name = "simpleButtonODLArama";
            this.simpleButtonODLArama.Size = new System.Drawing.Size(140, 22);
            this.simpleButtonODLArama.StyleController = this.layoutControl1;
            this.simpleButtonODLArama.TabIndex = 6;
            this.simpleButtonODLArama.Text = "Ara";
            // 
            // gridControlOdaDemirbasListesi
            // 
            this.gridControlOdaDemirbasListesi.Location = new System.Drawing.Point(12, 38);
            this.gridControlOdaDemirbasListesi.MainView = this.gridView1;
            this.gridControlOdaDemirbasListesi.Name = "gridControlOdaDemirbasListesi";
            this.gridControlOdaDemirbasListesi.Size = new System.Drawing.Size(559, 412);
            this.gridControlOdaDemirbasListesi.TabIndex = 5;
            this.gridControlOdaDemirbasListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlOdaDemirbasListesi;
            this.gridView1.Name = "gridView1";
            // 
            // textEditODLOdaAdi
            // 
            this.textEditODLOdaAdi.Location = new System.Drawing.Point(60, 12);
            this.textEditODLOdaAdi.Name = "textEditODLOdaAdi";
            this.textEditODLOdaAdi.Size = new System.Drawing.Size(367, 20);
            this.textEditODLOdaAdi.StyleController = this.layoutControl1;
            this.textEditODLOdaAdi.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.OdaAdi,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
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
            this.OdaAdi.Size = new System.Drawing.Size(419, 26);
            this.OdaAdi.Text = "Oda Adı: ";
            this.OdaAdi.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlOdaDemirbasListesi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(563, 416);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonODLArama;
            this.layoutControlItem2.Location = new System.Drawing.Point(419, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(144, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonODLRapor;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 442);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(563, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmOdaDemirbasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 488);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmOdaDemirbasListesi";
            this.Text = "Oda Demirbaş Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdaDemirbasListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditODLOdaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonODLRapor;
        private DevExpress.XtraEditors.SimpleButton simpleButtonODLArama;
        private DevExpress.XtraGrid.GridControl gridControlOdaDemirbasListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEditODLOdaAdi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem OdaAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}