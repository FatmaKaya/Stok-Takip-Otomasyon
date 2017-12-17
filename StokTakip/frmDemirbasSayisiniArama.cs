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
    public partial class frmDemirbasSayisiniArama : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasSayisiniArama()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        string demirbasAdi;
        int demirbasTurId, demirbasAdet;
        float demirbasFiyat;
        DateTime demirbasAlimTarihi;

        private void frmDemirbasSayisiniArama_Load(object sender, EventArgs e)
        {//Form yüklendiğinde toolların durumu
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            lookUpEditDemirbasTuru.Properties.DataSource = db.DemirbasTurleris.ToList();

            TextEditDemirbasAdi.Text = "";      
            TextEditFiyat.Text = "0";      
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
            SpinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");
        }
        private void checkEditDemirbasAdinaGore_CheckedChanged(object sender, EventArgs e)
        {//Demirbaş adına göre arama yapılacağı zaman toolların durumu
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditDemirbasAdinaGore.Checked = false;

         
            TextEditFiyat.Text = "0"; 
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
            SpinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");
        }
        private void checkEditDemirbasTuruneGore_CheckedChanged(object sender, EventArgs e)
        {//Demirbaş türüne göre arama yapılacağı zaman toolların durumu
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditDemirbasTuruneGore.Checked = false;

            TextEditDemirbasAdi.Text = "";
            TextEditFiyat.Text = "0";
            SpinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");

        }
        private void lookUpEditDemirbasTuru_EditValueChanged(object sender, EventArgs e)
        {//tür seçimi
            demirbasTurId = Convert.ToInt32(lookUpEditDemirbasTuru.EditValue);

        }
        private void checkEditFiyatinaGore_CheckedChanged(object sender, EventArgs e)
        {//Demirbaş Fiyatına göre arama yapılacağı zaman toolların durumu
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditFiyatinaGore.Checked = false;

            TextEditDemirbasAdi.Text = "";
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
            SpinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");
        }
        private void checkEditAlimTarihineGore_CheckedChanged(object sender, EventArgs e)
        {//Demirbaş alım tarihine göre arama yapılacağı zaman toolların durumu
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditAlimTarihineGore.Checked = false;

            TextEditDemirbasAdi.Text = "";
            lookUpEditDemirbasTuru.EditValue = 0;
            TextEditFiyat.Text = "0";
            demirbasTurId = 0;
            SpinEditAdet.EditValue = 0;
            demirbasAdet = 0;
        }
        private void DateTimePickerAlimTarihi_EditValueChanged(object sender, EventArgs e)
        {//tarih seçimi
            demirbasAlimTarihi =Convert.ToDateTime(DateTimePickerAlimTarihi.EditValue.ToString());
        }
        private void checkEditAdetineGore_CheckedChanged(object sender, EventArgs e)
        {//Demirbaş adetine göre arama yapılacağı zaman toolların durumu
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditAdetineGore.Checked = false;

            TextEditDemirbasAdi.Text = "";  
            TextEditFiyat.Text = "0";
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
        }
        private void SpinEditAdet_EditValueChanged(object sender, EventArgs e)
        {//adet seçimi
            demirbasAdet = Convert.ToInt32(SpinEditAdet.EditValue);
        }
        private void SimpleButtonArama_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (TextEditDemirbasAdi.Text != "")
                    {//demirbas adına göre arama yapıldığında yapılacak işlemler

                        demirbasAdi = TextEditDemirbasAdi.Text;
                        GridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasAdi == demirbasAdi).ToList();
                        GridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.DemirbasAdi == demirbasAdi).ToList();
                    }
                    if (demirbasTurId != 0)
                    {//demirbas türüne göre arama yapıldığında yapılacak işlemler
                        GridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasTurID == demirbasTurId).ToList();
                        GridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.DemirbasTurID == demirbasTurId).ToList();
                    }
                    if (TextEditFiyat.Text != "0")
                    {//demirbas fiyatına göre arama yapıldığında yapılacak işlemler
                        demirbasFiyat = float.Parse(TextEditFiyat.Text);
                        GridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.Fiyat == demirbasFiyat).ToList();
                        GridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.Fiyat == demirbasFiyat).ToList();
                    }
                    if (demirbasAlimTarihi != Convert.ToDateTime("01.01.0001"))
                    {//demirbas alım tarihine göre arama yapıldığında yapılacak işlemler
                        GridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.AlimTarihi == demirbasAlimTarihi).ToList();
                        GridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.AlimTarihi == demirbasAlimTarihi).ToList();
                    }
                    if (demirbasAdet != 0)
                    {//demirbas adetine göre arama yapıldığında yapılacak işlemler
                        GridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasAdet == demirbasAdet).ToList();
                        GridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.DemirbasAdet == demirbasAdet).ToList();
                    }
                    if (TextEditDemirbasAdi.Text == "" && demirbasTurId == 0 && TextEditFiyat.Text == "0" && demirbasAlimTarihi == Convert.ToDateTime("01.01.0001") && demirbasAdet == 0)
                    {//bütün alanalar boşsa
                        XtraMessageBox.Show("Lütfen alanları kontrol ederek tekrar deneyiniz..");
                    }
                }
                catch
                {//diğer hatalarda 
                    XtraMessageBox.Show("Lütfen alanları kontrol ederek tekrar deneyiniz..");
                }
            }
        }   
    }
}