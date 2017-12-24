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

        stokTakipEntities1 db = new stokTakipEntities1();
        public static Personeller user = new Personeller();//Mdi form'a göndereceğimiz kullanıcı bilgileri

        private void TextEditKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {//Girilebilecek değerler
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void TextEditSifre_KeyPress(object sender, KeyPressEventArgs e)
        {//Girilebilecek değerler
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.';
        }

        public int GirisYap(string kullanici, string sifre)
        {//Test için giriş yap fonksiyonu
            int a=0;
            using (db = new stokTakipEntities1())
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
                            a = 1;
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
            return a;
        }
        private void Giriş_Click(object sender, EventArgs e)
        {//giriş yapıldığında
            GirisYap(TextEditKullaniciAdi.Text, TextEditSifre.Text);  
        }       
    }
}
