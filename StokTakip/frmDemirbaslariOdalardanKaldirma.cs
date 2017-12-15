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
        int odaID;
        private void frmDemirbaslariOdalardanKaldirma_Load(object sender, EventArgs e)
        {
            //view kullanarak demirbaşı olan odalar listelendi.
            gridControlDemirbaslariODalardanKaldirmaOdalar.DataSource = db.v_odalardanDemirbasKaldir.ToList();
            textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Enabled = false;
            spinEditDemirbaslariOdalardanKaldirmaAdet.Enabled = false;
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
                }
                //seçilen odanın fakültesine göre demirbaslar view ile listeletiliyor
                gridControlDemirbaslariOdalardanKaldirmaDemirbaslar.DataSource = db.v_odalardanDemirbasKaldirDemirbas.Where(x => x.FakulteAdi == fakulteAdi).ToList();
                textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Enabled = true;
            }       
        }
        private void textEditDemirbaslariOdalardanKAldirmaOdaAdi_EditValueChanged(object sender, EventArgs e)
        {
            string aranacakOda = textEditDemirbaslariOdalardanKAldirmaOdaAdi.Text;
            gridControlDemirbaslariODalardanKaldirmaOdalar.DataSource = db.v_odalardanDemirbasKaldir.Where(x => x.OdaAdi.ToLower().Contains(aranacakOda) || x.OdaAdi.ToUpper().Contains(aranacakOda)).ToList();
        }
        private void textEditDemirbaslariOdalardanKaldirmaDemirbasAdi_EditValueChanged(object sender, EventArgs e)
        {
            string aranacakDemirbas = textEditDemirbaslariOdalardanKaldirmaDemirbasAdi.Text;
            gridControlDemirbaslariOdalardanKaldirmaDemirbaslar.DataSource = db.v_odalardanDemirbasKaldirDemirbas.Where(x => x.DemirbasAdi.ToLower().Contains(aranacakDemirbas) || x.DemirbasAdi.ToUpper().Contains(aranacakDemirbas)).ToList();
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                int[] RowHandles = gridView2.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                    demirbasID = Convert.ToInt32(gridView2.GetRowCellValue(i, gridView2.Columns["DemirbasID"]));
                }
                OdaDemirbasTablosu od = db.OdaDemirbasTablosus.First(x => x.DemirbasID == demirbasID);
                spinEditDemirbaslariOdalardanKaldirmaAdet.Enabled = true;
                spinEditDemirbaslariOdalardanKaldirmaAdet.Properties.MaxValue =Convert.ToInt32(od.Adet);
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
                        XtraMessageBox.Show("Lütfen oda seçiniz.");
                    }
                    else
                    {
                        if(demirbasID==0)
                        {
                            XtraMessageBox.Show("Lütfen demirbaş seçiniz.");
                        }
                        else
                        {
                            if(Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue) != 0)
                            {
                                Demirbaslar d = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);
                                d.DemirbasAdet = (d.DemirbasAdet - Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue));
                                var yenidemirbas = new OdaDemirbasTablosu { DemirbasID = demirbasID };
                                
                                if (db.OdaDemirbasTablosus.Any(x => x.DemirbasID == yenidemirbas.DemirbasID))
                                {
                                    var guncelle = db.OdaDemirbasTablosus.First(x => x.DemirbasID == yenidemirbas.DemirbasID);
                                    guncelle.Adet = (guncelle.Adet - Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue));
                                    guncelle.OdaID = odaID;
                                    guncelle.DemirbasID = demirbasID;
                                    db.SaveChanges();
                                }
                                if (d.Durum==true)
                                {
                                    d.Durum = false;
                                    d.DemirbasAdet = Convert.ToInt32(spinEditDemirbaslariOdalardanKaldirmaAdet.EditValue);
                                    OdaDemirbasTablosu odademirbas = db.OdaDemirbasTablosus.First(x => x.DemirbasID == demirbasID);
                                    db.OdaDemirbasTablosus.Remove(odademirbas);
                                    db.SaveChanges();
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
                                XtraMessageBox.Show("Lütfen demirbaş seçiniz.");
                            }
                        }

                    }
                }
            }
            catch 
            {
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
    }
}