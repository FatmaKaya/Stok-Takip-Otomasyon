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
    public partial class frmOdaBilgileriGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmOdaBilgileriGuncelle()
        {
            InitializeComponent();
        }
        stokTakipEntities db = new stokTakipEntities();
        private void frmOdaBilgileriGuncelle_Load(object sender, EventArgs e)
        {
            //stoktaki oda bilgilerinin getirilmesi
            lookUpEditOdaBilgileriGuncelle.Properties.DataSource = db.Odalars.ToList();
        }
        int OdaID;
        int PersonelID;
        
        private void lookUpEditOdaBilgileriGuncelle_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                OdaID = Convert.ToInt32(lookUpEditOdaBilgileriGuncelle.EditValue);//seçilen oda id
                //seçilen oda bilgileri ve güncellenecek bilgilerin getirilmesi
                Odalar oda = db.Odalars.First(x => x.OdaID == OdaID);
                textEditOdaAdiGuncelle.Text = oda.OdaAdi;
                lookUpEditOdaSorumlusuGuncelle.Properties.DataSource = db.Personellers.Where(x => x.FakulteID == oda.FakulteID).ToList();
                Fakulteler f = db.Fakultelers.First(x => x.FakulteID == oda.FakulteID);
                textEditFakulteAdiGuncelle.Text = f.FakulteAdi;
                Departmanlar d = db.Departmanlars.First(x => x.DepartmanID == oda.DepartmanID);
                textEditDepartmanAdiGuncelle.Text = d.DepartmanAdi;
                Personeller p = db.Personellers.First(x => x.PersonelID == oda.PersonelID);
                lookUpEditOdaSorumlusuGuncelle.Properties.NullText = p.PersonelAdi;
            }
        }
        private void lookUpEditOdaBilgileriGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar); 
        }
        private void lookUpEditOdaSorumlusuGuncelle_EditValueChanged(object sender, EventArgs e)
        {
            PersonelID = Convert.ToInt32(lookUpEditOdaSorumlusuGuncelle.EditValue);
        }
        private void textEditOdaAdiGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (textEditOdaAdiGuncelle.Text.Length!=0)//Oda adının boş bırakılmadığı durumda yapılacak işlemler
                    {
                        Odalar guncellenecekOda = db.Odalars.First(x => x.OdaID == OdaID);  //güncellenecek oda

                        //Güncel bilgilerin alınması
                        guncellenecekOda.OdaAdi = textEditOdaAdiGuncelle.Text;
                        if (guncellenecekOda.PersonelID != PersonelID)
                        {
                            Odalar o = db.Odalars.First(x => x.OdaID == OdaID);
                            guncellenecekOda.PersonelID = o.PersonelID;
                        }
                        else
                            guncellenecekOda.PersonelID = PersonelID;
                        db.SaveChanges(); //Bilgilerin kaydedilmesi
                        XtraMessageBox.Show("Oda bilgileri güncellendi.");
                        this.Close();

                        //Yeni işlem için alanların temizlenmesi
                        //lookUpEditOdaSorumlusuGuncelle.Properties.NullText = "Oda sorumlusu seçiniz.";
                        //textEditDepartmanAdiGuncelle.Text = null;
                        //textEditFakulteAdiGuncelle.Text = null;
                        //textEditOdaAdiGuncelle.Text = null;
                        //lookUpEditOdaBilgileriGuncelle.Properties.DataSource = db.Odalars.ToList();
                    }
                    else
                    {
                        //Alanların boş olması durumu
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                        this.Close();
                    }

                }

                catch
                {
                    //Diğer hatalar için
                    XtraMessageBox.Show("Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                    this.Close();
                }
            }
        }
    }
}