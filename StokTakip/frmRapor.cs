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
using System.Collections;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using DevExpress.DataAccess.Sql;

namespace StokTakip
{
    public partial class frmRapor : DevExpress.XtraEditors.XtraForm
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        stokTakipEntities db = new stokTakipEntities();
        //raporAl fonksiyonu ile gridcontrolden tıklanan odanın ıd'sine eşit olan listedeki verileri bulup ekrana yansıtıyoruz.
        public void raporAl(int odaID)
        {
            using (db = new stokTakipEntities())
            {
                odaDemirbasReport rapor = new odaDemirbasReport();
                List<v_OdaDemirbasListesi> liste = db.v_OdaDemirbasListesi.Where(x => x.OdaID == odaID).ToList();
                rapor.DataSource = liste;
                //odaDemirbasReport'da tanımladığımız fonksiyonu çağrıyoruz.
                rapor.initData(liste);
                documentViewer1.DocumentSource = rapor;
                rapor.CreateDocument();
            }

        }

    }
}
       
      
