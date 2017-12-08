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
       
        private void frmDemirbasEkle_Load(object sender, EventArgs e)
        {      
            lookUpEditDemirbasEkleFakulteAdi.Properties.DataSource = db.Fakultelers.ToList();
        }
        private void lookUpEditDemirbasEkleFakulteAdi_EditValueChanged(object sender, EventArgs e)
        {
            fakulteID = Convert.ToInt32(lookUpEditDemirbasEkleFakulteAdi.EditValue);
            MessageBox.Show(fakulteID.ToString());
            lookUpEditDemirbasEkleDepartmanAdi.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();
        }
        private void lookUpEditDemirbasEkleDepartmanAdi_EditValueChanged(object sender, EventArgs e)
        {
            departmanID = Convert.ToInt32(lookUpEditDemirbasEkleDepartmanAdi.EditValue);
            MessageBox.Show(departmanID.ToString());
        }
        private void SimpleButtonEkle_Click(object sender, EventArgs e)
        {
            
            using (db = new stokTakipEntities())
            {
                Demirbaslar demirbas = new Demirbaslar();
                demirbas.DemirbasAdi = TextEditEkleDemirbasAd.Text;
                demirbas.DemirbasAdet = Convert.ToInt32(SpinEditEkleDemirbasAdet.Value);
                demirbas.AlimTarihi = Convert.ToDateTime(DateTime.Today.ToLongDateString());
                demirbas.Fiyat = float.Parse(TextEditEkleDemirbasFiyat.Text);
                MessageBox.Show(demirbas.DemirbasAdet.ToString()+"-"+demirbas.Fiyat.ToString()+"-"+demirbas.AlimTarihi.ToString());
                demirbas.Durum = false;
                demirbas.FakulteID = fakulteID;
                demirbas.DepartmanID = departmanID;
                
            }

        }

       
    }
}