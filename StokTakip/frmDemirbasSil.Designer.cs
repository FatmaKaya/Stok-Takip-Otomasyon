namespace StokTakip
{
    partial class frmDemirbasSil
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
            this.simpleButtonSilAra = new DevExpress.XtraEditors.SimpleButton();
            this.GridControlSilDemirbasSil = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SimpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.TextEditSilDemirbasAd = new DevExpress.XtraEditors.TextEdit();
            this.SpinEditSilDemirbasAdet = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.demirbasAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.DemirbasAdet = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSilDemirbasSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditSilDemirbasAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditSilDemirbasAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonSilAra);
            this.layoutControl1.Controls.Add(this.GridControlSilDemirbasSil);
            this.layoutControl1.Controls.Add(this.SimpleButtonSil);
            this.layoutControl1.Controls.Add(this.TextEditSilDemirbasAd);
            this.layoutControl1.Controls.Add(this.SpinEditSilDemirbasAdet);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(364, 482);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonSilAra
            // 
            this.simpleButtonSilAra.Location = new System.Drawing.Point(255, 12);
            this.simpleButtonSilAra.Name = "simpleButtonSilAra";
            this.simpleButtonSilAra.Size = new System.Drawing.Size(97, 22);
            this.simpleButtonSilAra.StyleController = this.layoutControl1;
            this.simpleButtonSilAra.TabIndex = 13;
            this.simpleButtonSilAra.Text = "Ara";
            // 
            // GridControlSilDemirbasSil
            // 
            this.GridControlSilDemirbasSil.Location = new System.Drawing.Point(12, 38);
            this.GridControlSilDemirbasSil.MainView = this.gridView1;
            this.GridControlSilDemirbasSil.Name = "GridControlSilDemirbasSil";
            this.GridControlSilDemirbasSil.Size = new System.Drawing.Size(340, 384);
            this.GridControlSilDemirbasSil.TabIndex = 12;
            this.GridControlSilDemirbasSil.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridControlSilDemirbasSil;
            this.gridView1.Name = "gridView1";
            // 
            // SimpleButtonSil
            // 
            this.SimpleButtonSil.Location = new System.Drawing.Point(12, 450);
            this.SimpleButtonSil.Name = "SimpleButtonSil";
            this.SimpleButtonSil.Size = new System.Drawing.Size(340, 20);
            this.SimpleButtonSil.StyleController = this.layoutControl1;
            this.SimpleButtonSil.TabIndex = 14;
            this.SimpleButtonSil.Click += new System.EventHandler(this.SimpleButtonSil_Click_1);
            // 
            // TextEditSilDemirbasAd
            // 
            this.TextEditSilDemirbasAd.Location = new System.Drawing.Point(85, 12);
            this.TextEditSilDemirbasAd.Name = "TextEditSilDemirbasAd";
            this.TextEditSilDemirbasAd.Size = new System.Drawing.Size(166, 20);
            this.TextEditSilDemirbasAd.StyleController = this.layoutControl1;
            this.TextEditSilDemirbasAd.TabIndex = 6;
            // 
            // SpinEditSilDemirbasAdet
            // 
            this.SpinEditSilDemirbasAdet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEditSilDemirbasAdet.Location = new System.Drawing.Point(85, 426);
            this.SpinEditSilDemirbasAdet.Name = "SpinEditSilDemirbasAdet";
            this.SpinEditSilDemirbasAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEditSilDemirbasAdet.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SpinEditSilDemirbasAdet.Size = new System.Drawing.Size(267, 20);
            this.SpinEditSilDemirbasAdet.StyleController = this.layoutControl1;
            this.SpinEditSilDemirbasAdet.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.demirbasAdi,
            this.DemirbasAdet,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(364, 482);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // demirbasAdi
            // 
            this.demirbasAdi.Control = this.TextEditSilDemirbasAd;
            this.demirbasAdi.CustomizationFormText = "Demirbaş Adı:";
            this.demirbasAdi.Location = new System.Drawing.Point(0, 0);
            this.demirbasAdi.Name = "demirbasAdi";
            this.demirbasAdi.Size = new System.Drawing.Size(243, 26);
            this.demirbasAdi.Text = "Demirbaş Adı:";
            this.demirbasAdi.TextSize = new System.Drawing.Size(70, 13);
            // 
            // DemirbasAdet
            // 
            this.DemirbasAdet.Control = this.SpinEditSilDemirbasAdet;
            this.DemirbasAdet.CustomizationFormText = "Demirbaş Adet";
            this.DemirbasAdet.Location = new System.Drawing.Point(0, 414);
            this.DemirbasAdet.Name = "DemirbasAdet";
            this.DemirbasAdet.Size = new System.Drawing.Size(344, 24);
            this.DemirbasAdet.Text = "Demirbaş Adet";
            this.DemirbasAdet.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.SimpleButtonSil;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 438);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(344, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GridControlSilDemirbasSil;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(344, 388);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonSilAra;
            this.layoutControlItem3.Location = new System.Drawing.Point(243, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(101, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmDemirbasSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 482);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDemirbasSil";
            this.Text = "Demirbaş Sil ";
            this.Load += new System.EventHandler(this.frmDemirbasSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSilDemirbasSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditSilDemirbasAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditSilDemirbasAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TextEditSilDemirbasAd;
        private DevExpress.XtraLayout.LayoutControlItem demirbasAdi;
        private DevExpress.XtraEditors.SimpleButton SimpleButtonSil;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit SpinEditSilDemirbasAdet;
        private DevExpress.XtraLayout.LayoutControlItem DemirbasAdet;
        private DevExpress.XtraGrid.GridControl GridControlSilDemirbasSil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSilAra;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}