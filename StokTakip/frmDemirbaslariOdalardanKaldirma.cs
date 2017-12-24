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
using System.Data.Entity;

namespace StokTakip
{
    public partial class frmDemirbaslariOdalardanKaldirma : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbaslariOdalardanKaldirma()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        string fakulteAdi;
        int demirbasID;
        int OdademirbasID;
        int odaID;
        string departmanAdi;
        private void frmDemirbaslariOdalardanKaldirma_Load(object sender, EventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                //view kullanarak demirbaşı olan odalar listelendi.
                gridControlDemirbaslariODalardanKaldirmaOdalar.DataSource = db.v_odalardanDemirbasKaldir.ToList();
                textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Enabled = false;
                spinEditDemirbaslariOdalardanKaldirmaAdet.Enabled = false;
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                //seçilen rowun fakülte adini fakulteAdi değişkenine ve oda IDsini odaID değişkenine atıyoruz.
                int[] RowHandles = gridView1.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                    fakulteAdi = gridView1.GetRowCellValue(i, gridView1.Columns["FakulteAdi"]).ToString();
                    odaID =Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OdaID"]));
                    departmanAdi= gridView1.GetRowCellValue(i, gridView1.Columns["DepartmanAdi"]).ToString();
                }
                //seçilen odanın fakültesine göre demirbaslar view ile listeletiliyor
                gridControlDemirbaslariOdalardanKaldirmaDemirbaslar.DataSource = db.v_odalardanDemirbasKaldirDemirbas.Where(x => x.FakulteAdi == fakulteAdi && x.DepartmanAdi==departmanAdi && x.OdaID ==odaID).ToList();
                textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Enabled = true;
            }       
        }
        private void textEditDemirbaslariOdalardanKAldirmaOdaAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                //oda adına göre arama işleminin yapılması
                string aranacakOda = textEditDemirbaslariOdalardanKAldirmaOdaAdi.Text;
                gridControlDemirbaslariODalardanKaldirmaOdalar.DataSource = db.v_odalardanDemirbasKaldir.Where(x => x.OdaAdi.ToLower().Contains(aranacakOda) || x.OdaAdi.ToUpper().Contains(aranacakOda)).ToList();
            }
        }
        private void textEditDemirbaslariOdalardanKAldirmaOdaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void textEditDemirbaslariOdalardanKaldirmaDemirbasAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                //demirbas adına göre arama işleminin yapılması
                string aranacakDemirbas = textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Text;
                gridControlDemirbaslariOdalardanKaldirmaDemirbaslar.DataSource = db.v_odalardanDemirbasKaldirDemirbas.Where(x => (x.DemirbasAdi.ToLower().Contains(aranacakDemirbas) || x.DemirbasAdi.ToUpper().Contains(aranacakDemirbas)) && x.FakulteAdi ==fakulteAdi && x.DepartmanAdi == departmanAdi).ToList();
            }
        }
        private void textEditDemirbaslariOdalardanKaldirmaDemirbasAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                //seçilen rowun demirbasID bilgisi alınıyor
                int[] RowHandles = gridView2.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                   demirbasID = Convert.ToInt32(gridView2.GetRowCellValue(i, gridView2.Columns["DemirbasID"]));
                   OdademirbasID = Convert.ToInt32(gridView2.GetRowCellValue(i, gridView2.Columns["OdaDemirbasID"]));

                }
                OdaDemirbasTablosu od = db.OdaDemirbasTablosus.First(x => x.OdaDemirbasID == OdademirbasID);
                spinEditDemirbaslariOdalardanKaldirmaAdet.Enabled = true;
                //secilen demirbasa gore spinedit'e adet bilgisi giriliyor.
                spinEditDemirbaslariOdalardanKaldirmaAdet.Properties.MaxValue = Convert.ToInt32(od.Adet);
                spinEditDemirbaslariOdalardanKaldirmaAdet.Properties.MinValue = 1;
                spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue = od.Adet;

            }
        }
        private void simpleButtonDemirbaslariOdalardanKaldir_Click(object sender, EventArgs e)
        {
            try
            {
                using (db=new stokTakipEntities())
                {
                    if (fakulteAdi==null && demirbasID==0)
                    {
                        //oda ve demirbas seçilmediğinde ekle butonuna basıldığında verilen uyarı
                        XtraMessageBox.Show("Lütfen oda seçiniz.");
                    }
                    else
                    {
                        if(demirbasID==0)
                        {
                            //demirbas seçilmediğinde verilen uyarı.
                            XtraMessageBox.Show("Lütfen demirbaş seçiniz.");
                        }
                        else
                        {
                            if(Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue) != 0)//adet bilgisinin boş bırakılmaması için.
                            {
                                Demirbaslar d = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);
                                d.DemirbasAdet = (d.DemirbasAdet - Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue));
                                var yenidemirbas = new OdaDemirbasTablosu { DemirbasID = demirbasID };
                                
                                if (db.OdaDemirbasTablosus.Any(x => x.DemirbasID == yenidemirbas.DemirbasID))
                                {
                                    //aynı idye sahip demirbas aktarıldığında demirbasın adet sayısı çıkartılıyor.
                                    var guncelle = db.OdaDemirbasTablosus.First(x => x.DemirbasID == yenidemirbas.DemirbasID);
                                    guncelle.Adet = (guncelle.Adet - Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue));
                                    guncelle.OdaID = odaID;
                                    guncelle.DemirbasID = demirbasID;
                                    if(guncelle.Adet==0)
                                    {
                                        db.OdaDemirbasTablosus.Remove(guncelle);
                                    }
                                    db.SaveChanges();
                                }
                                if (d.Durum==true)
                                {
                                    if(db.Demirbaslars.Any(x=>x.DemirbasID==demirbasID))
                                    {
                                        //demirbaslar talosundaki demirbasın tamamı odaya aktarılmıssa demirbas tablosunda durum bilgisi değişir.
                                        d.Durum = false;
                                        d.DemirbasAdet = Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue);
                                        db.SaveChanges();
                                    }                  
                                }
                                else
                                {
                                    d.DemirbasAdet = (d.DemirbasAdet + Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue));
                                    OdaDemirbasTablosu odademirbas = db.OdaDemirbasTablosus.First(x => x.DemirbasID == demirbasID);
                                    if (db.OdaDemirbasTablosus.Any(x => x.Adet == 0))
                                    {
                                        db.OdaDemirbasTablosus.Remove(odademirbas);
                                        db.SaveChanges();
                                    }
                                    db.SaveChanges();
                                }
                                XtraMessageBox.Show("Demirbaş odadan kaldırıldı.");
                                //odadan demirbas kaldırıldıktan sonra yeni işlem için alanların temizlenmesi
                                textEditDemirbaslariOdalardanKAldirmaOdaAdi.Text = null;
                                if(textEditDemirbaslariOdalardanKAldirmaOdaAdi.Text.Length!=0)
                                {
                                    gridView1.Columns.Clear();
                                }
                                else
                                {
                                    gridControlDemirbaslariODalardanKaldirmaOdalar.DataSource = db.v_odalardanDemirbasKaldir.ToList();
                                }
                                gridView2.Columns.Clear();
                                textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Text = null;
                                spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue = null;
                                textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Enabled = false;
                                spinEditDemirbaslariOdalardanKaldirmaAdet.Enabled = false;
                            }
                            else
                            {
                                //Alanların boş olması durumu
                                XtraMessageBox.Show("Lütfen demirbaş seçiniz.");
                            }
                        }

                    }
                }
            }
            catch 
            {
                //diğer hatalar için
                XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //form yüklendiğinde gridview1'de ilk rowun seçili gelmemesi
            if (!gridView1.IsRowSelected(e.FocusedRowHandle))
            {
                BeginInvoke(new Action(() => {
                    gridView1.UnselectRow(e.FocusedRowHandle);
                }));
            }
        }
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //form yüklendiğinde gridview2' de ilk rowun seçili gelmemesi
            if (!gridView2.IsRowSelected(e.FocusedRowHandle))
            {
                BeginInvoke(new Action(() => {
                    gridView2.UnselectRow(e.FocusedRowHandle);
                }));
            }
        }

        private void spinEditDemirbaslariOdalardanKaldirmaAdet_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}