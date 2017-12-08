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
        private void simpleButtonOdaKaydet_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar();
           
        }

        private void frmOdaBilgileriEkle_Load(object sender, EventArgs e)
        {
           
            lookUpEditOdaSorumlusuEkle.Properties.DataSource = db.Personellers.Where(x => x.YetkiID == 2 || x.YetkiID == 1 ).ToList();
            
        }

        private void lookUpEditOdaSorumlusuEkle_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}