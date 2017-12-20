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
        {//Personel isimleri listeleniyor
            lookUpEditPersonelAdi.Properties.DataSource = db.Personellers.ToList();   
        }
        private void lookUpEditPersonelAdi_EditValueChanged(object sender, EventArgs e)
        {//seçilen personel id alınıyor
            personelID = Convert.ToInt32(lookUpEditPersonelAdi.EditValue);
        }
        private void lookUpEditPersonelAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void simpleButtonpersonelUzerindekiDemirbaslariAra_Click_1(object sender, EventArgs e)
        {//personel üzerindeki demirbaşlar listeleniyor
            using (db = new stokTakipEntities())
            {
                try
                {  
                    if(lookUpEditPersonelAdi.EditValue!=null)  // Personel seçilirse yapılacaklar
                        gridControlPersonelUzerindekiDemirbaslar.DataSource = db.v_odaDemirbas.Where(x => x.PersonelID == personelID).ToList();
                    else   //personel seçilmezse yapılacak olan
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                }
                catch (Exception)
                {//hatalı durumlar için
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                }

            }

        }
    }
}