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
            lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
        }

        private void lookUpEditKaldirDemirbas_EditValueChanged(object sender, EventArgs e)
        {
            using (db = new stokTakipEntities())
            {
                demirbasID = Convert.ToInt32(lookUpEditKaldirDemirbas.EditValue);
                Demirbaslar demirbas = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);

                spinEditKaldirDemirbasAdet.Properties.MaxValue = Convert.ToInt32(demirbas.DemirbasAdet);

            }
        }

        private void simpleButtonKaldır_Click_1(object sender, EventArgs e)
        {         
            
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (lookUpEditKaldirDemirbas.EditValue != null)
                    {
                        Demirbaslar demirbas = db.Demirbaslars.First(x => x.DemirbasID == demirbasID);
                      //  MessageBox.Show(spinEditKaldirDemirbasAdet.EditValue.ToString()+"  "+ demirbas.DemirbasAdet);

                        if(Convert.ToInt32(spinEditKaldirDemirbasAdet.EditValue)==0)
                        {
                            XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                        }
                        else if (Convert.ToInt32(spinEditKaldirDemirbasAdet.EditValue) != Convert.ToInt32(demirbas.DemirbasAdet))
                        {

                            int eskiAdet = Convert.ToInt32(demirbas.DemirbasAdet);

                            demirbas.DemirbasAdet -= Convert.ToInt32(spinEditKaldirDemirbasAdet.EditValue);
                            db.SaveChanges();

                            XtraMessageBox.Show("Stokta bulunan " + demirbas.DemirbasAdi + " demirbaşı sayısı= " + eskiAdet.ToString() + "\n" +
                                                "Stoktan kaldırılmak istenen " + demirbas.DemirbasAdi + " demirbaşı sayısı= " + spinEditKaldirDemirbasAdet.EditValue + "\n" +
                                                "Stokta Kalan " + demirbas.DemirbasAdi + " demirbaşı sayısı= " + demirbas.DemirbasAdet);

                            lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                            spinEditKaldirDemirbasAdet.EditValue = 0;
                          
                        }
                        else
                        {
                            db.Demirbaslars.Remove(demirbas);
                            db.SaveChanges();
                            XtraMessageBox.Show("Tüm " + demirbas.DemirbasAdi + " demirbaşları stoktan kaldırıldı..");

                            lookUpEditKaldirDemirbas.Properties.DataSource = db.Demirbaslars.Where(x => x.Durum == false).ToList();
                            spinEditKaldirDemirbasAdet.EditValue = 0;
                         //   spinEditKaldirDemirbasAdet.Properties.MaxValue = 9999;


                        }


                    }
                    else
                        XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                }
                catch
                {
                    XtraMessageBox.Show("Alanları boş bırakmayınız! Lütfen alanları kontrol ederek tekrar deneyiniz..");
                }
            }
        }
    }
}