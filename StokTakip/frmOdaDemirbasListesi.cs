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
    public partial class frmOdaDemirbasListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmOdaDemirbasListesi()
        {
            InitializeComponent();
        }
        stokTakipEntities db = new stokTakipEntities();
        private void textEditODLOdaAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                string araOda = textEditODLOdaAdi.Text;
                gridControlOdaDemirbasListesi.DataSource = db.v_OdaDemirbasListesiOdalar.Where(x => x.OdaAdi.ToLower().Contains(araOda) || x.OdaAdi.ToUpper().Contains(araOda)).ToList();
            }
        }
        private void frmOdaDemirbasListesi_Load(object sender, EventArgs e)
        {
            gridControlOdaDemirbasListesi.DataSource = db.v_OdaDemirbasListesiOdalar.ToList();
        }
        v_OdaDemirbasListesi liste = new v_OdaDemirbasListesi();
        private void simpleButtonODLRapor_Click(object sender, EventArgs e)
        {
            using (frmRapor frm=new frmRapor())
            {
                //raporAl Fonksiyonunu çağırıyoruz.
                frm.raporAl(liste);
                frm.ShowDialog();
            }
        }
    }
}