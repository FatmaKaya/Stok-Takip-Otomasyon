using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        stokTakipEntities db = new stokTakipEntities();
        public static Personeller user = new Personeller();//Mdi form'a göndereceğimiz kullanıcı bilgileri

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }
        private void Giriş_Click(object sender, EventArgs e)
        {
            string kullanici = TextEditKullaniciAdi.Text;
            string sifre = TextEditSifre.Text;
          
            using (db = new stokTakipEntities())
            {
                try
                {
                    if (kullanici.Length != 0 && sifre.Length != 0)
                    { // Kullanıcı adı ve şifresinin boş olma durumunun kontrolü
                        Personeller personel = db.Personellers.First(x => x.PersonelAdi == kullanici);
                        
                        if (personel.Sifre == sifre)
                        {// kullanıcı adına göre şifrenin doğru olma kontrolü ve doğruysa sisteme giriş.
                            user = personel;
                            frmMDI mdi = new frmMDI();
                            this.Hide();
                            mdi.Show();
                            //MessageBox.Show("Başarılı giriş.");
                        }
                        else
                        {// şifre hatalı ise
                            MessageBox.Show("Şifre hatalı!.");
                            TextEditSifre.Text = "";
                        }
                           
                    }
                    else
                    {// Alanlar boş ise
                        MessageBox.Show("Lütfen alanları boş bırakmayınız!.");
                    }
                }
                catch
                {// diğer hatalar için
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!.");
                    TextEditSifre.Text = "";
                }
               
            }
  
        }
    }
}
