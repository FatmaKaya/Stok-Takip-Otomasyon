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
    public partial class frmDemirbasGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasGuncelle()
        {
            InitializeComponent();
        }

        private void frmDemirbasGuncelle_Load(object sender, EventArgs e)
        {

        }
        private void dbFiyat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TextEditGuncelleDemirbasAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SimpleButtonGuncelle_Click(object sender, EventArgs e)
        {

        }
        stokTakipEntities se = new stokTakipEntities();
        private void simpleButtonGuncelleAra_Click(object sender, EventArgs e)
        {

            //Personeller p = new Personeller();
            //p.PersonelAdi = "fK"; 
            //p.Sifre = "jhkj";
            //p.YetkiID = 2;
            //se.Personellers.Add(p);
            //Personeller pl = se.Personellers.First(x => x.PersonelID == 10);
            //se.Personellers.Remove(pl);

            //Personeller pp = se.Personellers.First(x => x.PersonelID== 1003);
            //pp.PersonelAdi = "fatma";

            //se.SaveChanges();
            //gridControlGuncelleDemirbaslar.DataSource = se.Personellers.ToList();
        }
    }
}