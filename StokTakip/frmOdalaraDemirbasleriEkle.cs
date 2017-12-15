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
        int odaID;
        int demirbasID;
        int demirbasAdet;
       
   
        private void frmOdalaraDemirbasleriEkle_Load(object sender, EventArgs e)
        {
            textEditOdalaraDemirbasEkleDemirbasAdi.Enabled = false;
            spinEditOdalaraDemirbasEkleAdet.Enabled = false;
            var odalar = db.Odalars.Join(db.Fakultelers,
                        x => x.FakulteID,
                        y => y.FakulteID,
                        (oda, fakulte) => new
                        {
                            oda.OdaAdi,
                            oda.OdaID,
                            fakulte.FakulteAdi,
                            oda.DepartmanID,
                            oda.PersonelID
                        }).Join(db.Departmanlars,
                        z => z.DepartmanID,
                        t => t.DepartmanID,
                        (oda, departman) => new
                        {
                            oda.OdaID,
                            oda.PersonelID,
                            oda.OdaAdi,
                            oda.FakulteAdi,
                            departman.DepartmanAdi,

                        }).Join(db.Personellers,
                            u => u.PersonelID,
                            v => v.PersonelID,
                            (oda, personel) => new
                            {
                                oda.OdaID,
                                oda.OdaAdi,
                                oda.FakulteAdi,
                                oda.DepartmanAdi,
                                personel.PersonelAdi
                            }).ToList();
            gridControlOdalaraDemirbasEkleOdalar.DataSource = odalar.ToList();
        }
        private void textEditOdalaraDemirbasEkleOdaAdı_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                string ara = textEditOdalaraDemirbasEkleOdaAdi.Text.ToUpper();
 
                 var odalar = db.Odalars.Join(db.Fakultelers,
                        x => x.FakulteID,
                        y => y.FakulteID,
                        (oda, fakulte) => new
                        {
                            oda.OdaAdi,
                            oda.OdaID,
                            fakulte.FakulteAdi,
                            oda.DepartmanID,
                            oda.PersonelID
                        }).Join(db.Departmanlars,
                        z => z.DepartmanID,
                        t => t.DepartmanID,
                        (oda, departman) => new
                        {
                            oda.OdaID,
                            oda.PersonelID,
                            oda.OdaAdi,
                            oda.FakulteAdi,
                            departman.DepartmanAdi,

                        }).Join(db.Personellers,
                            u => u.PersonelID,
                            v => v.PersonelID,
                            (oda, personel) => new
                        {
                            oda.OdaID,
                            oda.OdaAdi,
                            oda.FakulteAdi,
                            oda.DepartmanAdi,
                            personel.PersonelAdi
                        }).ToList();
                gridControlOdalaraDemirbasEkleOdalar.DataSource = odalar.Where(x => x.OdaAdi.ToUpper().Contains(ara)).ToList();
               

            }
        }

        private void simpleButtonOdalaraDemirbaslariEkleOdaArama_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                try
                {
                    
                    int[] RowHandles = gridView1.GetSelectedRows();
                    foreach (int i in RowHandles)
                    {
                        odaID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OdaID"]));
                    }
                    Odalar o = db.Odalars.Find(odaID);
                    if(odaID==0)
                    {
                        XtraMessageBox.Show("Lütfen oda seçiniz.");
                    }
                    else
                    {
                        textEditOdalaraDemirbasEkleDemirbasAdi.Enabled = true;
                        var demirbaslar = db.Demirbaslars.Join(db.DemirbasTurleris,
                        x => x.DemirbasTurID,
                        y => y.DemirbasTurID,
                       (demirbas, tur) => new
                       {
                          demirbas.DemirbasID,
                          demirbas.DemirbasAdi,
                          demirbas.DemirbasAdet,
                          demirbas.AlimTarihi,
                          tur.DemirbasTurAdi,
                          demirbas.DemirbasKodu,
                          demirbas.Fiyat,
                          demirbas.FakulteID,
                          demirbas.DepartmanID,
                          demirbas.Durum
                     }).Join(db.Fakultelers,
                         z => z.FakulteID,
                         t => t.FakulteID,
                         (demirbas, fakulte) => new
                    {
                         demirbas.DemirbasID,
                         demirbas.DemirbasAdi,
                         demirbas.DemirbasAdet,
                         demirbas.AlimTarihi,
                         demirbas.DemirbasTurAdi,
                         demirbas.DemirbasKodu,
                         demirbas.Fiyat,
                         demirbas.DepartmanID,
                         fakulte.FakulteAdi,
                         demirbas.Durum,
                         demirbas.FakulteID,
                   }).Join(db.Departmanlars,
                        u => u.DepartmanID,
                        v => v.DepartmanID,
                   (demirbas, departman) => new
                   {
                        demirbas.DemirbasID,
                        demirbas.DemirbasAdi,
                        demirbas.DemirbasAdet,
                        demirbas.AlimTarihi,
                        demirbas.DemirbasTurAdi,
                        demirbas.DemirbasKodu,
                        demirbas.Fiyat,
                        demirbas.DepartmanID,
                        demirbas.FakulteAdi,
                        departman.DepartmanAdi,
                        demirbas.Durum,
                        demirbas.FakulteID
                   }).ToList();
                 gridControlOdalaraDemirbasEkleDemirbaslar.DataSource = demirbaslar.Where(x => x.Durum == false && x.FakulteID == o.FakulteID).ToList();

                    }
                }
                catch 
                {
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                }
               
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!gridView1.IsRowSelected(e.FocusedRowHandle))
            {
                BeginInvoke(new Action(() => {
                    gridView1.UnselectRow(e.FocusedRowHandle);
                }));
            }
        }

        private void simpleButtonOdalaraDemirbasEkle_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                try
                {
                    int[] RowHandles = gridView2.GetSelectedRows();
                    foreach (int i in RowHandles)
                    {
                        demirbasID = Convert.ToInt32(gridView2.GetRowCellValue(i, gridView2.Columns["DemirbasID"]));
                    }
               
                    if (demirbasID == 0 && odaID == 0)
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
                                if(textEditOdalaraDemirbasEkleOdaAdi.Text.Length!=0)
                                {
                                    gridView1.Columns.Clear();
                                }
                                gridView2.Columns.Clear();
                                spinEditOdalaraDemirbasEkleAdet.Value = 0;  
                                textEditOdalaraDemirbasEkleDemirbasAdi.Text=null;
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
                catch 
                {
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                }
            }
           
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!gridView2.IsRowSelected(e.FocusedRowHandle))
            {
                BeginInvoke(new Action(() => {
                    gridView2.UnselectRow(e.FocusedRowHandle);
                }));
            }
           
        }

        private void simpleButtonOdalaraDemirbasEkleDemirbasSec_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new stokTakipEntities())
                {
                    int[] RowHandles = gridView2.GetSelectedRows();
                    foreach (int i in RowHandles)
                    {
                        demirbasID = Convert.ToInt32(gridView2.GetRowCellValue(i, gridView2.Columns["DemirbasID"]));
                    }
                    Demirbaslar d = db.Demirbaslars.Find(demirbasID);
                    demirbasAdet = Convert.ToInt32(d.DemirbasAdet);
                    if (demirbasID == 0 && odaID == 0)
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
                            if (demirbasID != 0)
                            {

                                spinEditOdalaraDemirbasEkleAdet.Enabled = true;
                                spinEditOdalaraDemirbasEkleAdet.Properties.MaxValue = demirbasAdet;
                                spinEditOdalaraDemirbasEkleAdet.Properties.MinValue = 1;
                                spinEditOdalaraDemirbasEkleAdet.EditValue = demirbasAdet;
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

        private void textEditOdalaraDemirbasEkleDemirbasAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                   String ara2 = textEditOdalaraDemirbasEkleDemirbasAdi.Text.ToUpper();

                    int[] RowHandles = gridView1.GetSelectedRows();
                    foreach (int i in RowHandles)
                    {
                        odaID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OdaID"]));
                    }
                    Odalar o = db.Odalars.Find(odaID);
                    var demirbaslar = db.Demirbaslars.Join(db.DemirbasTurleris,
                    x => x.DemirbasTurID,
                    y => y.DemirbasTurID,
                   (demirbas, tur) => new
                   {
                       demirbas.DemirbasID,
                       demirbas.DemirbasAdi,
                       demirbas.DemirbasAdet,
                       demirbas.AlimTarihi,
                       tur.DemirbasTurAdi,
                       demirbas.DemirbasKodu,
                       demirbas.Fiyat,
                       demirbas.FakulteID,
                       demirbas.DepartmanID,
                       demirbas.Durum
                   }).Join(db.Fakultelers,
                     z => z.FakulteID,
                     t => t.FakulteID,
                     (demirbas, fakulte) => new
                     {
                         demirbas.DemirbasID,
                         demirbas.DemirbasAdi,
                         demirbas.DemirbasAdet,
                         demirbas.AlimTarihi,
                         demirbas.DemirbasTurAdi,
                         demirbas.DemirbasKodu,
                         demirbas.Fiyat,
                         demirbas.DepartmanID,
                         fakulte.FakulteAdi,
                         demirbas.Durum,
                         demirbas.FakulteID,
                     }).Join(db.Departmanlars,
                    u => u.DepartmanID,
                    v => v.DepartmanID,
               (demirbas, departman) => new
               {
                   demirbas.DemirbasID,
                   demirbas.DemirbasAdi,
                   demirbas.DemirbasAdet,
                   demirbas.AlimTarihi,
                   demirbas.DemirbasTurAdi,
                   demirbas.DemirbasKodu,
                   demirbas.Fiyat,
                   demirbas.DepartmanID,
                   demirbas.FakulteAdi,
                   departman.DepartmanAdi,
                   demirbas.Durum,
                   demirbas.FakulteID
               }).ToList();
                    gridControlOdalaraDemirbasEkleDemirbaslar.DataSource = demirbaslar.Where(x => x.Durum == false && x.FakulteID == o.FakulteID && x.DemirbasAdi.ToUpper().Contains(ara2)).ToList();            
                }
            }
        }
    }
    