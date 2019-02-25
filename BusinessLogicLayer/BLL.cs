using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataLogicLayer;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogicLayer
{
    public class BLL
    {

        DataLogicLayer.DLL dll;
        public BLL()
        {
            dll = new DataLogicLayer.DLL();
        }


        //Login Kontrol İşlemi
        public int LooginControl(string kAdi,string sfr)
        {
            try
            {
                if (!string.IsNullOrEmpty(kAdi) & !string.IsNullOrEmpty(sfr))
                {
                    return dll.LooginControl(new kullanicilar { KullaniciAdi=kAdi,KullaniciSifre=sfr});
                }
                else return -1;
             
            }
            catch (Exception)
            {
                return -1;
            }
            finally { }
        }
        //Login Kontrol İşlemi

        // Load Tables GetAllTables
        public DataTable getAllKitapTuleri()
        {
            try
            {
                return dll.getAllKitapTuleri();
            }
            catch (Exception) { return new DataTable(); }
            finally { }
        }
        public DataTable getAllYazarlar()
        {
            try
            {
                return dll.getAllYazarlar();
            }
            catch (Exception) { return new DataTable(); }
            finally { }
        }
        public DataTable getAllYayinEvleri()
        {
            try
            {
                return dll.getAllYayinEvleri();
            }
            catch (Exception) { return new DataTable(); }
            finally { }
        }
        public DataTable getAllKitaplarKitapFiyatlari()
        {
            try
            {
                return dll.getAllKitaplarKitapFiyatlari();
            }
            catch (Exception) { return new DataTable(); }
            finally { }
        }
        public DataTable getAllUyeler()
        {
            try
            {
                return dll.getAllUyeler();
            }
            catch (Exception) { return new DataTable(); }
            finally { }
        }
        public DataTable[] getAllKitapKiralama()
        {
            DataTable[] dt = new DataTable[3];
            try
            {

                dt[0] = dll.getAllKitapKiralamaKiradaOlanlar();
                dt[1] = dll.getAllKitapKiralamaKiralikOlanlar();
                dt[2] = dll.getAllKitapKiralama();
                return dt;
            }
            catch (Exception) { return dt; }
            finally { }
        }
        public DataTable getAllDiller()
        {
            try
            {
                return dll.getAllDiller();
            }
            catch (Exception) { return new DataTable(); }
            finally { }
        }
        // Load Tables GetAllTables


        //Kısa Kitap Bilgileri İşlemleri
        public int getAllKitapSaiyisi()
        {
            try
            {
                return dll.getAllKitapSaiyisi();
            }
            catch (Exception)
            {

                return -1;
            }
        }
        public int getKiradaOlanKitapSaiyisi()
        {
            try
            {
                return dll.getKiradaOlanKitapSaiyisi();
            }
            catch (Exception)
            {

                return -1;
            }
        }
        //Kısa Kitap Bilgileri İşlemleri

        //Kitap Türleri Kayıt Bul ve Silme İşlemleri
        public DataTable getKitapTurleriAtKitapTurKodu(string kitapTurKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(kitapTurKodu))
                {
                    return dll.getKitapTurleriAtKitapTurKodu( new KitapTurleri { KitapTurKodu=kitapTurKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitapTurleriAtKitapTurAdi(string kitapTurAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(kitapTurAdi))
                {
                    return dll.getKitapTurleriAtKitapTurAdi(new KitapTurleri { KitapTuAdi = kitapTurAdi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public int deleteKitapTurleriAtKitapTurKodu(string kitapTurKodu)
        {
            try
            {
                if (!string.IsNullOrEmpty(kitapTurKodu))
                    return dll.deleteKitapTurleriAtKitapTurKodu(new KitapTurleri { KitapTurKodu = kitapTurKodu });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int deleteKitapTurleriAtKitapTurAdi(string kitapTurAdi)
        {
            try
            {
                if (!string.IsNullOrEmpty(kitapTurAdi))
                    return dll.deleteKitapTurleriAtKitapTurAdi(new KitapTurleri { KitapTuAdi = kitapTurAdi });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Kitap Türleri Kayıt Bul ve Silme İşlemleri

        //Yazarlar Evleri Kayıt Bul ve Silme İşlemleri
        public DataTable getYazarlarAtYazarKodu(string yazarKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(yazarKodu))
                {
                    return dll.getYazarlarAtYazarKodu(new Yazarlar { YazarKodu = yazarKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getYazarlarAtYazarAdi(string yazarAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(yazarAdi))
                {
                    return dll.getYazarlarAtYazarAdi(new Yazarlar { YazarAdi = yazarAdi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getYazarlarAtYazarSoyadi(string yazarSoyadi)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(yazarSoyadi))
                {
                    return dll.getYazarlarAtYazarSoyadi(new Yazarlar { YazarSoyadi = yazarSoyadi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public int deleteYazarlarAtYazarKodu(string yazarKodu)
        {
            try
            {
                if (!string.IsNullOrEmpty(yazarKodu))
                    return dll.deleteYazarlarAtYazarKodu(new Yazarlar { YazarKodu = yazarKodu });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int deleteYazarlarAtYazarAdi(string yazarAdi)
        {
            try
            {
                if (!string.IsNullOrEmpty(yazarAdi))
                    return dll.deleteYazarlarAtYazarKodu(new Yazarlar { YazarAdi = yazarAdi });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int deleteYazarlarAtYazarSoyadi(string yazarSoyadi)
        {
            try
            {
                if (!string.IsNullOrEmpty(yazarSoyadi))
                    return dll.deleteYazarlarAtYazarKodu(new Yazarlar { YazarSoyadi = yazarSoyadi });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Yazarlar Evleri Kayıt Bul ve Silme İşlemleri


        //Yayın Evleri Kayıt Bul ve Silme İşlemleri
        public DataTable getYayinEvleriAtFirmaKodu(string FirmaKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(FirmaKodu))
                {
                    return dll.getYayinEvleriAtFirmaKodu(new YayinEvi { YayinEviFirmaKodu = FirmaKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getYayinEvleriAtFirmaAdi(string FirmaAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(FirmaAdi))
                {
                    return dll.getYayinEvleriAtFirmaAdi(new YayinEvi { YayinEviFirmaAdi = FirmaAdi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getYayinEvleriAtFirmaTel(string FirmaTel)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(FirmaTel))
                {
                    return dll.getYayinEvleriAtFirmaTel(new YayinEvi { YayinEviFirmaTelI = FirmaTel, YayinEviFirmaTelII=FirmaTel });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getYayinEvleriAtFirmaFax(string FirmaFax)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(FirmaFax))
                {
                    return dll.getYayinEvleriAtFirmaFax(new YayinEvi { YayinEviFirmaFaxNo = FirmaFax });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public int deleteYayinEvleriAtFirmaKodu(string FirmaKodu)
        {
            try
            {
                if (!string.IsNullOrEmpty(FirmaKodu))
                    return dll.deleteYayinEvleriAtFirmaKodu(new YayinEvi { YayinEviFirmaKodu = FirmaKodu });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Yayın Evleri Kayıt Bul ve Silme İşlemleri




        //Kitaplar Kayıt Bul ve Silme İşlemleri
        public DataTable getKitaplarAtKitapKodu(string KitapKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapKodu))
                {
                    return dll.getKitaplarAtKitapKodu(new Kitaplar { KitapKodu = Guid.Parse(KitapKodu) });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitaplarAtKitapISBN(string KitapISBN)
        {
           
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapISBN))
                {
                    return dll.getKitaplarAtKitapISBN(new Kitaplar { KitapISBN = KitapISBN });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitaplarAtKitapAdi(string KitapAdi)
        {

            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapAdi))
                {
                    return dll.getKitaplarAtKitapAdi(new Kitaplar { KitapAdi = KitapAdi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitaplarAtKitapTurKodu(string KitapTurKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapTurKodu))
                {
                    return dll.getKitaplarAtKitapTurKodu(new Kitaplar { KitapTurKodu = KitapTurKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitaplarAtKitapYazarKodu(string KitapYazarKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapYazarKodu))
                {
                    return dll.getKitaplarAtKitapYazarKodu(new Kitaplar { KitapYazarKodu = KitapYazarKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitaplarAtKitapYayinEviFirmaKodu(string KitapYayinEviFirmaKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapYayinEviFirmaKodu))
                {
                    return dll.getKitaplarAtKitapYayinEviFirmaKodu(new Kitaplar { KitapYayinEviFirmaKodu = KitapYayinEviFirmaKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKitaplarAtKitaDilKodu(string KitapDilKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(KitapDilKodu))
                {
                    return dll.getKitaplarAtKitaDilKodu(new Kitaplar { KitapDilKodu = KitapDilKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public int deleteKitaplarAtKitapKodu(string KitapKodu)
        {
            try
            {
                if (!string.IsNullOrEmpty(KitapKodu))
                    return dll.deleteKitaplarAtKitapKodu(new Kitaplar { KitapKodu = Guid.Parse(KitapKodu) });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Kitaplar Kayıt Bul ve Silme İşlemleri

        //Uyeler Kayıt Bul ve Silme İşlemleri
        public DataTable getUyelerAtUyeKodu(string UyeKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(UyeKodu))
                {
                    return dll.getUyelerAtUyeKodu(new Uyeler { UyeKodu = UyeKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getUyelerAtUyeAdi(string UyeAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(UyeAdi))
                {
                    return dll.getUyelerAtUyeAdi(new Uyeler { UyeAdi = UyeAdi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getUyelerAtUyeSoyadi(string UyeSoyadi)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(UyeSoyadi))
                {
                    return dll.getUyelerAtUyeSoyadi(new Uyeler { UyeSoyadi = UyeSoyadi });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getUyelerAtUyeTel(string UyeTel)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(UyeTel))
                {
                    return dll.getUyelerAtUyeTel(new Uyeler { UyeTel = UyeTel });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public int deleteUyelerAtUyeKodu(string gUyeKodu)
        {
            try
            {
                if (!string.IsNullOrEmpty(gUyeKodu))
                    return dll.deleteUyelerAtUyeKodu(new Uyeler { UyeKodu = gUyeKodu });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Uyeler Kayıt Bul ve Silme İşlemleri

        //Kiralama Kayıt Bul ve Silme İşlemleri
        public DataTable getKiralamaAtKiralamaKodu(string kiralamaKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(kiralamaKodu))
                {
                    return dll.getKiralamaAtKiralamaKodu(new Kiralama { KiralamaKodu = kiralamaKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKiralamaAtKitapKodu(string kitapKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(kitapKodu))
                {
                    return dll.getKiralamaAtKitapKodu(new Kiralama { KiralamaKitapKodu = Guid.Parse(kitapKodu) });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public DataTable getKiralamaAtUyeKodu(string uyeKodu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(uyeKodu))
                {
                    return dll.getKiralamaAtUyeKodu(new Kiralama { KiralamaUyeKodu = uyeKodu });
                }
            }
            catch (Exception) { return dt; }
            finally { }
            return dt;
        }
        public int deleteKiralamaAtKiralamaKodu(string kiralamaKodu)
        {
            try
            {
                if (!string.IsNullOrEmpty(kiralamaKodu))
                    return dll.deleteKiralamaAtKiralamaKodu(new Kiralama { KiralamaKodu = kiralamaKodu });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Kiralama Kayıt Bul ve Silme İşlemleri

        //Kitap Türü Ekleme ve Güncelleme İşlemleri
        public string getNewEntryKitapTurKodu() {
            try
            {
                return dll.getNewEntryKitapTurKodu();
            }
            catch (Exception)
            {

                return "err";
            }
      
        }
        public int updateKitapTurleriAtKitapKodu(string turKodu, string turAdi)
        {
            try
            {
                if (!string.IsNullOrEmpty(turKodu) & !string.IsNullOrEmpty(turAdi))
                    return dll.updateKitapTurleriAtKitapKodu(new KitapTurleri { KitapTurKodu = turKodu,KitapTuAdi= turAdi });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int insertKitapTur(string turKodu, string turAdi)
        {
            try
            {
                if (!string.IsNullOrEmpty(turKodu) & !string.IsNullOrEmpty(turAdi))
                    return dll.insertKitapTur(new KitapTurleri { KitapTurKodu = turKodu, KitapTuAdi = turAdi });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
       
        }
        //Kitap Türü Ekleme ve Güncelleme İşlemleri

        //Yazarlar Ekleme ve Güncelleme İşlemleri
        public string getNewEntryYazarKodu()
        {
            try
            {
                return dll.getNewEntryYazarKodu();
            }
            catch (Exception)
            {

                return "err";
            }

        }
        public int updateYazarlarAtYazarKodu(string yazarKodu, string yazarAdi, string yazarSoyadi)
        {
            try
            {
                if (!string.IsNullOrEmpty(yazarKodu) & !string.IsNullOrEmpty(yazarAdi) & !string.IsNullOrEmpty(yazarSoyadi))
                    return dll.updateYazarlarAtYazarKodu(new Yazarlar { YazarKodu = yazarKodu, YazarAdi = yazarAdi, YazarSoyadi = yazarSoyadi });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int insertYazar(string yazarKodu, string yazarAdi, string yazarSoyadi)
        {
            try
            {
                if (!string.IsNullOrEmpty(yazarKodu) & !string.IsNullOrEmpty(yazarAdi) & !string.IsNullOrEmpty(yazarSoyadi))
                    return dll.insertYazar(new Yazarlar { YazarKodu = yazarKodu, YazarAdi = yazarAdi, YazarSoyadi = yazarSoyadi, });
                else
                    return -1;
            }
            catch (Exception) { return -1; }

        }
        //Yazarlar kleme ve Güncelleme İşlemleri

        //Yayın Evleri Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryYayinEvleriFirmaKodu()
        {

            try
            {
                return dll.getNewEntryYayinEvleriFirmaKodu();
            }
            catch (Exception)
            {

                return "err";
            }
        }
        public int updateYayinEvleriAtFirmaKodu(string firmaKodu, string firmaAdi, string firmaTelI, string firmaTelII, string firmaFax, string firmaEmail, string firmaWebAdresi, string firmaAdresi)
        {
            try
            {
                if (!string.IsNullOrEmpty(firmaKodu) & !string.IsNullOrEmpty(firmaAdi) & !string.IsNullOrEmpty(firmaTelI))
                    return dll.updateYayinEvleriAtFirmaKodu(new YayinEvi
                    {
                        YayinEviFirmaKodu = firmaKodu,
                        YayinEviFirmaAdi = firmaAdi,
                        YayinEviFirmaTelI = firmaTelI,
                        YayinEviFirmaTelII = firmaTelII,
                        YayinEviFirmaFaxNo = firmaFax,
                        YayinEviFirmaEmail = firmaEmail,
                        YayinEviFirmaWebAdres = firmaWebAdresi,
                        YayinEviFirmaAdres = firmaAdresi
                      
                    });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int insertYayinEvi(string firmaKodu, string firmaAdi, string firmaTelI, string firmaTelII, string firmaFax, string firmaEmail, string firmaWebAdresi, string firmaAdresi)
        {
            try
            {
                if (!string.IsNullOrEmpty(firmaKodu) & !string.IsNullOrEmpty(firmaAdi) & !string.IsNullOrEmpty(firmaTelI))
                    return dll.insertYayinEvi(new YayinEvi
                    {
                        YayinEviFirmaKodu = firmaKodu,
                        YayinEviFirmaAdi = firmaAdi,
                        YayinEviFirmaTelI = firmaTelI,
                        YayinEviFirmaTelII = firmaTelII,
                        YayinEviFirmaFaxNo = firmaFax,
                        YayinEviFirmaEmail = firmaEmail,
                        YayinEviFirmaWebAdres = firmaWebAdresi,
                        YayinEviFirmaAdres = firmaAdresi

                    });
                else
                    return -1;
            }
            catch (Exception) { return -1; }

        }
        //Yayın Evleri Kayıt Ekleme ve Güncelleme İşlemler

        //Kitaplar Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryKitaplarAtKitapKodu()
        {
            try
            {
                return dll.getNewEntryKitaplarAtKitapKodu();
            }
            catch (Exception)
            {

                return "err";
            }
        }
        public int updateKitaplarAtKitapKodu(string kitapKodu, string kitapISBN, string kitapAdi, string kitapTurKodu, string kitapYazarKodu, string kitapSayfaSayisi, string YEFirmaKodu, DateTime basimTarihi, string kitapdilKodu,string kitapFiyati, string kitapGunlukKiralamaFiyati)
        {
            try
            {
                if (!string.IsNullOrEmpty(kitapKodu) & !string.IsNullOrEmpty(kitapISBN) & !string.IsNullOrEmpty(kitapAdi) & !string.IsNullOrEmpty(kitapdilKodu))
                    return dll.updateKitaplarAtKitapKodu(new Kitaplar
                    {
                        KitapKodu = Guid.Parse(kitapKodu),
                        KitapISBN = kitapISBN,
                        KitapAdi = kitapAdi,
                        KitapTurKodu = kitapTurKodu,
                        KitapYazarKodu = kitapYazarKodu,
                        KitapSayfaSayisi = int.Parse(kitapSayfaSayisi),
                        KitapYayinEviFirmaKodu = YEFirmaKodu,
                        KitapBasimTarihi = basimTarihi,
                        KitapDilKodu = kitapdilKodu
                    },
                    new KitapFiyatlari
                    {
                        KitapFiyatlariKitapKodu = Guid.Parse(kitapKodu),
                        KitapFiyati = Convert.ToDecimal(kitapFiyati),
                        GunlukKiralamaFiyati = Convert.ToDecimal(kitapGunlukKiralamaFiyati)
                    });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int insertKitap(string kitapKodu, string kitapISBN, string kitapAdi, string kitapTurKodu, string kitapYazarKodu, string kitapSayfaSayisi, string YEFirmaKodu, DateTime basimTarihi, string kitapdilKodu, string kitapFiyati, string kitapGunlukKiralamaFiyati)
        {
            try
            {
                if (!string.IsNullOrEmpty(kitapKodu) & !string.IsNullOrEmpty(kitapISBN) & !string.IsNullOrEmpty(kitapAdi) & !string.IsNullOrEmpty(kitapdilKodu))
                    return dll.insertKitap(new Kitaplar
                    {
                        KitapKodu = Guid.Parse(kitapKodu),
                        KitapISBN = kitapISBN,
                        KitapAdi = kitapAdi,
                        KitapTurKodu = kitapTurKodu,
                        KitapYazarKodu = kitapYazarKodu,
                        KitapSayfaSayisi = int.Parse(kitapSayfaSayisi),
                        KitapYayinEviFirmaKodu = YEFirmaKodu,
                        KitapBasimTarihi = basimTarihi,
                        KitapDilKodu = kitapdilKodu
                    },
                    new KitapFiyatlari
                    {
                        KitapFiyatlariKitapKodu = Guid.Parse(kitapKodu),
                        KitapFiyati = Convert.ToDecimal(kitapFiyati),
                        GunlukKiralamaFiyati = Convert.ToDecimal(kitapGunlukKiralamaFiyati)
                    });
                else
                    return -1;
            }
            catch (Exception err) { return -1; }
        }
        //Kitaplar Kayıt Ekleme ve Güncelleme İşlemler

        //Uyeler Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryUyelerAtUyeKodu()
        {
            try
            {
                return dll.getNewEntryUyelerAtUyeKodu();
            }
            catch (Exception)
            {

                return "err";
            }
        }
        public int updateUyelerAtUyeKodu(string uyeKodu, string UyeAdi, string uyeSoyadi, DateTime uyeDogTarihi, string uyeTel, string uyeEmail, string uyeAdres)
        {
            try
            {
                if (!string.IsNullOrEmpty(uyeKodu) & !string.IsNullOrEmpty(UyeAdi) & !string.IsNullOrEmpty(uyeSoyadi) & !string.IsNullOrEmpty(uyeTel))
                    return dll.updateUyelerAtUyeKodu(new Uyeler
                    {
                        UyeKodu = uyeKodu,
                        UyeAdi = UyeAdi,
                        UyeSoyadi = uyeSoyadi,
                        UyeDogumTarihi = uyeDogTarihi,
                        UyeTel = uyeTel,
                        UyeEmail = uyeEmail,
                        UyeAdres = uyeAdres
            
                    });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        public int insertUye(string uyeKodu, string UyeAdi, string uyeSoyadi, DateTime uyeDogTarihi, string uyeTel, string uyeEmail, string uyeAdres)
        {
            try
            {
                if (!string.IsNullOrEmpty(uyeKodu) & !string.IsNullOrEmpty(UyeAdi) & !string.IsNullOrEmpty(uyeSoyadi) & !string.IsNullOrEmpty(uyeTel))
                    return dll.insertUye(new Uyeler
                    {
                        UyeKodu = uyeKodu,
                        UyeAdi = UyeAdi,
                        UyeSoyadi = uyeSoyadi,
                        UyeDogumTarihi = uyeDogTarihi,
                        UyeTel = uyeTel,
                        UyeEmail = uyeEmail,
                        UyeAdres = uyeAdres
            
                    });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Uyeler Kayıt Ekleme ve Güncelleme İşlemler


        //Kiralama Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryKiralamaAtKiralamaKodu()
        {
            try
            {
                return dll.getNewEntryKiralamaAtKiralamaKodu();
            }
            catch (Exception)
            {

                return "err";
            }
        }
        public int updateKiralamaAtKiralamaKodu(string kiralamaKodu, string kitapKodu, DateTime basTarihi, DateTime bitisTarihi, DateTime veristarihi, string uyeKodu, string kiralamaFiyati, string kiralamaNotu, bool kiralamaBitisDurumu)
        {
            try
            {
                if (!string.IsNullOrEmpty(kiralamaKodu) & !string.IsNullOrEmpty(kitapKodu))
                    return dll.updateKiralamaAtKiralamaKodu(new Kiralama
                    {
                        KiralamaKodu = kiralamaKodu,
                        KiralamaKitapKodu = Guid.Parse(kitapKodu),
                        KiralamaBaslangicTarihi = basTarihi,
                        KiralamaBitisTarihi = bitisTarihi,
                        KiralamaKitapVerisTarihi = veristarihi,
                        KiralamaUyeKodu = uyeKodu,
                        KiralamaFiyati = decimal.Parse(kiralamaFiyati.Substring(0, kiralamaFiyati.Length-7)),
                        KiralamaNotu = kiralamaNotu,
                        KiralamaBitisDurumu = kiralamaBitisDurumu


                    });
                else
                    return -1;
            }
            catch (Exception err) { return -1; }
        }
        public int insertKiralama(string kiralamaKodu, string kitapKodu, DateTime basTarihi, DateTime bitisTarihi, DateTime veristarihi, string uyeKodu, string kiralamaFiyati, string kiralamaNotu, bool kiralamaBitisDurumu)
        {
            try
            {
                if (!string.IsNullOrEmpty(kiralamaKodu) & !string.IsNullOrEmpty(kitapKodu))
                    return dll.insertKiralama(new Kiralama
                    {
                        KiralamaKodu = kiralamaKodu,
                        KiralamaKitapKodu = Guid.Parse(kitapKodu),
                        KiralamaBaslangicTarihi = basTarihi,
                        KiralamaBitisTarihi = bitisTarihi,
                        KiralamaKitapVerisTarihi = veristarihi,
                        KiralamaUyeKodu = uyeKodu,
                        KiralamaFiyati = decimal.Parse(kiralamaFiyati),
                        KiralamaNotu = kiralamaNotu,
                        KiralamaBitisDurumu = kiralamaBitisDurumu

                    });
                else
                    return -1;
            }
            catch (Exception) { return -1; }
        }
        //Kiralama Kayıt Ekleme ve Güncelleme İşlemler

    }
}
