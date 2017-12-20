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
        int fakulteID;
        int departmanID;
        private void frmOdaBilgileriEkle_Load(object sender, EventArgs e)
        {
            //stoktaki fakülte bilgilerinin getirilmesi
            lookUpEditFakulteAdiEkle.Properties.DataSource = db.Fakultelers.ToList();
        }
        private void lookUpEditFakulteAdiEkle_EditValueChanged(object sender, EventArgs e)
        {
            fakulteID = Convert.ToInt32(lookUpEditFakulteAdiEkle.EditValue);
            //stoktaki departman bilgilerinin getirilmesi
            lookUpEditBolumAdiEkle.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();
            oda.FakulteID = fakulteID;
        }
        private void lookUpEditBolumAdiEkle_EditValueChanged(object sender, EventArgs e)
        {
            departmanID = Convert.ToInt32(lookUpEditBolumAdiEkle.EditValue);
            //stoktaki personel bilgilerinin getirilmesi
            lookUpEditOdaSorumlusuEkle.Properties.DataSource = db.Personellers.Where(x => x.DepartmanID == departmanID).ToList();
            oda.DepartmanID = departmanID;
        }
        private void lookUpEditOdaSorumlusuEkle_EditValueChanged(object sender, EventArgs e)
        {
            int personelID = Convert.ToInt32(lookUpEditOdaSorumlusuEkle.EditValue);
            oda.PersonelID = personelID;
        }
        private void textEditOdaAdiEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void simpleButtonOdaKaydet_Click(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (textEditOdaAdiEkle.Text.Length != 0)//Oda adının boş bırakılmadığı durumda yapılacak işlemler
                    {
                        oda.OdaAdi = textEditOdaAdiEkle.Text;
                        var yenioda = new Odalar { OdaAdi = oda.OdaAdi };
                        //aynı odadan eklenmemesinin kontrolü yapılıyor.
                        if (db.Odalars.Any(x => x.OdaAdi == yenioda.OdaAdi && x.FakulteID==fakulteID && x.DepartmanID==departmanID))
                        {
                            XtraMessageBox.Show("Bu oda zaten var. Güncelleme yapmak için yan sekmeye gidiniz..");
                            this.Close();
                        }
                        else
                        {
                            //veritabanına ekleme işlemi gerçekleştiriliyor.
                            db.Odalars.Add(oda);
                            db.SaveChanges();

                            XtraMessageBox.Show("Oda Bilgileri eklendi.");
                            this.Close();
                        }
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
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                    this.Close();
                }
            }
        }
    }
}