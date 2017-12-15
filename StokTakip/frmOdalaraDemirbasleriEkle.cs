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
    public partial class frmOdalaraDemirbasleriEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmOdalaraDemirbasleriEkle()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        string fakulteAdi;
        int odaID;
        int demirbasID;
        private void frmOdalaraDemirbasleriEkle_Load(object sender, EventArgs e)
        {
            //view kullanarak kayıtlı olan odalar listelendi.
            gridControlOdalaraDemirbasEkleOdalar.DataSource = db.v_odalaraDemirbasEkleOdalar.ToList();
            textEditOdalaraDemirbasEkleDemirbasAdi.Enabled = false;
            spinEditOdalaraDemirbasEkleAdet.Enabled = false;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                //seçilen rowun fakülte adini fakulteAdi değişkenine ve oda IDsini odaID değişkenine atıyoruz.
                int[] RowHandles = gridView1.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                    fakulteAdi = gridView1.GetRowCellValue(i, gridView1.Columns["FakulteAdi"]).ToString();
                    odaID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OdaID"]));
                }
                //seçilen odanın fakültesine göre demirbaslar view ile listeletiliyor
                gridControlOdalaraDemirbasEkleDemirbaslar.DataSource = db.v_odalaraDemirbasEkleDemirbaslar.Where(x => x.FakulteAdi == fakulteAdi).ToList();
                textEditOdalaraDemirbasEkleDemirbasAdi.Enabled = true;
            }
        }
        private void textEditOdalaraDemirbasEkleOdaAdi_EditValueChanged(object sender, EventArgs e)
        {
            string aranacakoda = textEditOdalaraDemirbasEkleOdaAdi.Text;
            gridControlOdalaraDemirbasEkleOdalar.DataSource = db.v_odalaraDemirbasEkleOdalar.Where(x => x.OdaAdi.ToLower().Contains(aranacakoda) || x.OdaAdi.ToUpper().Contains(aranacakoda)).ToList();
        }
        private void textEditOdalaraDemirbasEkleDemirbasAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                string arademirbas = textEditOdalaraDemirbasEkleDemirbasAdi.Text;
                gridControlOdalaraDemirbasEkleDemirbaslar.DataSource = db.v_odalaraDemirbasEkleDemirbaslar.Where(x => x.DemirbasAdi.ToLower().Contains(arademirbas) || x.DemirbasAdi.ToUpper().Contains(arademirbas)).ToList();
            }
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                int[] RowHandles = gridView2.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                    demirbasID = Convert.ToInt32(gridView2.GetRowCellValue(i, gridView2.Columns["DemirbasID"]));
                }
                Demirbaslar d = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);
                spinEditOdalaraDemirbasEkleAdet.Enabled = true;
                spinEditOdalaraDemirbasEkleAdet.Properties.MaxValue = Convert.ToInt32(d.DemirbasAdet);
                spinEditOdalaraDemirbasEkleAdet.Properties.MinValue = 1;
                spinEditOdalaraDemirbasEkleAdet.EditValue = d.DemirbasAdet;
            }
        }
        private void simpleButtonOdalaraDemirbasEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (db=new stokTakipEntities())
                {
                    if (fakulteAdi == null && demirbasID == 0)
                    {
                        XtraMessageBox.Show("Lütfen oda seçiniz.");
                    }
                    else
                    {
                        if (demirbasID == 0)
                        {
                            XtraMessageBox.Show("Lütfen demirbaş seçiniz.");
                        }
                        else
                        {
                            if (Convert.ToInt32(spinEditOdalaraDemirbasEkleAdet.EditValue) != 0)
                            {
                                OdaDemirbasTablosu odademirbas = new OdaDemirbasTablosu();
                                odademirbas.Adet = Convert.ToInt32(spinEditOdalaraDemirbasEkleAdet.Text);
                                odademirbas.OdaID = odaID;
                                odademirbas.DemirbasID = demirbasID;
                                Demirbaslar d = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);
                                var yenidemirbas = new OdaDemirbasTablosu { DemirbasID = demirbasID };
                                d.DemirbasAdet = (d.DemirbasAdet - Convert.ToInt32(spinEditOdalaraDemirbasEkleAdet.EditValue));
                                if (db.OdaDemirbasTablosus.Any(x => x.DemirbasID == yenidemirbas.DemirbasID))
                                {
                                    var guncelle = db.OdaDemirbasTablosus.First(x => x.DemirbasID == yenidemirbas.DemirbasID);
                                    guncelle.Adet = (guncelle.Adet + Convert.ToInt32(spinEditOdalaraDemirbasEkleAdet.EditValue));
                                    guncelle.OdaID = odaID;
                                    guncelle.DemirbasID = demirbasID;
                                    db.SaveChanges();
                                }
                                else
                                {
                                    db.OdaDemirbasTablosus.Add(odademirbas);
                                    db.SaveChanges();
                                }
                                if (d.DemirbasAdet == 0)
                                {
                                    var adet = db.OdaDemirbasTablosus.First(x => x.DemirbasID == d.DemirbasID);
                                    d.DemirbasAdet = adet.Adet;
                                    d.Durum = true;
                                    db.SaveChanges();
                                }
                                XtraMessageBox.Show("Demirbaş odaya atandı.");
                                textEditOdalaraDemirbasEkleOdaAdi.Text = null;
                                if (textEditOdalaraDemirbasEkleOdaAdi.Text.Length != 0)
                                {
                                    gridView1.Columns.Clear();
                                }
                                gridView2.Columns.Clear();
                                spinEditOdalaraDemirbasEkleAdet.Value = 0;
                                textEditOdalaraDemirbasEkleDemirbasAdi.Text = null;
                                textEditOdalaraDemirbasEkleDemirbasAdi.Enabled = false;
                                spinEditOdalaraDemirbasEkleAdet.Enabled = false;
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
                BeginInvoke(new Action(() =>
                {
                    gridView1.UnselectRow(e.FocusedRowHandle);
                }));
            }
        }
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //form yüklendiğinde gridview2' de ilk rowun seçili gelmemesi
            if (!gridView2.IsRowSelected(e.FocusedRowHandle))
            {
                BeginInvoke(new Action(() =>
                {
                    gridView2.UnselectRow(e.FocusedRowHandle);
                }));
            }

        }
    }
}