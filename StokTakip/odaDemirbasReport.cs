using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace StokTakip
{
    public partial class odaDemirbasReport : DevExpress.XtraReports.UI.XtraReport
    {
        public odaDemirbasReport()
        {
            InitializeComponent();
        }
        stokTakipEntities db = new stokTakipEntities();
        //rapor formunda oluşturan parametelere değer verebilmek için oluşturulan fonksiyon.
        public void initData(string fakulteAdi, string departmanAdi, string odaAdi, string odaSorumlusu)
        {
            pFakulteAdi.Value = fakulteAdi;
            pDepartmanAdi.Value = departmanAdi;
            pOdaAdi.Value = odaAdi;
            pOdaSorumlusu.Value = odaSorumlusu;
        }
    }
}
