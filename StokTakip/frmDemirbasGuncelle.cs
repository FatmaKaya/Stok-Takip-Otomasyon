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
    public partial class frmDemirbasGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasGuncelle()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        int demirbasID;

        private void frmDemirbasGuncelle_Load(object sender, EventArgs e)
        {
            lookUpEditGuncelleDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
        }

        private void lookUpEditGuncelleDemirbas_EditValueChanged(object sender, EventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                demirbasID = Convert.ToInt32(lookUpEditGuncelleDemirbas.EditValue);
                Demirbaslar demirbas = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);
                Fakulteler fakulte = db.Fakultelers.First(x => x.FakulteID == demirbas.FakulteID);
                Departmanlar departman = db.Departmanlars.First(x => x.DepartmanID == demirbas.DepartmanID);
                DemirbasTurleri demirbasTur = db.DemirbasTurleris.First(x => x.DemirbasTurID == demirbas.DemirbasTurID);
                textEditGuncelleDemirbasFakulteAdi.Text = fakulte.FakulteAdi;
                textEditGuncelleDepartmanAdi.Text = departman.DepartmanAdi;
                textEditGuncelleDemirbasTuru.Text = demirbasTur.DemirbasTurAdi;
                textEditGuncelleDemirbasAdi.Text = demirbas.DemirbasAdi;
                textEditGuncelleFiyat.Text = demirbas.Fiyat.ToString();
                spinEditGuncelleAdet.Value = Convert.ToInt32(demirbas.DemirbasAdet);
            }  
         }
        private void simpleButtonGuncelle_Click_1(object sender, EventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                try
                {
                    Demirbaslar demirbas = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);

                    if(textEditGuncelleDemirbasAdi.Text.Length!=0)
                    {
                        demirbas.DemirbasAdi = textEditGuncelleDemirbasAdi.Text;
                        demirbas.DemirbasAdet = Convert.ToInt32(spinEditGuncelleAdet.Value);
                        demirbas.AlimTarihi = Convert.ToDateTime(DateTime.Today.ToLongDateString());
                        demirbas.Fiyat = float.Parse(textEditGuncelleFiyat.Text);

                        db.SaveChanges();

                        XtraMessageBox.Show("Demirbaş bilgileri Güncellendi..");

                        textEditGuncelleDemirbasFakulteAdi.Text="";
                        textEditGuncelleDepartmanAdi.Text = "";
                        textEditGuncelleDemirbasTuru.Text = "";
                        textEditGuncelleDemirbasAdi.Text = "";
                        spinEditGuncelleAdet.Value = 1;
                        textEditGuncelleFiyat.Text = "";
                        lookUpEditGuncelleDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                    }
                    else
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                }
                catch
                {
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                }
            }
        }
    }
}