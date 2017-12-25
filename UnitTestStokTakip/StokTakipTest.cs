using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StokTakip;

namespace UnitTestStokTakip
{
    [TestClass]
    public class StokTakipTest
    {
        [TestMethod]
        public void BaglantıStokTakip()
        {
            stokTakipEntities1 db = new stokTakipEntities1();
        }

        [TestMethod]
        public void GirisTest()
        {
            Personeller p = new Personeller();
            var giris = new frmKullaniciGiris();
            Assert.IsNotNull(giris);
        }
  
        [TestMethod]
        public void GirisYapTest()
        {
            int beklenenSonuc = 0;

            string kullanici = "fatmakaya";
            string sifre = "1234asdf";

            frmKullaniciGiris form= new frmKullaniciGiris();
            int sonuc = form.GirisYap(kullanici,sifre);

            Assert.AreEqual(beklenenSonuc, sonuc);
            
        }

        [TestMethod]
        public void PersonelUzerindekiDemirbasAraTest()
        {
            int beklenensonuc = 0;

            string personel = "";

            frmPersonelUzerindekiDemirbasArama form = new frmPersonelUzerindekiDemirbasArama();
            int sonuc = form.PersonelUzerindekiDemirbaslariAra(personel);

            Assert.AreEqual(beklenensonuc, sonuc);
        }

        [TestMethod]
        public void CikisYapTest()
        {
            int beklenensonuc = 1;
            frmMDI form = new frmMDI();
            int sonuc = form.CikisYap();
            Assert.AreEqual(beklenensonuc, sonuc);
        }
    }
}
