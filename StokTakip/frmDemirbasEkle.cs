﻿using System;
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
    public partial class frmDemirbasEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasEkle()
        {
            InitializeComponent();
        }
        stokTakipEntities1 db = new stokTakipEntities1();
        int fakulteID;
        int departmanID;
        int demirbasTurID;
        private void frmDemirbasEkle_Load(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities1())
            {
                lookUpEditDemirbasEkleFakulteAdi.Properties.DataSource = db.Fakultelers.ToList();    //Fakültelerin getirilmesi
                lookUpEditDemirbasTur.Properties.DataSource = db.DemirbasTurleris.ToList();    // Demirbaş türlerinin getirilmesi
            }
               
        }
        private void lookUpEditDemirbasEkleFakulteAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities1())
            {
                fakulteID = Convert.ToInt32(lookUpEditDemirbasEkleFakulteAdi.EditValue);     //Seçilen fakülte
                lookUpEditDemirbasEkleDepartmanAdi.Properties.DataSource = db.Departmanlars.Where(x => x.FakulteID == fakulteID).ToList();// Fakülteye göre departmanların getirilmesi
            }
                
        }
        private void lookUpEditDemirbasEkleDepartmanAdi_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities1())
            {
                departmanID = Convert.ToInt32(lookUpEditDemirbasEkleDepartmanAdi.EditValue);   //Seçilen Departman       
            }
               
        }
        private void lookUpEditDemirbasTur_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities1())
            {
                demirbasTurID = Convert.ToInt32(lookUpEditDemirbasTur.EditValue);  //Seçilen demirbaş türü   
            }
                   
        }
        private void TextEditEkleDemirbasAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-';
        }
        private void SimpleButtonEkle_Click(object sender, EventArgs e)
        {
                using (db = new stokTakipEntities1())
                {
                try
                {


                    if (TextEditEkleDemirbasAd.Text.Length != 0)
                    {   // Demirbaş adının boş bırakılmadığı durumlarda yapılacak işlemler

                        //Eklencek demirbaş bilgilerinin alınması
                        Demirbaslar demirbas = new Demirbaslar();
                        demirbas.DemirbasAdi = TextEditEkleDemirbasAd.Text;
                        demirbas.DemirbasAdet = Convert.ToInt32(SpinEditEkleDemirbasAdet.Value);
                        demirbas.AlimTarihi = Convert.ToDateTime(DateTime.Today.ToLongDateString());
                        demirbas.Fiyat = float.Parse(TextEditEkleDemirbasFiyat.Text);
                        demirbas.Durum = false;
                        demirbas.FakulteID = fakulteID;
                        demirbas.DepartmanID = departmanID;
                        demirbas.DemirbasTurID = demirbasTurID;

                        db.Demirbaslars.Add(demirbas);   //Demirbaşlara eklenmesi
                        db.SaveChanges();  //kaydedilmesi


                        //Demirbaş kodunun ayarlanması için 
                        Demirbaslar demirbasUpdate = db.Demirbaslars.First(x => x.DemirbasID == demirbas.DemirbasID);
                        demirbasUpdate.DemirbasKodu = "" + demirbas.FakulteID.ToString() + "." + demirbas.DepartmanID.ToString() + "." + demirbas.DemirbasTurID.ToString() + "." + demirbas.DemirbasID.ToString();

                        db.SaveChanges();   //demirbaş kodunun kaydedilmesi

                        XtraMessageBox.Show("Demirbaş Stoğa eklendi. Yeniden Demirbaş ekleyebilirsiniz..");
                        this.Close();
                    }
                    else
                    {// Boş alan bırakılması durumu
                         XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                        this.Close();
                    }
                }
                catch
                {// diğer hataların kontrolü.
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar ekleyiniz..");
                    this.Close(); this.Close();
                }
            }

        }

        private void TextEditEkleDemirbasFiyat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SpinEditEkleDemirbasAdet_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}