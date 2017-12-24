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
    public partial class frmDemirbasKaldir : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasKaldir()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        int demirbasID;

        private void frmDemirbasKaldir_Load(object sender, EventArgs e)
        {
            //Stoktaki demirbaşların bilgilerinin getirilmesi
            lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
        }

        private void lookUpEditKaldirDemirbas_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                demirbasID = Convert.ToInt32(lookUpEditKaldirDemirbas.EditValue);  // seçilen demirbaş
                Demirbaslar demirbas = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);

                //Demirbaşa göre kaldırılacak adet sınırlanması
                spinEditKaldirDemirbasAdet.Properties.MaxValue = Convert.ToInt32(demirbas.DemirbasAdet);
                spinEditKaldirDemirbasAdet.EditValue= Convert.ToInt32(demirbas.DemirbasAdet);

            }
        }
        private void lookUpEditKaldirDemirbas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void spinEditKaldirDemirbasAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }
        private void simpleButtonKaldır_Click_1(object sender, EventArgs e)
        {
           
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (lookUpEditKaldirDemirbas.EditValue != null)
                    {//demirbaş seçilmesi durumunda yapılacak işlemler

                        Demirbaslar demirbas = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);  //seçilen demirbaş
                        //  MessageBox.Show(spinEditKaldirDemirbasAdet.EditValue.ToString()+"  "+ demirbas.DemirbasAdet);

                        if (Convert.ToInt32(spinEditKaldirDemirbasAdet.EditValue) == 0)
                        {//Kaldırılacak demirbaşın adetinn girilmemesi durumu
                            XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                            this.Close();
                        }
                        else if (Convert.ToInt32(spinEditKaldirDemirbasAdet.EditValue) != Convert.ToInt32(demirbas.DemirbasAdet))
                        { //Demirbaşın tamamı kaldırılmayacaksa

                            //Kaldırmak için onay bilgisi
                            DialogResult rs = DevExpress.XtraEditors.XtraMessageBox.Show("Bu Demirbaşlar stoktan kaldırılacak EMİN MİSİNİZ ?", "Kaldırma Bilgisi", MessageBoxButtons.YesNo);
                            if (rs == DialogResult.Yes)//Yes butonunu tıklar isek
                            {
                                int eskiAdet = Convert.ToInt32(demirbas.DemirbasAdet);  //stoktadi demirbaş adetinşn ilk hali

                                demirbas.DemirbasAdet -= Convert.ToInt32(spinEditKaldirDemirbasAdet.EditValue);  // Çıkartıldıktan sonraki hali
                                db.SaveChanges();

                                //Çıkartma bilgisi
                                XtraMessageBox.Show("Stokta bulunan " + demirbas.DemirbasAdi + " demirbaşı sayısı= " + eskiAdet.ToString() + "\n" +
                                                    "Stoktan kaldırılmak istenen " + demirbas.DemirbasAdi + " demirbaşı sayısı= " + spinEditKaldirDemirbasAdet.EditValue + "\n" +
                                                    "Stokta Kalan " + demirbas.DemirbasAdi + " demirbaşı sayısı= " + demirbas.DemirbasAdet);
                                this.Close();

                                //Yeni kaldırma işlemi için alanların temizlenmesi ve güncel demirbaşlar
                                //lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                                //spinEditKaldirDemirbasAdet.EditValue = 0;

                            }
                            else//No butonuna tıklar isek
                            {//yeni kaldırma işlemi için alanların temizlenmesi

                                //lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                                //spinEditKaldirDemirbasAdet.EditValue = 0;
                                this.Close();
                            }
                            

                        }
                        else
                        {//Demirbaşların tamamı kaldırılacaksa 

                            //Kaldrmak için onay bilgisi
                            DialogResult rs = DevExpress.XtraEditors.XtraMessageBox.Show("Bu Demirbaşlar stoktan kaldırılacak EMİN MİSİNİZ ?", "Kaldırma Bilgisi", MessageBoxButtons.YesNo);
                            if (rs == DialogResult.Yes)//Yes butonunu tıklar isek
                            { //tamamı silinir
                                demirbas.DemirbasAdet = 0;
                                demirbas.Durum = true;
                                db.SaveChanges();
                                XtraMessageBox.Show("Tüm " + demirbas.DemirbasAdi + " demirbaşları stoktan kaldırıldı..");
                                this.Close();

                                //Yeni kaldırma işlemi için alanların temizlenmesi ve güncel demirbaşlar
                                //lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                                //spinEditKaldirDemirbasAdet.EditValue = 0;
                                //   spinEditKaldirDemirbasAdet.Properties.MaxValue = 9999;

                            }
                            else//No butonuna tıklar isek
                            { //yeni kaldırma işlemi için alanların temizlenmesi

                            //lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                            //spinEditKaldirDemirbasAdet.EditValue = 0;
                                this.Close();
                            }
                          
                        }

                    }
                    else // Demirbaş seçilmemesi durumunda yapılması gereken işlemler
                    {
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                        this.Close();
                    }
            }
                catch
            {//Diğer hatalar için
                XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                this.Close();
            }
        }

        }

       
    }
}