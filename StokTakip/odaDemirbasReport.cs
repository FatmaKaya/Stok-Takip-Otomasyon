using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace StokTakip
{
    public partial class odaDemirbasReport : DevExpress.XtraReports.UI.XtraReport
    {
        public odaDemirbasReport()
        {
            InitializeComponent();
        }
        //raporumuzun veri tabanını tanımlıyoruz.
        public void initData(List<v_OdaDemirbasListesi> liste)
        {
            this.bindingSource1.DataSource =liste ;
        }
        
    }
}
