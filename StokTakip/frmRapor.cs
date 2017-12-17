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
    public partial class frmRapor : DevExpress.XtraEditors.XtraForm
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        public void raporAl(v_OdaDemirbasListesi data)
        {
            odaDemirbasReport rapor = new odaDemirbasReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rapor.Parameters)
                p.Visible = false;
            //parametrelere gelecek değerleri fonksiyonda belirtiyoruz.
            rapor.initData(data.FakulteAdi, data.DepartmanAdi, data.OdaAdi, data.PersonelAdi);
            documentViewer1.DocumentSource = rapor;
            rapor.CreateDocument();
        }
    }    
}