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
        stokTakipEntities1 db = new stokTakipEntities1();
        private void textEditODLOdaAdi_EditValueChanged(object sender, EventArgs e)
        {
            //oda adına göre arama işleminin yapılması.
            using (db=new stokTakipEntities1())
            {
                string araOda = textEditODLOdaAdi.Text;
                gridControlOdaDemirbasListesi.DataSource = db.v_OdaDemirbasListesiOdalar.Where(x => x.OdaAdi.ToLower().Contains(araOda) || x.OdaAdi.ToUpper().Contains(araOda)).ToList();
            }
        }
        private void textEditODLOdaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void frmOdaDemirbasListesi_Load(object sender, EventArgs e)
        {
            gridControlOdaDemirbasListesi.DataSource = db.v_OdaDemirbasListesiOdalar.ToList();
        }
        int odaID;
        private void simpleButtonODLRapor_Click(object sender, EventArgs e)
        {
            try
            {
                //seçilen gridcontroldeki odanın ıdsini alıyoruz.
                int[] RowHandles = gridView1.GetSelectedRows();
                foreach (int i in RowHandles)
                {
                    odaID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OdaID"]));
                }
                if (odaID==0)
                {
                    XtraMessageBox.Show("Lütfen oda seçiniz.");
                }
                else
                {
                    using (db = new stokTakipEntities())
                    {

                        using (frmRapor frm = new frmRapor())
                        {
                            //raporAl Fonksiyonunu çağırıyoruz.
                            frm.raporAl(odaID);
                            frm.ShowDialog();
                        }
                    }
                }       
            }
            catch 
            {
                XtraMessageBox.Show("Lütfen alanları kontrol ederek tekrar deneyiniz..");
            }    
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //form yüklendiğinde gridview1'de ilk rowun seçili gelmemesi
            if (!gridView1.IsRowSelected(e.FocusedRowHandle))
            {
                BeginInvoke(new Action(() =>
                {
                    gridView1.UnselectRow(e.FocusedRowHandle);
                }));
            }
        }
    }
}