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
        private void frmDemirbasEkle_Load(object sender, EventArgs e)
        {      
            lookUpEditDemirbasEkleFakulteAdi.Properties.DataSource = db.Fakultelers.ToList();
           
        }

        private void SimpleButtonEkle_Click(object sender, EventArgs e)
        {

        }
    }
}