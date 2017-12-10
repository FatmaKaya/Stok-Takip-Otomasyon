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
        
        private void frmOdalaraDemirbasleriEkle_Load(object sender, EventArgs e)
        {
           
        }
        private void textEditOdalaraDemirbasEkleOdaAdı_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                string ara = textEditOdalaraDemirbasEkleOdaAdı.Text;
                

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
                gridControlOdalaraDemirbaslariEkleOdalar.DataSource = odalar.Where(x => x.OdaAdi.Contains(ara)).ToList();
            }
        }

        private void simpleButtonOdalaraDemirbaslariEkleOdaArama_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
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

                gridControlOdalaraDemirbaslariEkleDemirbaslar.DataSource = demirbaslar.Where(x => x.Durum == false || x.FakulteID == o.FakulteID).ToList();
            }
            
        }
        private void textEditOdalaraDemirbaslariEkleDemirbasAdi_EditValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}