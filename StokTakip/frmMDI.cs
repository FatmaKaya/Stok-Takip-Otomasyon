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
        Personeller kullanci = frmKullaniciGiris.user;   // Giriş yapan Kullanıcı

        private void frmMDI_Load(object sender, EventArgs e)
        {
            if (kullanci.YetkiID==0)  // Yetkisi 0 olan kullanıcaya gelecek sekmelerin ayarlanması
            {
                barHeaderItemKullanici.Caption = kullanci.PersonelAdi;
                ribbonPageStokIslemleri.Visible = false;
                ribbonPageOdaTanımlama.Visible = false;
                ribbonPageOdaDemirbasIslemleri.Visible = false;
            }
            else if(kullanci.YetkiID==1)  // Yetkisi 0 olan kullanıcaya gelecek sekmelerin ayarlanması
            {
                barHeaderItemKullanici.Caption = kullanci.PersonelAdi;
                ribbonPageStokIslemleri.Visible = false;
                ribbonPageOdaTanımlama.Visible = false;
            }
            else  // Yetkisi 2 olan kullanıcaya gelecek sekmelerin ayarlanması
            {
                barHeaderItemKullanici.Caption = kullanci.PersonelAdi;
            }
        }
        private void PersonelUzeindekiDemirbas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Personel üzerindeki demirbaşları Arama işlemleri için
            frmPersonelUzerindekiDemirbasArama frm = new frmPersonelUzerindekiDemirbasArama();
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
        {   // Demirbaşları odalardan kaldırmak için
            frmDemirbaslariOdalardanKaldirma frm = new frmDemirbaslariOdalardanKaldirma();
            frm.MdiParent = this;
            frm.Show();
        }
        private void OdaDemirbasListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   // Oda Demirbaş listesini görmek için
            frmOdaDemirbasListesi frm = new frmOdaDemirbasListesi();
            frm.MdiParent = this;
            frm.Show();
        }
        private void DemirbasSayisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   // Demirbas Sayisini arama işlemleri için
            frmDemirbasSayisiniArama frm = new frmDemirbasSayisiniArama();
            frm.MdiParent = this;
            frm.Show();
        }
        public int CikisYap()
        {
            int kontrol = 0;
            //Çıkış onay bilgisi
            DialogResult rs = DevExpress.XtraEditors.XtraMessageBox.Show("Çıkış yapmak istediğinizden EMİN MİSİNİZ ?", "Çıkış Bilgisi", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)//Yes butonunu tıklar isek
            {// giriş ekranına tekrar geç
                kontrol = 1;
                frmKullaniciGiris frmGiris = new frmKullaniciGiris();
                this.Hide();
                frmGiris.Show();
            }
            return kontrol;
        }
        private void barHeaderItemCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {// Çıkış işlemi yapmak istediğinde 
            CikisYap();
        }

        private void frmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void info_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmInfo frm = new frmInfo();
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}