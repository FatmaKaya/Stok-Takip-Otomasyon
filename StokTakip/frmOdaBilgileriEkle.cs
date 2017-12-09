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
    public partial class frmOdaBilgileriEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmOdaBilgileriEkle()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        Odalar oda = new Odalar();

        private void simpleButtonOdaKaydet_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (textEditOdaAdiEkle.Text.Length != 0)
                    {
                        oda.OdaAdi = textEditOdaAdiEkle.Text;
                        var yenioda = new Odalar { OdaAdi = oda.OdaAdi };
                        if (db.Odalars.Any(x => x.OdaAdi == yenioda.OdaAdi))
                        {
                            XtraMessageBox.Show("Bu oda zaten var. Güncelleme yapmak için yan sekmeye gidiniz..");
                            this.Close();
                        }
                        else
                        {
                            db.Odalars.Add(oda);
                            db.SaveChanges();

                            XtraMessageBox.Show("Oda Bilgileri eklendi.");
                            this.Close();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                        this.Close();
                    }
                }
                catch
                {

                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                    this.Close();
                }
            }
        }
        private void frmOdaBilgileriEkle_Load(object sender, EventArgs e)
        {
            lookUpEditFakulteAdiEkle.Properties.DataSource = db.Fakultelers.ToList();
        }

        private void lookUpEditFakulteAdiEkle_EditValueChanged(object sender, EventArgs e)
        {
            int fakulteID = Convert.ToInt32(lookUpEditFakulteAdiEkle.EditValue);
            lookUpEditBolumAdiEkle.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();
            oda.FakulteID = fakulteID;
        }


        private void lookUpEditBolumAdiEkle_EditValueChanged(object sender, EventArgs e)
        {
            int departmanID = Convert.ToInt32(lookUpEditBolumAdiEkle.EditValue);
            lookUpEditOdaSorumlusuEkle.Properties.DataSource = db.Personellers.Where(x => x.DepartmanID == departmanID).ToList();
            oda.DepartmanID = departmanID;
        }

        private void lookUpEditOdaSorumlusuEkle_EditValueChanged(object sender, EventArgs e)
        {
            int personelID = Convert.ToInt32(lookUpEditOdaSorumlusuEkle.EditValue);
            oda.PersonelID = personelID;
        }

        private void textEditOdaAdiEkle_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString().Length > 25)
            {
                e.Cancel = true;
                XtraMessageBox.Show("Oda Adının uzunluğunu 10 karakterden fazla giremezsiniz..");
                this.Close();
            }
                

        }
    }
}