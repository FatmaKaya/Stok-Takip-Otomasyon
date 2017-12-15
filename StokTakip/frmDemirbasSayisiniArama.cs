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
    public partial class frmDemirbasSayisiniArama : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasSayisiniArama()
        {
            InitializeComponent();
        }

        stokTakipEntities db =new stokTakipEntities();
        string demirbasAdi;

        private void frmDemirbasSayisiniArama_Load(object sender, EventArgs e)
        {
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility= DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility= DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            
        }
        private void checkEditDemirbasAdinaGore_CheckedChanged(object sender, EventArgs e)
        {
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditDemirbasAdinaGore.Checked = false;
        }

        private void checkEditDemirbasTuruneGore_CheckedChanged(object sender, EventArgs e)
        {
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditDemirbasTuruneGore.Checked=false;
        }

        private void checkEditFiyatinaGore_CheckedChanged(object sender, EventArgs e)
        {
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditFiyatinaGore.Checked = false;
        }

        private void checkEditAlimTarihineGore_CheckedChanged(object sender, EventArgs e)
        {
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAdetineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditAlimTarihineGore.Checked = false;
        }

        private void checkEditAdetineGore_CheckedChanged(object sender, EventArgs e)
        {
           Adet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            checkEditDemirbasAdinaGore.Checked = false;
            checkEditDemirbasTuruneGore.Checked = false;
            checkEditFiyatinaGore.Checked = false;
            checkEditAlimTarihineGore.Checked = false;
            DemirbasAdi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            DemirbasTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Fiyat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            AlimTarihi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            checkEditAdetineGore.Checked = false;
        }

        private void SimpleButtonArama_Click(object sender, EventArgs e)
        {
            demirbasAdi = TextEditDemirbasAdi.Text;
            using (db = new stokTakipEntities())
            {
                //try
                //{
                    if(demirbasAdi!=null)
                    {
                        GridControlDemirbasSayisiAramaDemirbaslar.DataSource = db.v_demirbassayisi.Where(x => x.DemirbasAdi == demirbasAdi).ToList();
                    }
                //}
                //catch
                //{

                    
                //}
            }
        }
    }
}