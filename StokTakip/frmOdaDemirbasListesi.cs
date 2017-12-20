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
            //oda adına göre arama işleminin yapılması.
            using (db=new stokTakipEntities())
            {
                string araOda = textEditODLOdaAdi.Text;
                gridControlOdaDemirbasListesi.DataSource = db.v_OdaDemirbasListesiOdalar.Where(x => x.OdaAdi.ToLower().Contains(araOda) || x.OdaAdi.ToUpper().Contains(araOda)).ToList();
            }
        }
        private void textEditODLOdaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }
        private void frmOdaDemirbasListesi_Load(object sender, EventArgs e)
        {
            gridControlOdaDemirbasListesi.DataSource = db.v_OdaDemirbasListesiOdalar.ToList();
        }
        int odaID;
        private void simpleButtonODLRapor_Click(object sender, EventArgs e)
        {
            using (db=new stokTakipEntities())
            {
                //seçilen gridcontroldeki odanın ıdsini alıyoruz.
                int[] RowHandles = gridView1.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                    odaID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OdaID"]));
                }
                using (frmRapor frm = new frmRapor())
                {
                    //raporAl Fonksiyonunu çağırıyoruz.
                    frm.raporAl(odaID);
                    frm.ShowDialog();
                }
            }
           
        }
    }
}