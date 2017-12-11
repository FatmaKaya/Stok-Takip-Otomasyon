using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StokTakip
{
    public partial class frmMDI : DevExpress.XtraEditors.XtraForm
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
        private void PersonelUzeindekiDemirbas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Personel üzerindeki demirbaşları Arama işlemleri için
            frmPersonelUzerindekiDemirbasArama frm = new frmPersonelUzerindekiDemirbasArama();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbasSayisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Demirbaş sayılarını öğrenmek için
            frmDemirbasSayisiniArama frm = new frmDemirbasSayisiniArama();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbasEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Stoğa demirbaş eklemek için 
            frmDemirbasEkle frm = new frmDemirbasEkle();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbasGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Stoktaki demirbaşları güncellemek için 
            frmDemirbasGuncelle frm = new frmDemirbasGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbasKaldir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Stoktaki demirbaşları kaldırmak için
            frmDemirbasKaldir frm = new frmDemirbasKaldir();
            frm.MdiParent = this;
            frm.Show();
        }
        private void OdaEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Oda tanımlamak için
            frmOdaBilgileriEkle frm = new frmOdaBilgileriEkle();
            frm.MdiParent = this;
            frm.Show();
        }
        private void OdaGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Odaları güncellemek için
            frmOdaBilgileriGuncelle frm = new frmOdaBilgileriGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }
        private void OdalaraDemirbaslarıEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Odalara demirbaşları eklemek için 
            frmOdalaraDemirbasleriEkle frm = new frmOdalaraDemirbasleriEkle();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbaslariOdadanKaldirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Demirbaşları odalardan kaldırmak için
            frmDemirbaslariOdalardanKaldirma frm = new frmDemirbaslariOdalardanKaldirma();
            frm.MdiParent = this;
            frm.Show();
        }
        private void OdaDemirbasListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Oda Demirbaş listesini görmek için
            frmOdaDemirbasListesi frm = new frmOdaDemirbasListesi();
            frm.MdiParent = this;
            frm.Show();
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }   
    }
}