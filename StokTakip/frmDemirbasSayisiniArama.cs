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
        stokTakipEntities1 db = new stokTakipEntities1();
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

            textEditDemirbasAdi.Text = "";
            textEditFiyat.Text = "0";
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
            spinEditAdet.EditValue = 0;
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


            textEditFiyat.Text = "0";
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
            spinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");

        }
        private void textEditDemirbasAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
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


            textEditDemirbasAdi.Text = "";
            textEditFiyat.Text = "0";
            spinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");

        }
        private void lookUpEditDemirbasTuru_EditValueChanged(object sender, EventArgs e)
        {//tür seçimi
            demirbasTurId = Convert.ToInt32(lookUpEditDemirbasTuru.EditValue);
        }
        private void lookUpEditDemirbasTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
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

            textEditDemirbasAdi.Text = "";
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;
            spinEditAdet.EditValue = 0;
            demirbasAdet = 0;
            DateTimePickerAlimTarihi.EditValue = Convert.ToDateTime("01.01.0001");
            demirbasAlimTarihi = Convert.ToDateTime("01.01.0001");

        }
        private void textEditFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
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

            textEditDemirbasAdi.Text = "";
            lookUpEditDemirbasTuru.EditValue = 0;
            textEditFiyat.Text = "0";
            demirbasTurId = 0;
            spinEditAdet.EditValue = 0;
            demirbasAdet = 0;

        }    
        private void DateTimePickerAlimTarihi_EditValueChanged(object sender, EventArgs e)
        {//tarih seçimi
            demirbasAlimTarihi = Convert.ToDateTime(DateTimePickerAlimTarihi.EditValue.ToString());
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

            textEditDemirbasAdi.Text = "";
            textEditFiyat.Text = "0";
            lookUpEditDemirbasTuru.EditValue = 0;
            demirbasTurId = 0;

        }
       
        private void spinEditAdet_EditValueChanged(object sender, EventArgs e)
        {//adet seçimi
            demirbasAdet = Convert.ToInt32(spinEditAdet.EditValue);
        }

        private void spinEditAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void simpleButtonArama_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities1())
            {
                try
                {
                    if (textEditDemirbasAdi.Text != "")
                    {//demirbas adına göre arama yapıldığında yapılacak işlemler

                        demirbasAdi = textEditDemirbasAdi.Text;
                       gridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasAdi == demirbasAdi).ToList();
                        gridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.DemirbasAdi == demirbasAdi).ToList();
                    }
                    if (demirbasTurId != 0)
                    {//demirbas türüne göre arama yapıldığında yapılacak işlemler
                        gridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasTurID == demirbasTurId).ToList();
                        gridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.DemirbasTurID == demirbasTurId).ToList();
                    }
                    if (textEditFiyat.Text != "0")
                    {//demirbas fiyatına göre arama yapıldığında yapılacak işlemler
                        demirbasFiyat = float.Parse(textEditFiyat.Text);
                        gridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.Fiyat == demirbasFiyat).ToList();
                        gridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.Fiyat == demirbasFiyat).ToList();
                    }
                    if (demirbasAlimTarihi != Convert.ToDateTime("01.01.0001"))
                    {//demirbas alım tarihine göre arama yapıldığında yapılacak işlemler
                        gridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.AlimTarihi == demirbasAlimTarihi).ToList();
                        gridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.AlimTarihi == demirbasAlimTarihi).ToList();
                    }
                    if (demirbasAdet != 0)
                    {//demirbas adetine göre arama yapıldığında yapılacak işlemler
                        gridControlDemirbasSayisiAramaStoktakiDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasAdet == demirbasAdet).ToList();
                        gridControlOdalardakiDemirbaslar.DataSource = db.v_odalardakiDemirbasSayisi.Where(x => x.Adet == demirbasAdet).ToList();
                    }
                    if (textEditDemirbasAdi.Text == "" && demirbasTurId == 0 && textEditFiyat.Text == "0" && demirbasAlimTarihi == Convert.ToDateTime("01.01.0001") && demirbasAdet == 0)
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