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
    public partial class frmPersonelUzerindekiDemirbasArama : DevExpress.XtraEditors.XtraForm
    {
        public frmPersonelUzerindekiDemirbasArama()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        int personelID;

        private void frmPersonelUzerindekiDemirbasArama_Load(object sender, EventArgs e)
        {
            //Personel isimleri listeleniyor
            lookUpEditPersonelAdi.Properties.DataSource = db.Personellers.ToList();
        }

        private void lookUpEditPersonelAdi_EditValueChanged(object sender, EventArgs e)
        {
            //seçilen personel id alınıyor
            personelID = Convert.ToInt32(lookUpEditPersonelAdi.EditValue);
        }

        private void lookUpEditPersonelAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        public int PersonelUzerindekiDemirbaslariAra(string personel)
        { //personel üzerindeki demirbaşlar listeleniyor
            int kontrol = 0;
            using (db = new stokTakipEntities())
            {
                    if (personel != null)  // Personel seçilirse yapılacaklar
                    {
                        gridControlPersonelUzerindekiDemirbaslar.DataSource = db.v_odaDemirbas.Where(x => x.PersonelID == personelID).ToList();
                        kontrol = 1;
                    }                    
                    else   //personel seçilmezse yapılacak olan
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                return kontrol;
            }
        }
        private void simpleButtonPersonelUzerindekiDemirbaslariAra_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelUzerindekiDemirbaslariAra((lookUpEditPersonelAdi.EditValue).ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen alanları kontrol ederek tekrar deneyiniz..");
            }
            

        }
    }
}