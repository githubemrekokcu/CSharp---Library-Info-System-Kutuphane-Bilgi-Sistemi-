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
    }
}
    