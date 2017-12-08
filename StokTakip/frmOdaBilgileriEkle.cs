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
    public partial class frmOdaBilgileriEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmOdaBilgileriEkle()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        Odalar oda = new Odalar();
        
        private void simpleButtonOdaKaydet_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                oda.OdaAdi = textEditOdaAdiEkle.Text;
                db.Odalars.Add(oda);
                db.SaveChanges();
                textEditOdaAdiEkle.Text = null;
          
                MessageBox.Show("Oda eklendi");

    
            }
        }

        private void frmOdaBilgileriEkle_Load(object sender, EventArgs e)
        {
            lookUpEditFakulteAdiEkle.Properties.DataSource = db.Fakultelers.ToList();
            lookUpEditOdaSorumlusuEkle.Properties.DataSource = db.Personellers.Where(x => x.YetkiID == 2 || x.YetkiID == 1).ToList();
        }

        private void lookUpEditFakulteAdiEkle_EditValueChanged(object sender, EventArgs e)
        {
            int fakulteID = Convert.ToInt32(lookUpEditFakulteAdiEkle.EditValue);
            lookUpEditBolumAdiEkle.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();
            oda.FakulteID = fakulteID;
        }


        private void lookUpEditBolumAdiEkle_EditValueChanged(object sender, EventArgs e)
        {
            int departmanID = Convert.ToInt32(lookUpEditBolumAdiEkle.EditValue);
            lookUpEditOdaSorumlusuEkle.Properties.DataSource = db.Personellers.Where(x => x.DepartmanID == departmanID).ToList();
            oda.DepartmanID = departmanID;
        }

        private void lookUpEditOdaSorumlusuEkle_EditValueChanged(object sender, EventArgs e)
        {
            int personelID = Convert.ToInt32(lookUpEditOdaSorumlusuEkle.EditValue);
            oda.PersonelID = personelID;
        }

        
    }
}