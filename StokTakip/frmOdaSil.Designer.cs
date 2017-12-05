namespace StokTakip
{
    partial class frmOdaSil
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEditSilOdaAdiArama = new DevExpress.XtraEditors.TextEdit();
            this.SilOdaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridControlSilOdaBilgileri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonSilOda = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonSilOdaAdiArama = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSilOdaAdiArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilOdaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSilOdaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonSilOdaAdiArama);
            this.layoutControl1.Controls.Add(this.simpleButtonSilOda);
            this.layoutControl1.Controls.Add(this.gridControlSilOdaBilgileri);
            this.layoutControl1.Controls.Add(this.textEditSilOdaAdiArama);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(496, 415);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.SilOdaAdi,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(496, 415);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // textEditSilOdaAdiArama
            // 
            this.textEditSilOdaAdiArama.Location = new System.Drawing.Point(61, 12);
            this.textEditSilOdaAdiArama.Name = "textEditSilOdaAdiArama";
            this.textEditSilOdaAdiArama.Size = new System.Drawing.Size(314, 20);
            this.textEditSilOdaAdiArama.StyleController = this.layoutControl1;
            this.textEditSilOdaAdiArama.TabIndex = 4;
            // 
            // SilOdaAdi
            // 
            this.SilOdaAdi.Control = this.textEditSilOdaAdiArama;
            this.SilOdaAdi.Location = new System.Drawing.Point(0, 0);
            this.SilOdaAdi.Name = "SilOdaAdi";
            this.SilOdaAdi.Size = new System.Drawing.Size(367, 26);
            this.SilOdaAdi.Text = "Oda Adı: ";
            this.SilOdaAdi.TextSize = new System.Drawing.Size(45, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 385);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(476, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridControlSilOdaBilgileri
            // 
            this.gridControlSilOdaBilgileri.Location = new System.Drawing.Point(12, 38);
            this.gridControlSilOdaBilgileri.MainView = this.gridView1;
            this.gridControlSilOdaBilgileri.Name = "gridControlSilOdaBilgileri";
            this.gridControlSilOdaBilgileri.Size = new System.Drawing.Size(472, 329);
            this.gridControlSilOdaBilgileri.TabIndex = 5;
            this.gridControlSilOdaBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSilOdaBilgileri;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlSilOdaBilgileri;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(476, 333);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleButtonSilOda
            // 
            this.simpleButtonSilOda.Location = new System.Drawing.Point(12, 371);
            this.simpleButtonSilOda.Name = "simpleButtonSilOda";
            this.simpleButtonSilOda.Size = new System.Drawing.Size(472, 22);
            this.simpleButtonSilOda.StyleController = this.layoutControl1;
            this.simpleButtonSilOda.TabIndex = 6;
            this.simpleButtonSilOda.Text = "Oda Sil";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonSilOda;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 359);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(476, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleButtonSilOdaAdiArama
            // 
            this.simpleButtonSilOdaAdiArama.Location = new System.Drawing.Point(379, 12);
            this.simpleButtonSilOdaAdiArama.Name = "simpleButtonSilOdaAdiArama";
            this.simpleButtonSilOdaAdiArama.Size = new System.Drawing.Size(105, 22);
            this.simpleButtonSilOdaAdiArama.StyleController = this.layoutControl1;
            this.simpleButtonSilOdaAdiArama.TabIndex = 7;
            this.simpleButtonSilOdaAdiArama.Text = "Ara";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonSilOdaAdiArama;
            this.layoutControlItem3.Location = new System.Drawing.Point(367, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmOdaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 415);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmOdaSil";
            this.Text = "Oda Sil";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSilOdaAdiArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilOdaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSilOdaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSilOdaAdiArama;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSilOda;
        private DevExpress.XtraGrid.GridControl gridControlSilOdaBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEditSilOdaAdiArama;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem SilOdaAdi;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}