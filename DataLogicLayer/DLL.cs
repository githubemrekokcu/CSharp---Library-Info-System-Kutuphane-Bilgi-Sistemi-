using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLayer
{
    public class DLL
    {
        private SqlConnection connect;// = new SqlConnection("server=.;database=TelefonRehberi;user id=sa; password=1234");
        private SqlCommand cmd;
        public DLL()
        {
            connect = new SqlConnection("server =.; database =kutuphane; user id = sa; password = 1234");
            cmd = new SqlCommand();


        }

        private bool ConnectionOption(bool State)
        {
            if (State & connect.State == System.Data.ConnectionState.Closed)
            { connect.Open(); return true; }
            else if (!State & connect.State == System.Data.ConnectionState.Open)
            { connect.Close(); return true; }
            else return false;

        }
        //Login Kontrol İşlemi
        public int LooginControl(kullanicilar kullanicilar) {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "Select count(*) from kullanicilar where kullanici_adi='"+ kullanicilar.KullaniciAdi+ "' and kullanici_sifre='"+kullanicilar.KullaniciSifre+"'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
            finally { ConnectionOption(false); }
        }
        //Login Kontrol İşlemi


        // Load Tables GetAllTables
        public DataTable getAllKitapTuleri()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from kitapturleri", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllYazarlar()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yazarlar", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllYayinEvleri()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yayinevi", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllKitaplarKitapFiyatlari()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu", connect);
                adapter.Fill(dT);   
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllUyeler()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from uyeler", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllKitapKiralamaKiradaOlanlar()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select kr.k_id,kr.k_kodu,kr.k_ktp_kodu,k.ktp_adi,kr.k_baslangictarihi,kr.k_bitistarihi,kr.k_veristarihi,kr.k_u_kodu,u.u_adi+' '+u.u_soyadi as UyeAdiSoyadi,kr.k_fiyati,kr.k_notu,kr.k_bitisdurumu from kiralama kr  inner join kitaplar k on k.ktp_kodu=kr.k_ktp_kodu inner join uyeler u on u.u_kodu=kr.k_u_kodu where k_bitisdurumu=0", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllKitapKiralamaKiralikOlanlar()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from kitaplar k where k.ktp_kodu not in(select kr.k_ktp_kodu from kiralama kr where kr.k_bitisdurumu=0)", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllKitapKiralama()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select k.k_id,k.k_kodu,k.k_ktp_kodu,ktp.ktp_adi,k.k_baslangictarihi,k.k_bitistarihi,k.k_veristarihi,k.k_u_kodu,u.u_adi+' '+u.u_soyadi as Uyeadisoyadi,k.k_fiyati,k.k_notu,k.k_bitisdurumu  from kiralama k inner join uyeler u on u.u_kodu=k.k_u_kodu inner join kitaplar ktp on ktp.ktp_kodu=k.k_ktp_kodu ", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getAllDiller()
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from diller", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        // Load Tables GetAllTables

        //Kısa Kitap Bilgileri İşlemleri
        public int getAllKitapSaiyisi() {

            try
            {
                ConnectionOption(true);
                cmd.CommandText = "select count(*) from kitaplar";
                cmd.Connection = connect;
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int getKiradaOlanKitapSaiyisi()
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "Select count(*) from kiralama kr  inner join kitaplar k on k.ktp_kodu=kr.k_ktp_kodu inner join uyeler u on u.u_kodu=kr.k_u_kodu where k_bitisdurumu=0";
                cmd.Connection = connect;
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kısa Kitap Bilgileri İşlemleri


        //Kitap Türleri Kayıt Bul ve Silme İşlemleri
        public DataTable getKitapTurleriAtKitapTurKodu(KitapTurleri kitapTurleri)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from kitapturleri where kt_kodu='"+kitapTurleri.KitapTurKodu+"'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitapTurleriAtKitapTurAdi(KitapTurleri kitapTurleri)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from kitapturleri where kt_adi='" + kitapTurleri.KitapTuAdi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public int deleteKitapTurleriAtKitapTurKodu(KitapTurleri kitapTurleri)
        {
          
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from kitapturleri where kt_kodu='" + kitapTurleri.KitapTurKodu + "'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int deleteKitapTurleriAtKitapTurAdi(KitapTurleri kitapTurleri)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from kitapturleri where kt_adi='" + kitapTurleri.KitapTuAdi + "'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kitap Türleri Kayıt Bul ve Silme İşlemleri

        //Yazarlar Kayıt Bul ve Silme İşlemleri
        public DataTable getYazarlarAtYazarKodu(Yazarlar yazarlar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yazarlar where y_kodu='" + yazarlar.YazarKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getYazarlarAtYazarAdi(Yazarlar yazarlar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yazarlar where y_adi='" + yazarlar.YazarAdi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getYazarlarAtYazarSoyadi(Yazarlar yazarlar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yazarlar where y_soyadi='" + yazarlar.YazarSoyadi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public int deleteYazarlarAtYazarKodu(Yazarlar yazarlar)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from yazarlar where y_kodu='" + yazarlar.YazarKodu + "'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int deleteYazarlarAtYazarAdi(Yazarlar yazarlar)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from yazarlar where y_adi='" + yazarlar.YazarAdi + "'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int deleteYazarlarAtYazarSoyadi(Yazarlar yazarlar)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from yazarlar where y_soyadi='" + yazarlar.YazarSoyadi + "'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Yazarlar Kayıt Bul ve Silme İşlemleri

        //Yayın Evleri Kayıt Bul ve Silme İşlemleri
        public DataTable getYayinEvleriAtFirmaKodu(YayinEvi yayinEvi)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yayinevi where ye_firmakodu='" + yayinEvi.YayinEviFirmaKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getYayinEvleriAtFirmaAdi(YayinEvi yayinEvi)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yayinevi where ye_firmaadi='" + yayinEvi.YayinEviFirmaAdi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getYayinEvleriAtFirmaTel(YayinEvi yayinEvi)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yayinevi where ye_firmatelI='" + yayinEvi.YayinEviFirmaTelI + "' or ye_firmatelII='" + yayinEvi.YayinEviFirmaTelII + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getYayinEvleriAtFirmaFax(YayinEvi yayinEvi)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from yayinevi where ye_firmafaxno='" + yayinEvi.YayinEviFirmaFaxNo + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public int deleteYayinEvleriAtFirmaKodu(YayinEvi yayinEvi)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from yayinevi where ye_firmakodu='" + yayinEvi.YayinEviFirmaKodu + "'";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Yayın Evleri Kayıt Bul ve Silme İşlemleri

        //Kitaplar Kayıt Bul ve Silme İşlemleri
        public DataTable getKitaplarAtKitapKodu(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati "+
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu"+
                    " where k.ktp_kodu='" + kitaplar.KitapKodu+"'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitaplarAtKitapISBN(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati " +
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu" +
                    " where k.ktp_ISBN='" + kitaplar.KitapISBN + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitaplarAtKitapAdi(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati " +
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu" +
                    " where k.ktp_adi='" + kitaplar.KitapAdi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitaplarAtKitapTurKodu(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati " +
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu" +
                    " where k.ktp_kt_kodu='" + kitaplar.KitapTurKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitaplarAtKitapYazarKodu(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati " +
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu" +
                    " where k.ktp_y_kodu='" + kitaplar.KitapYazarKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitaplarAtKitapYayinEviFirmaKodu(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati " +
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu" +
                    " where k.ktp_ye_firmakodu='" + kitaplar.KitapYayinEviFirmaKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKitaplarAtKitaDilKodu(Kitaplar kitaplar)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select k.*,kf.ktp_fiyati,kf.ktp_gunlukkiralamafiyati " +
                    "from kitaplar k inner Join kitapfiyatlari kf on k.ktp_kodu=kf.ktp_kodu" +
                    " where k.ktp_d_kodu='" + kitaplar.KitapDilKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public int deleteKitaplarAtKitapKodu(Kitaplar kitaplar)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from kitapfiyatlari where ktp_kodu='" + kitaplar.KitapKodu + "';delete from kiralama where k_ktp_kodu='" + kitaplar.KitapKodu + "';delete from kitaplar where ktp_kodu='" + kitaplar.KitapKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kitaplar Kayıt Bul ve Silme İşlemleri

        //Uyeler Kayıt Bul ve Silme İşlemleri
        public DataTable getUyelerAtUyeKodu(Uyeler uyeler)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from uyeler where u_kodu='"+uyeler.UyeKodu+"'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getUyelerAtUyeAdi(Uyeler uyeler)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from uyeler where u_adi='" + uyeler.UyeAdi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getUyelerAtUyeSoyadi(Uyeler uyeler)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from uyeler where u_soyadi='" + uyeler.UyeSoyadi + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getUyelerAtUyeTel(Uyeler uyeler)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from uyeler where u_tel='" + uyeler.UyeTel + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public int deleteUyelerAtUyeKodu(Uyeler uyeler)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from uyeler where u_kodu='" + uyeler.UyeKodu+ "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Uyeler Kayıt Bul ve Silme İşlemleri

        //Kiralama Kayıt Bul ve Silme İşlemleri
        public DataTable getKiralamaAtKiralamaKodu(Kiralama kiralama)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select k.k_id,k.k_kodu,k.k_ktp_kodu,ktp.ktp_adi,k.k_baslangictarihi,k.k_bitistarihi,k.k_veristarihi,k.k_u_kodu,u.u_adi+' '+u.u_soyadi as Uyeadisoyadi,k.k_fiyati,k.k_notu,k.k_bitisdurumu  "+
                    "from kiralama k inner join uyeler u on u.u_kodu=k.k_u_kodu inner join kitaplar ktp on ktp.ktp_kodu=k.k_ktp_kodu "+
                    "where k.k_kodu='"+kiralama.KiralamaKodu+"'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKiralamaAtKitapKodu(Kiralama kiralama)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select k.k_id,k.k_kodu,k.k_ktp_kodu,ktp.ktp_adi,k.k_baslangictarihi,k.k_bitistarihi,k.k_veristarihi,k.k_u_kodu,u.u_adi+' '+u.u_soyadi as Uyeadisoyadi,k.k_fiyati,k.k_notu,k.k_bitisdurumu  " +
                    "from kiralama k inner join uyeler u on u.u_kodu=k.k_u_kodu inner join kitaplar ktp on ktp.ktp_kodu=k.k_ktp_kodu " +
                    "where k.k_ktp_kodu='" + kiralama.KiralamaKitapKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public DataTable getKiralamaAtUyeKodu(Kiralama kiralama)
        {
            DataTable dT = new DataTable();
            try
            {
                ConnectionOption(true);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select k.k_id,k.k_kodu,k.k_ktp_kodu,ktp.ktp_adi,k.k_baslangictarihi,k.k_bitistarihi,k.k_veristarihi,k.k_u_kodu,u.u_adi+' '+u.u_soyadi as Uyeadisoyadi,k.k_fiyati,k.k_notu,k.k_bitisdurumu  " +
                    "from kiralama k inner join uyeler u on u.u_kodu=k.k_u_kodu inner join kitaplar ktp on ktp.ktp_kodu=k.k_ktp_kodu " +
                    "where k.k_u_kodus='" + kiralama.KiralamaUyeKodu + "'", connect);
                adapter.Fill(dT);
                return dT;
            }
            catch (Exception) { return dT; }
            finally { ConnectionOption(false); }
        }
        public int deleteKiralamaAtKiralamaKodu(Kiralama kiralama)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "delete from kiralama where k_kodu='" + kiralama.KiralamaKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kiralama Kayıt Bul ve Silme İşlemleri

        //Kitap Türü Ekleme ve Güncelleme İşlemleri
        public string getNewEntryKitapTurKodu()
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "select top 1 k.kt_kodu from kitapturleri k order by kt_kodu desc;";
                cmd.Connection = connect;
                string newTurCode = cmd.ExecuteScalar().ToString();
                string newTurCodeLeft = newTurCode.Substring(0, 4), newTurCodeRight = newTurCode.Substring(4, 2);
                newTurCodeRight = Convert.ToInt32(newTurCodeRight) > 9 ? (Convert.ToInt32(newTurCodeRight) + 1).ToString() : "0" + (Convert.ToInt32(newTurCodeRight) + 1).ToString();
                newTurCode = newTurCodeLeft + newTurCodeRight;
                return newTurCode;
            }
            catch (Exception)
            {

                return "err";
            }
            finally { ConnectionOption(false); }

        }
        public int updateKitapTurleriAtKitapKodu(KitapTurleri kitapTurleri)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "update kitapturleri set "+
                    "kt_adi='"+kitapTurleri.KitapTuAdi+"'" +
                    " where kt_kodu='" + kitapTurleri.KitapTurKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int insertKitapTur(KitapTurleri kitapTurleri)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "insert into kitapturleri VALUES (" +
                    "@TurKodu,@TurAdi);";
                cmd.Parameters.AddWithValue("@TurKodu", kitapTurleri.KitapTurKodu);
                cmd.Parameters.AddWithValue("@TurAdi", kitapTurleri.KitapTuAdi);
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kitap Türü Ekleme ve Güncelleme İşlemleri

        //Yazarlar Kayıt Ekleme ve Güncelleme İşlemleri
        public string getNewEntryYazarKodu()
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "select top 1 y.y_kodu from yazarlar y order by y.y_kodu desc;";
                cmd.Connection = connect;
                string newYazarCode = cmd.ExecuteScalar().ToString();
                string newYazarCodeLeft = newYazarCode.Substring(0, 3), newYazarCodeRight = newYazarCode.Substring(3, 5);
                if (Convert.ToInt32(newYazarCodeRight)>9999)
                {
                    newYazarCodeRight =(Convert.ToInt32(newYazarCodeRight) + 1).ToString();
                }
                else if (Convert.ToInt32(newYazarCodeRight) > 999)
                {
                    newYazarCodeRight = "0" + (Convert.ToInt32(newYazarCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newYazarCodeRight) > 99)
                {
                    newYazarCodeRight = "00" + (Convert.ToInt32(newYazarCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newYazarCodeRight) > 9)
                {
                    newYazarCodeRight = "000" + (Convert.ToInt32(newYazarCodeRight) + 1).ToString();

                }
                else
                {
                    newYazarCodeRight = "0000" + (Convert.ToInt32(newYazarCodeRight) + 1).ToString();

                }
                newYazarCode = newYazarCodeLeft + newYazarCodeRight;
                return newYazarCode;
            }
            catch (Exception)
            {

                return "err";
            }
            finally { ConnectionOption(false); }

        }
        public int updateYazarlarAtYazarKodu(Yazarlar yazarlar)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "update yazarlar set " +
                    "y_adi='" + yazarlar.YazarAdi + "'," +
                    "y_soyadi='" + yazarlar.YazarSoyadi + "'" +
                    " where y_kodu='" + yazarlar.YazarKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int insertYazar(Yazarlar yazarlar)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "insert into yazarlar VALUES (" +
                    "@YazarKodu,@YazarAdi,@YazarSoyadi);";
                cmd.Parameters.AddWithValue("@YazarKodu", yazarlar.YazarKodu);
                cmd.Parameters.AddWithValue("@YazarAdi", yazarlar.YazarAdi);
                cmd.Parameters.AddWithValue("@YazarSoyadi", yazarlar.YazarSoyadi);
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Yazarlar Kayıt Ekleme ve Güncelleme İşlemleri


        //Yayın Evleri Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryYayinEvleriFirmaKodu()
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "select top 1 y.ye_firmakodu from yayinevi y order by y.ye_firmakodu desc;";
                cmd.Connection = connect;
                string newFirmaCode = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(newFirmaCode))
                {
                    return "YEFK-0000";
                }
                string newFiemaCodeLeft = newFirmaCode.Substring(0, 5), newFirmaCodeRight = newFirmaCode.Substring(5, 4);
                if (Convert.ToInt32(newFirmaCodeRight) > 999)
                {
                    newFirmaCodeRight = (Convert.ToInt32(newFirmaCodeRight) + 1).ToString();
                }
                else if (Convert.ToInt32(newFirmaCodeRight) > 99)
                {
                    newFirmaCodeRight = "0" + (Convert.ToInt32(newFirmaCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newFirmaCodeRight) > 9)
                {
                    newFirmaCodeRight = "00" + (Convert.ToInt32(newFirmaCodeRight) + 1).ToString();

                }
                else
                {
                    newFirmaCodeRight = "000" + (Convert.ToInt32(newFirmaCodeRight) + 1).ToString();

                }
                newFirmaCode = newFiemaCodeLeft + newFirmaCodeRight;
                return newFirmaCode;
            }
            catch (Exception)
            {

                return "err";
            }
            finally { ConnectionOption(false); }
        }
        public int updateYayinEvleriAtFirmaKodu(YayinEvi yayinEvi)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "update yayinevi set " +
                    "ye_firmaadi='" + yayinEvi.YayinEviFirmaAdi + "'," +
                    "ye_firmatelI='" + yayinEvi.YayinEviFirmaTelI + "'," +
                    "ye_firmatelII='" + yayinEvi.YayinEviFirmaTelII + "'," +
                    "ye_firmafaxno='" + yayinEvi.YayinEviFirmaFaxNo + "'," +
                    "ye_firmaemail='" + yayinEvi.YayinEviFirmaEmail + "'," +
                    "ye_firmawebadresi='" + yayinEvi.YayinEviFirmaWebAdres + "'," +
                    "ye_firmaadresi='" + yayinEvi.YayinEviFirmaAdres + "'" +
                    " where ye_firmakodu='" + yayinEvi.YayinEviFirmaKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int insertYayinEvi(YayinEvi yayinEvi)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "insert into yayinevi VALUES (" +
                    "@FirmaKodu,@FirmaAdi,@FirmaTelI,@FirmaTelII,@FirmaFax,@FirmaEmail,@FirmaWebAdres,@FirmaAdres);";
                cmd.Parameters.AddWithValue("@FirmaKodu", yayinEvi.YayinEviFirmaKodu);
                cmd.Parameters.AddWithValue("@FirmaAdi", yayinEvi.YayinEviFirmaAdres);
                cmd.Parameters.AddWithValue("@FirmaTelI", yayinEvi.YayinEviFirmaTelI);
                cmd.Parameters.AddWithValue("@FirmaTelII", yayinEvi.YayinEviFirmaTelII);
                cmd.Parameters.AddWithValue("@FirmaFax", yayinEvi.YayinEviFirmaFaxNo);
                cmd.Parameters.AddWithValue("@FirmaEmail", yayinEvi.YayinEviFirmaEmail);
                cmd.Parameters.AddWithValue("@FirmaWebAdres", yayinEvi.YayinEviFirmaWebAdres);
                cmd.Parameters.AddWithValue("@FirmaAdres", yayinEvi.YayinEviFirmaAdres);
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Yayın Evleri Kayıt Ekleme ve Güncelleme İşlemler

        //Kitaplar Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryKitaplarAtKitapKodu()
        {
            try
            {
                return Guid.NewGuid().ToString();
            }
            catch (Exception)
            {

                return "err";
            }
        }
        public int updateKitaplarAtKitapKodu(Kitaplar kitaplar, KitapFiyatlari kitapFiyatlari)
        {
            try
            {
                ConnectionOption(true);
 
                cmd.CommandText = "update kitaplar set " +
                    "ktp_ISBN='" + kitaplar.KitapISBN + "'," +
                    "ktp_adi='" + kitaplar.KitapAdi + "'," +
                    "ktp_kt_kodu='" + kitaplar.KitapTurKodu + "'," +
                    "ktp_y_kodu='" + kitaplar.KitapYazarKodu + "'," +
                    "ktp_sayfasayisi='" + kitaplar.KitapSayfaSayisi + "'," +
                    "ktp_ye_firmakodu='" + kitaplar.KitapYayinEviFirmaKodu + "'," +
                    "ktp_basimtarihi='" + kitaplar.KitapBasimTarihi.ToString("yyyy.MM.dd") + "'," +
                    "ktp_d_kodu='" + kitaplar.KitapDilKodu + "'" +
                    " where ktp_kodu='" + kitaplar.KitapKodu + "';"+

                    "update kitapfiyatlari set " +
                    "ktp_fiyati='" + kitapFiyatlari.KitapFiyati + "'," +
                    "ktp_gunlukkiralamafiyati='" + kitapFiyatlari.GunlukKiralamaFiyati + "'" +
                    " where ktp_kodu='" + kitapFiyatlari.KitapFiyatlariKitapKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int insertKitap(Kitaplar kitaplar,KitapFiyatlari kitapFiyatlari)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "insert into kitaplar VALUES (" +
                    "@KitapKodu,@KitapISBN,@KitapAdi,@KitapTurKodu,@KitapYazarKodu,@KitapSayfaSayisi,@KitapYayinEviFirmaKodu,@BasimTarihi,@KitapDilKodu);";
                cmd.Parameters.AddWithValue("@KitapKodu", kitaplar.KitapKodu);
                cmd.Parameters.AddWithValue("@KitapISBN", kitaplar.KitapISBN);
                cmd.Parameters.AddWithValue("@KitapAdi", kitaplar.KitapAdi);
                cmd.Parameters.AddWithValue("@KitapTurKodu", kitaplar.KitapTurKodu);
                cmd.Parameters.AddWithValue("@KitapYazarKodu", kitaplar.KitapYazarKodu);
                cmd.Parameters.AddWithValue("@KitapSayfaSayisi", kitaplar.KitapSayfaSayisi);
                cmd.Parameters.AddWithValue("@KitapYayinEviFirmaKodu", kitaplar.KitapYayinEviFirmaKodu);
                cmd.Parameters.AddWithValue("@BasimTarihi", kitaplar.KitapBasimTarihi.ToString("yyyy.MM.dd"));
                cmd.Parameters.AddWithValue("@KitapDilKodu", kitaplar.KitapDilKodu);
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                cmd.CommandText= "insert into kitapfiyatlari VALUES (" +
                     "@KitapFKodu,@KitapFiyati,@KitapGunlukKiralamaFiyati);"; 
                cmd.Parameters.AddWithValue("@KitapFKodu", kitapFiyatlari.KitapFiyatlariKitapKodu);
                cmd.Parameters.AddWithValue("@KitapFiyati", kitapFiyatlari.KitapFiyati);
                cmd.Parameters.AddWithValue("@KitapGunlukKiralamaFiyati", kitapFiyatlari.GunlukKiralamaFiyati);
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kitaplar Kayıt Ekleme ve Güncelleme İşlemler

        //Uyeler Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryUyelerAtUyeKodu()
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "select top 1 y.u_kodu from uyeler y order by y.u_kodu desc;";
                cmd.Connection = connect;
                string newUyeCode = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(newUyeCode))
                {
                    return "UK-00000";
                }
                string newUyeCodeLeft = newUyeCode.Substring(0, 3), newUyeCodeRight = newUyeCode.Substring(3, 5);
                if (Convert.ToInt32(newUyeCodeRight) > 9999)
                {
                    newUyeCodeRight = (Convert.ToInt32(newUyeCodeRight) + 1).ToString();
                }
                else if (Convert.ToInt32(newUyeCodeRight) > 999)
                {
                    newUyeCodeRight = "0" + (Convert.ToInt32(newUyeCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newUyeCodeRight) > 99)
                {
                    newUyeCodeRight = "00" + (Convert.ToInt32(newUyeCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newUyeCodeRight) > 9)
                {
                    newUyeCodeRight = "000" + (Convert.ToInt32(newUyeCodeRight) + 1).ToString();

                }
                else
                {
                    newUyeCodeRight = "0000" + (Convert.ToInt32(newUyeCodeRight) + 1).ToString();

                }
                newUyeCode = newUyeCodeLeft + newUyeCodeRight;
                return newUyeCode;
            }
            catch (Exception)
            {

                return "err";
            }
            finally { ConnectionOption(false); }
        }
        public int updateUyelerAtUyeKodu(Uyeler uyeler)
        {
            try
            {
                ConnectionOption(true);

                cmd.CommandText = "update uyeler set " +
                    "u_adi='" + uyeler.UyeAdi + "'," +
                    "u_soyadi='" + uyeler.UyeSoyadi + "'," +
                    "u_dogumtarihi='" + uyeler.UyeDogumTarihi.ToString("yyyy.MM.dd") + "'," +
                    "u_tel='" + uyeler.UyeTel + "'," +
                    "u_email='" + uyeler.UyeEmail + "'," +
                    "u_adres='" + uyeler.UyeAdi + "'" +
                    " where u_kodu='" + uyeler.UyeKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int insertUye(Uyeler uyeler)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "insert into uyeler VALUES (" +
                    "@UyeKodu,@UyeAdi,@UyeSoyadi,@UyeDogTarihi,@UyeTel,@UyeEmail,@UyeAdres);";
                cmd.Parameters.AddWithValue("@UyeKodu", uyeler.UyeKodu);
                cmd.Parameters.AddWithValue("@UyeAdi", uyeler.UyeAdi);
                cmd.Parameters.AddWithValue("@UyeSoyadi", uyeler.UyeSoyadi);
                cmd.Parameters.AddWithValue("@UyeDogTarihi", uyeler.UyeDogumTarihi.ToString("yyyy.MM.dd"));
                cmd.Parameters.AddWithValue("@UyeTel", uyeler.UyeTel);
                cmd.Parameters.AddWithValue("@UyeEmail", uyeler.UyeEmail);
                cmd.Parameters.AddWithValue("@UyeAdres", uyeler.UyeAdres);
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Uyeler Kayıt Ekleme ve Güncelleme İşlemler

        //Kiralama Kayıt Ekleme ve Güncelleme İşlemler
        public string getNewEntryKiralamaAtKiralamaKodu()
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "select top 1 y.k_kodu from kiralama y order by y.k_kodu desc;";
                cmd.Connection = connect;
                string newKiralamaCode = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(newKiralamaCode))
                {
                    return "KK-0000000";
                }
                string newKiralamaCodeLeft = newKiralamaCode.Substring(0, 3), newKiralamaCodeRight = newKiralamaCode.Substring(3, 7);
                if (Convert.ToInt32(newKiralamaCodeRight) > 999999)
                {
                    newKiralamaCodeRight = (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();
                }
                else if (Convert.ToInt32(newKiralamaCodeRight) > 99999)
                {
                    newKiralamaCodeRight = "0" + (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newKiralamaCodeRight) > 9999)
                {
                    newKiralamaCodeRight = "00" + (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newKiralamaCodeRight) > 999)
                {
                    newKiralamaCodeRight = "000" + (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newKiralamaCodeRight) > 99)
                {
                    newKiralamaCodeRight = "0000" + (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();

                }
                else if (Convert.ToInt32(newKiralamaCodeRight) > 9)
                {
                    newKiralamaCodeRight = "00000" + (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();

                }
                else
                {
                    newKiralamaCodeRight = "000000" + (Convert.ToInt32(newKiralamaCodeRight) + 1).ToString();

                }
                newKiralamaCode = newKiralamaCodeLeft + newKiralamaCodeRight;
                return newKiralamaCode;
            }
            catch (Exception)
            {

                return "err";
            }
            finally { ConnectionOption(false); }
        }
        public int updateKiralamaAtKiralamaKodu(Kiralama kiralama)
        {
            try
            {
                ConnectionOption(true);

                cmd.CommandText = "update kiralama set " +
                    "k_ktp_kodu='" + kiralama.KiralamaKitapKodu + "'," +
                    "k_baslangictarihi='" + kiralama.KiralamaBaslangicTarihi.ToString("yyyy.MM.dd") + "'," +
                    "k_bitistarihi='" + kiralama.KiralamaBitisTarihi.ToString("yyyy.MM.dd") + "'," +
                    "k_veristarihi='" + kiralama.KiralamaKitapVerisTarihi.ToString("yyyy.MM.dd") + "'," +
                    "k_u_kodu='" + kiralama.KiralamaUyeKodu + "'," +           
                    "k_fiyati='" + kiralama.KiralamaFiyati + "'," +
                    "k_notu='" + kiralama.KiralamaNotu + "'," +
                    "k_bitisdurumu='" + kiralama.KiralamaBitisDurumu + "'" +
                    " where k_kodu='" + kiralama.KiralamaKodu + "';";
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        public int insertKiralama(Kiralama kiralama)
        {
            try
            {
                ConnectionOption(true);
                cmd.CommandText = "insert into kiralama VALUES (" +
                    "@KKodu,@KitapKodu,@BasTarihi,@BitisTarihisi,@VerisTarihi,@UyeKodu,@KiralamaFiyati,@KiralamaNotu,@KiralamaBitisDurumu);";
                cmd.Parameters.AddWithValue("@KKodu", kiralama.KiralamaKodu);
                cmd.Parameters.AddWithValue("@KitapKodu", kiralama.KiralamaKitapKodu);
                cmd.Parameters.AddWithValue("@BasTarihi", kiralama.KiralamaBaslangicTarihi.ToString("yyyy.MM.dd"));
                cmd.Parameters.AddWithValue("@BitisTarihisi", kiralama.KiralamaBitisTarihi.ToString("yyyy.MM.dd"));
                cmd.Parameters.AddWithValue("@VerisTarihi", kiralama.KiralamaKitapVerisTarihi.ToString("yyyy.MM.dd"));
                cmd.Parameters.AddWithValue("@UyeKodu", kiralama.KiralamaUyeKodu);
                cmd.Parameters.AddWithValue("@KiralamaFiyati", kiralama.KiralamaFiyati);
                cmd.Parameters.AddWithValue("@KiralamaNotu", kiralama.KiralamaNotu);
                cmd.Parameters.AddWithValue("@KiralamaBitisDurumu", kiralama.KiralamaBitisDurumu);
                cmd.Connection = connect;
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception err) { return -1; }
            finally { ConnectionOption(false); }
        }
        //Kiralama Kayıt Ekleme ve Güncelleme İşlemler
    }
}
    