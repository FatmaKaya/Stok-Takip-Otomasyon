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
    public partial class MDI : DevExpress.XtraEditors.XtraForm
    {
        public MDI()
        {
            InitializeComponent();
        }
        private void MDI_Load(object sender, EventArgs e)
        {
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private void PersonelUzeindekiDemirbas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPersonelUzerindekiDemirbasArama frm = new frmPersonelUzerindekiDemirbasArama();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbasEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDemirbasEkle frm = new frmDemirbasEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DemirbasSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDemirbasSil frm = new frmDemirbasSil();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DemirbasSayisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDemirbasSayisiniArama frm = new frmDemirbasSayisiniArama();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OdalaraDemirbaslarıEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdalaraDemirbasleriEkle frm = new frmOdalaraDemirbasleriEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DemirbasGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDemirbasGuncelle frm = new frmDemirbasGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OdaEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdaBilgileriEkle frm = new frmOdaBilgileriEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OdaGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdaBilgileriGuncelle frm = new frmOdaBilgileriGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OdaSilme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdaSil frm = new frmOdaSil();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OdaDemirbasListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdaDemirbasListesi frm = new frmOdaDemirbasListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}