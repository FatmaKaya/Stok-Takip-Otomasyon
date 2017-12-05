namespace StokTakip
{
    partial class MDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.rCMDI = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.PersonelUzeindekiDemirbas = new DevExpress.XtraBars.BarButtonItem();
            this.DemirbasSayisi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.DemirbasEkle = new DevExpress.XtraBars.BarButtonItem();
            this.DemirbasSil = new DevExpress.XtraBars.BarButtonItem();
            this.OdalaraDemirbaslarıEkle = new DevExpress.XtraBars.BarButtonItem();
            this.DemirbaslariOdadanKaldirma = new DevExpress.XtraBars.BarButtonItem();
            this.OdaDemirbasListesi = new DevExpress.XtraBars.BarButtonItem();
            this.DemirbasGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.OdaEkle = new DevExpress.XtraBars.BarButtonItem();
            this.OdaGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.OdaSilme = new DevExpress.XtraBars.BarButtonItem();
            this.Aramalar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPStokIslemleri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rCMDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rCMDI
            // 
            this.rCMDI.ExpandCollapseItem.Id = 0;
            this.rCMDI.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rCMDI.ExpandCollapseItem,
            this.PersonelUzeindekiDemirbas,
            this.DemirbasSayisi,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.DemirbasEkle,
            this.DemirbasSil,
            this.OdalaraDemirbaslarıEkle,
            this.DemirbaslariOdadanKaldirma,
            this.OdaDemirbasListesi,
            this.DemirbasGuncelle,
            this.OdaEkle,
            this.OdaGuncelle,
            this.OdaSilme});
            this.rCMDI.Location = new System.Drawing.Point(0, 0);
            this.rCMDI.MaxItemId = 17;
            this.rCMDI.Name = "rCMDI";
            this.rCMDI.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Aramalar,
            this.rPStokIslemleri,
            this.ribbonPage2,
            this.ribbonPage3});
            this.rCMDI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.rCMDI.Size = new System.Drawing.Size(849, 147);
            this.rCMDI.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // PersonelUzeindekiDemirbas
            // 
            this.PersonelUzeindekiDemirbas.Caption = "Personelin Üzerindeki Demirbaşı Arama ";
            this.PersonelUzeindekiDemirbas.Id = 1;
            this.PersonelUzeindekiDemirbas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PersonelUzeindekiDemirbas.ImageOptions.Image")));
            this.PersonelUzeindekiDemirbas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PersonelUzeindekiDemirbas.ImageOptions.LargeImage")));
            this.PersonelUzeindekiDemirbas.Name = "PersonelUzeindekiDemirbas";
            this.PersonelUzeindekiDemirbas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PersonelUzeindekiDemirbas_ItemClick);
            // 
            // DemirbasSayisi
            // 
            this.DemirbasSayisi.Caption = "Demirbaş Sayısını Arama ";
            this.DemirbasSayisi.Id = 2;
            this.DemirbasSayisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemirbasSayisi.ImageOptions.Image")));
            this.DemirbasSayisi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemirbasSayisi.ImageOptions.LargeImage")));
            this.DemirbasSayisi.Name = "DemirbasSayisi";
            this.DemirbasSayisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemirbasSayisi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "       DemirBaş Kaydı      ";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "     Oda Tanımlama     ";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Oda Demirbaş İşlemleri";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // DemirbasEkle
            // 
            this.DemirbasEkle.Caption = "Demirbaş Ekle";
            this.DemirbasEkle.Id = 7;
            this.DemirbasEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemirbasEkle.ImageOptions.LargeImage")));
            this.DemirbasEkle.Name = "DemirbasEkle";
            this.DemirbasEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemirbasEkle_ItemClick);
            // 
            // DemirbasSil
            // 
            this.DemirbasSil.Caption = "Demirbaş Sil";
            this.DemirbasSil.Id = 8;
            this.DemirbasSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemirbasSil.ImageOptions.LargeImage")));
            this.DemirbasSil.Name = "DemirbasSil";
            this.DemirbasSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemirbasSil_ItemClick);
            // 
            // OdalaraDemirbaslarıEkle
            // 
            this.OdalaraDemirbaslarıEkle.Caption = "Odalara Demirbaşları Ekle";
            this.OdalaraDemirbaslarıEkle.Id = 9;
            this.OdalaraDemirbaslarıEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OdalaraDemirbaslarıEkle.ImageOptions.Image")));
            this.OdalaraDemirbaslarıEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("OdalaraDemirbaslarıEkle.ImageOptions.LargeImage")));
            this.OdalaraDemirbaslarıEkle.Name = "OdalaraDemirbaslarıEkle";
            this.OdalaraDemirbaslarıEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OdalaraDemirbaslarıEkle_ItemClick);
            // 
            // DemirbaslariOdadanKaldirma
            // 
            this.DemirbaslariOdadanKaldirma.Caption = "Demirbaşları Odadan Kaldırma";
            this.DemirbaslariOdadanKaldirma.Id = 10;
            this.DemirbaslariOdadanKaldirma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemirbaslariOdadanKaldirma.ImageOptions.Image")));
            this.DemirbaslariOdadanKaldirma.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemirbaslariOdadanKaldirma.ImageOptions.LargeImage")));
            this.DemirbaslariOdadanKaldirma.Name = "DemirbaslariOdadanKaldirma";
            this.DemirbaslariOdadanKaldirma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemirbaslariOdadanKaldirma_ItemClick);
            // 
            // OdaDemirbasListesi
            // 
            this.OdaDemirbasListesi.Caption = "Oda Demirbaş Listesi";
            this.OdaDemirbasListesi.Id = 11;
            this.OdaDemirbasListesi.Name = "OdaDemirbasListesi";
            this.OdaDemirbasListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OdaDemirbasListesi_ItemClick);
            // 
            // DemirbasGuncelle
            // 
            this.DemirbasGuncelle.Caption = "Demirbaş Güncelle";
            this.DemirbasGuncelle.Id = 12;
            this.DemirbasGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemirbasGuncelle.ImageOptions.Image")));
            this.DemirbasGuncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemirbasGuncelle.ImageOptions.LargeImage")));
            this.DemirbasGuncelle.Name = "DemirbasGuncelle";
            this.DemirbasGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemirbasGuncelle_ItemClick);
            // 
            // OdaEkle
            // 
            this.OdaEkle.Caption = "Oda Bilgileri Ekle";
            this.OdaEkle.Id = 14;
            this.OdaEkle.Name = "OdaEkle";
            this.OdaEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OdaEkle_ItemClick);
            // 
            // OdaGuncelle
            // 
            this.OdaGuncelle.Caption = "Oda Bilgileri Güncelle";
            this.OdaGuncelle.Id = 15;
            this.OdaGuncelle.Name = "OdaGuncelle";
            this.OdaGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OdaGuncelle_ItemClick);
            // 
            // OdaSilme
            // 
            this.OdaSilme.Caption = "Oda Silme";
            this.OdaSilme.Id = 16;
            this.OdaSilme.Name = "OdaSilme";
            this.OdaSilme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OdaSilme_ItemClick);
            // 
            // Aramalar
            // 
            this.Aramalar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Aramalar.Image = ((System.Drawing.Image)(resources.GetObject("Aramalar.Image")));
            this.Aramalar.Name = "Aramalar";
            this.Aramalar.Text = "Aramalar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.PersonelUzeindekiDemirbas);
            this.ribbonPageGroup1.ItemLinks.Add(this.DemirbasSayisi, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rPStokIslemleri
            // 
            this.rPStokIslemleri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rPStokIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("rPStokIslemleri.Image")));
            this.rPStokIslemleri.Name = "rPStokIslemleri";
            this.rPStokIslemleri.Text = "Stok İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.DemirbasEkle, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.DemirbasGuncelle, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.DemirbasSil, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Oda Tanımlama";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.OdaEkle, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.OdaGuncelle, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.OdaSilme, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Oda Demirbaş İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.OdalaraDemirbaslarıEkle, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.DemirbaslariOdadanKaldirma, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.OdaDemirbasListesi, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.rCMDI;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 606);
            this.Controls.Add(this.rCMDI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.MDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rCMDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rCMDI;
        private DevExpress.XtraBars.BarButtonItem PersonelUzeindekiDemirbas;
        private DevExpress.XtraBars.BarButtonItem DemirbasSayisi;
        private DevExpress.XtraBars.Ribbon.RibbonPage Aramalar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPStokIslemleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem DemirbasEkle;
        private DevExpress.XtraBars.BarButtonItem DemirbasSil;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem OdalaraDemirbaslarıEkle;
        private DevExpress.XtraBars.BarButtonItem DemirbaslariOdadanKaldirma;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem OdaDemirbasListesi;
        private DevExpress.XtraBars.BarButtonItem DemirbasGuncelle;
        private DevExpress.XtraBars.BarButtonItem OdaEkle;
        private DevExpress.XtraBars.BarButtonItem OdaGuncelle;
        private DevExpress.XtraBars.BarButtonItem OdaSilme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}