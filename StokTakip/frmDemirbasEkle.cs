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
    public partial class frmDemirbasEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasEkle()
        {
            InitializeComponent();
        }
        stokTakipEntities db = new stokTakipEntities();
        int fakulteID;
        int departmanID;
        int demirbasTurID;
        private void frmDemirbasEkle_Load(object sender, EventArgs e)
        {      
            lookUpEditDemirbasEkleFakulteAdi.Properties.DataSource = db.Fakultelers.ToList();
            lookUpEditDemirbasTur.Properties.DataSource = db.DemirbasTurleris.ToList();
        }
        private void lookUpEditDemirbasEkleFakulteAdi_EditValueChanged(object sender, EventArgs e)
        {
            fakulteID = Convert.ToInt32(lookUpEditDemirbasEkleFakulteAdi.EditValue);
            lookUpEditDemirbasEkleDepartmanAdi.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();
        }
        private void lookUpEditDemirbasEkleDepartmanAdi_EditValueChanged(object sender, EventArgs e)
        {
            departmanID = Convert.ToInt32(lookUpEditDemirbasEkleDepartmanAdi.EditValue);          
        }
        private void lookUpEditDemirbasTur_EditValueChanged(object sender, EventArgs e)
        {
            demirbasTurID = Convert.ToInt32(lookUpEditDemirbasTur.EditValue);         
        }
        private void SimpleButtonEkle_Click(object sender, EventArgs e)
        {

                using (db = new stokTakipEntities())
                {
                try
                {


                    if (TextEditEkleDemirbasAd.Text.Length != 0)
                    {
                        Demirbaslar demirbas = new Demirbaslar();
                        demirbas.DemirbasAdi = TextEditEkleDemirbasAd.Text;
                        demirbas.DemirbasAdet = Convert.ToInt32(SpinEditEkleDemirbasAdet.Value);
                        demirbas.AlimTarihi = Convert.ToDateTime(DateTime.Today.ToLongDateString());
                        demirbas.Fiyat = float.Parse(TextEditEkleDemirbasFiyat.Text);
                        demirbas.Durum = false;
                        demirbas.FakulteID = fakulteID;
                        demirbas.DepartmanID = departmanID;
                        demirbas.DemirbasTurID = demirbasTurID;

                        db.Demirbaslars.Add(demirbas);
                        db.SaveChanges();

                        Demirbaslar demirbasUpdate = db.Demirbaslars.First(x => x.DemirbasID == demirbas.DemirbasID);
                        demirbasUpdate.DemirbasKodu = "" + demirbas.FakulteID.ToString() + "." + demirbas.DepartmanID.ToString() + "." + demirbas.DemirbasTurID.ToString() + "." + demirbas.DemirbasID.ToString();

                        db.SaveChanges();

                        XtraMessageBox.Show("Demirbaş Stoğa eklendi. Yeniden Demirbaş ekleyebilirsiniz..");
                        this.Close();
                    }
                    else
                    {
                         XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                    this.Close();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                    this.Close();
                }
            }

        }

       
    }
}