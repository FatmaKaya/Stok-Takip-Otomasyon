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
        Demirbaslar demirbas = new Demirbaslar();

        private void frmDemirbasEkle_Load(object sender, EventArgs e)
        {      
            lookUpEditDemirbasEkleFakulteAdi.Properties.DataSource = db.Fakultelers.ToList();
            lookUpEditDemirbasTur.Properties.DataSource = db.DemirbasTurleris.ToList();
        }
        private void lookUpEditDemirbasEkleFakulteAdi_EditValueChanged(object sender, EventArgs e)
        {
            int fakulteID = Convert.ToInt32(lookUpEditDemirbasEkleFakulteAdi.EditValue);
            lookUpEditDemirbasEkleDepartmanAdi.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();
            demirbas.FakulteID = fakulteID;
        }
        private void lookUpEditDemirbasEkleDepartmanAdi_EditValueChanged(object sender, EventArgs e)
        {
            int departmanID = Convert.ToInt32(lookUpEditDemirbasEkleDepartmanAdi.EditValue);
            demirbas.DepartmanID = departmanID;
        }
        private void lookUpEditDemirbasTur_EditValueChanged(object sender, EventArgs e)
        {
            int demirbasTurID = Convert.ToInt32(lookUpEditDemirbasTur.EditValue);
            demirbas.DemirbasTurID = demirbasTurID;
        }
        private void SimpleButtonEkle_Click(object sender, EventArgs e)
        {

                using (db = new stokTakipEntities())
                {
                try
                {
                    demirbas.DemirbasAdi = TextEditEkleDemirbasAd.Text;
                    demirbas.DemirbasAdet = Convert.ToInt32(SpinEditEkleDemirbasAdet.Value);
                    demirbas.AlimTarihi = Convert.ToDateTime(DateTime.Today.ToLongDateString());
                    demirbas.Fiyat = float.Parse(TextEditEkleDemirbasFiyat.Text);
                    demirbas.Durum = false;

                    db.Demirbaslars.Add(demirbas);
                    db.SaveChanges();

                    demirbas.DemirbasKodu = "" + demirbas.FakulteID.ToString() + "." + demirbas.DepartmanID.ToString() + "." + demirbas.DemirbasTurID.ToString() + "." + demirbas.DemirbasID.ToString();

                    db.Demirbaslars.Add(demirbas);
                    db.SaveChanges();

                    MessageBox.Show("Demirbaş Stoğa eklendi. Yeni Demirbaş ekleyebilirsiniz..");
                }
                catch
                {
                    MessageBox.Show("Lütfen alanları kontrol ediniz.");
                }
            }

        }

       
    }
}