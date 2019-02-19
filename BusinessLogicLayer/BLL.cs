using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataLogicLayer;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLL
    {

        DataLogicLayer.DLL dll;
        public BLL()
        {
            dll = new DataLogicLayer.DLL();
        }

        // Start GetAllTables
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

                dt[0]=dll.getAllKitapKiralamaKiradaOlanlar();
                dt[1] = dll.getAllKitapKiralamaKiralikOlanlar();
                dt[2] = dll.getAllKitapKiralama();
                return dt;
            }
            catch (Exception) { return dt; }
            finally { }
        }
        // Start GetAllTables
        public int getAllKitapSaiyisi() {
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
    }
}
