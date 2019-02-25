using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneBilgiSistemi
{
    public partial class MainForm : Form
    {
        public static string AranacakKodAdi;
        public static string SecilenKodAdi;

        BusinessLogicLayer.BLL bll;
        public MainForm()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbbox_KayitAraKitapTurleri.SelectedIndex = 0;
            cbbox_KayitAraYazarlar.SelectedIndex = 0;
            cbbox_KayitAraYayinEvleri.SelectedIndex = 0;
            cbbox_KayitAraUyeler.SelectedIndex = 0;
            cbbox_KayitAraKitaplar.SelectedIndex = 0;
            cbbox_KayitAraKitapKiralama.SelectedIndex = 0;
            BindKitapKisaBilgiler();


        }

        private void BindKitapKisaBilgiler()
        {
            lbl_toplamKitapSayisi.Text = bll.getAllKitapSaiyisi().ToString();
            lbl_KiradaKitapSayisi.Text = bll.getKiradaOlanKitapSaiyisi().ToString();
        }
        private void cbbox_KayitAraKitapTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbox_KayitAraKitapTurleri.SelectedIndex == 0)
            {
                mtxt_KayitAraKitapTurleri.Clear();
                lbl_kayitAraInfo.Text = "Kitap Tür Kodu";
                mtxt_KayitAraKitapTurleri.Mask = "KTK-00";
            }
            else
            {
                mtxt_KayitAraKitapTurleri.Clear();
                lbl_kayitAraInfo.Text = "Kitap Tür Adı";
                mtxt_KayitAraKitapTurleri.Mask = "";
            }
        }
        private void cbbox_KayitAraYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_KayitAraYazarlar.SelectedIndex == 0)
            {
                mtxt_KayitAraYazarlar.Clear();
                lbl_KayitAraYazarlar.Text = "Yazar Kodu";
                mtxt_KayitAraYazarlar.Mask = "YK-00000";
            }
            else if (cbbox_KayitAraYazarlar.SelectedIndex == 1)
            {
                mtxt_KayitAraYazarlar.Clear();
                lbl_KayitAraYazarlar.Text = "Yazar Adı";
                mtxt_KayitAraYazarlar.Mask = "";
            }
            else
            {
                mtxt_KayitAraYazarlar.Clear();
                lbl_KayitAraYazarlar.Text = "Yazar Soyadı";
                mtxt_KayitAraYazarlar.Mask = "";
            }
        }
        private void cbbox_KayitAraYayinEvleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_KayitAraYayinEvleri.SelectedIndex == 0)
            {
                mtxt_KayitAraYayinEvleri.Clear();
                lbl_KayitAraYayinEvleri.Text = "Firma Kodu";
                mtxt_KayitAraYayinEvleri.Mask = "YEFK-0000";
            }
            else if (cbbox_KayitAraYayinEvleri.SelectedIndex == 1)
            {
                mtxt_KayitAraYayinEvleri.Clear();
                lbl_KayitAraYayinEvleri.Text = "Firma Adı";
                mtxt_KayitAraYayinEvleri.Mask = "";
            }
            else if (cbbox_KayitAraYayinEvleri.SelectedIndex == 2)
            {
                mtxt_KayitAraYayinEvleri.Clear();
                lbl_KayitAraYayinEvleri.Text = "Firma Tel";
                mtxt_KayitAraYayinEvleri.Mask = "(999) 000-0000";
            }
            else
            {
                mtxt_KayitAraYayinEvleri.Clear();
                lbl_KayitAraYayinEvleri.Text = "Firma Fax";
                mtxt_KayitAraYayinEvleri.Mask = "(999) 000-0000";
            }

        }
        private void cbbox_KayitAraKitaplar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbox_KayitAraKitaplar.SelectedIndex == 0)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Kitap Kodu";
                mtxt_KayitAraKitaplar.Mask = "";
                btn_findkodKitaplar.Visible = true;
                bindAranacakDeger("KitapKodu");

            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 1)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Kitap ISBN";
                mtxt_KayitAraKitaplar.Mask = "0000000000000";
                btn_findkodKitaplar.Visible = false;
            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 2)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Kitap Adı";
                mtxt_KayitAraKitaplar.Mask = "";
                btn_findkodKitaplar.Visible = false;
            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 3)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Kitap Tür Kodu";
                mtxt_KayitAraKitaplar.Mask = "KTK-00";
                btn_findkodKitaplar.Visible = true;
                bindAranacakDeger("KitapTurKodu");
            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 4)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Yazar Kodu";
                mtxt_KayitAraKitaplar.Mask = "YK-00000";
                btn_findkodKitaplar.Visible = true;
                bindAranacakDeger("YazarKodu");
            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 5)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Yayın Evi Firma Kodu";
                mtxt_KayitAraKitaplar.Mask = "YEFK-0000";
                btn_findkodKitaplar.Visible = true;
                bindAranacakDeger("YayinEviFirmaKodu");
            }
            else
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Kitap Dil Kodu";
                mtxt_KayitAraKitaplar.Mask = "0";
                btn_findkodKitaplar.Visible = true;
                bindAranacakDeger("DilKodu");

            }
        }
        private void cbbox_KayitAraUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_KayitAraUyeler.SelectedIndex == 0)
            {
                mtxt_KayitAraUyeler.Clear();
                lbl_KayitAraUyeler.Text = "Üye Kodu";
                mtxt_KayitAraUyeler.Mask = "UK-00000";
            }
            else if (cbbox_KayitAraUyeler.SelectedIndex == 1)
            {
                mtxt_KayitAraUyeler.Clear();
                lbl_KayitAraUyeler.Text = "Üye Adı";
                mtxt_KayitAraUyeler.Mask = "";
            }
            else if (cbbox_KayitAraUyeler.SelectedIndex == 2)
            {
                mtxt_KayitAraUyeler.Clear();
                lbl_KayitAraUyeler.Text = "Üye Soyadı";
                mtxt_KayitAraUyeler.Mask = "";
            }
            else
            {
                mtxt_KayitAraUyeler.Clear();
                lbl_KayitAraUyeler.Text = "Üye Tel";
                mtxt_KayitAraUyeler.Mask = "(999) 000-0000";
            }
        }

        private void cbbox_KayitAraKiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_KayitAraKitapKiralama.SelectedIndex == 0)
            {
                mtxt_KayitAraKitapKiralama.Clear();
                lbl_KayitAraKiralama.Text = "Kiralama Kodu";
                mtxt_KayitAraKitapKiralama.Mask = "KK-0000000";
                btn_findkodKitapKiralama.Visible = false;
            }
            else if (cbbox_KayitAraKitapKiralama.SelectedIndex == 1)
            {
                mtxt_KayitAraKitapKiralama.Clear();
                lbl_KayitAraKiralama.Text = "Kitap Kodu";
                mtxt_KayitAraKitapKiralama.Mask = "";
                btn_findkodKitapKiralama.Visible = true;
                bindAranacakDeger("KitapKodu");
            }
            else
            {
                mtxt_KayitAraKitapKiralama.Clear();
                lbl_KayitAraKiralama.Text = "Üye Kodu";
                mtxt_KayitAraKitapKiralama.Mask = "UK-00000";
                btn_findkodKitapKiralama.Visible = true;
                bindAranacakDeger("KitapKodu");
            }
        }
        private void tab_MainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab_MainControl.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    if (!BindKitapTUrleri())
                        MessageBox.Show("Kitap Tür Bilgileri Yüklenemedi. Lütden Sistem Yöneticinize Başvurunuz.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    if (!BindYazarlar())
                        MessageBox.Show("Yazar Bilgileri Yüklenemedi. Lütden Sistem Yöneticinize Başvurunuz.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    if (!BindYayinEvleri())
                        MessageBox.Show("Yayin Evleri Bilgileri Yüklenemedi. Lütden Sistem Yöneticinize Başvurunuz.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    if (!BindKitaplar())
                        MessageBox.Show("Kitap Bilgileri Yüklenemedi. Lütden Sistem Yöneticinize Başvurunuz.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    if (!BindUyeler())
                        MessageBox.Show("Üye Bilgileri Yüklenemedi. Lütden Sistem Yöneticinize Başvurunuz.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    if (!BindKiralamaBilgileri())
                        MessageBox.Show("Kitap Bilgileri Yüklenemedi. Lütden Sistem Yöneticinize Başvurunuz.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    break;
            }
        }
        private bool BindKiralamaBilgileri()
        {
            try
            {
                DataTable[] dt = bll.getAllKitapKiralama();
                dataGridView_KiralanabilirOlanlar.DataSource = null;
                dataGridView_KiradaKitaplar.DataSource = null;
                dataGridView_KitapKiralama.DataSource = null;
                dataGridView_KiralanabilirOlanlar.DataSource = dt[1];
                dataGridView_KiradaKitaplar.DataSource = dt[0];
                dataGridView_KitapKiralama.DataSource = dt[2];
                yeniKayitKiralama();
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindKiralamaBilgileri(DataTable gdt)
        {
            try
            {
                DataTable[] dt = bll.getAllKitapKiralama();
                dataGridView_KiralanabilirOlanlar.DataSource = null;
                dataGridView_KiradaKitaplar.DataSource = null;
                dataGridView_KitapKiralama.DataSource = null;
                dataGridView_KiralanabilirOlanlar.DataSource = dt[1];
                dataGridView_KiradaKitaplar.DataSource = dt[0];
                dataGridView_KitapKiralama.DataSource = gdt;
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindUyeler()
        {
            try
            {
                DataTable dt = bll.getAllUyeler();
                dataGridView_Uyeler.DataSource = null;
                dataGridView_Uyeler.DataSource = dt;
                yeniKayitUyeler();
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindUyeler(DataTable dt)
        {
            try
            {
                dataGridView_Uyeler.DataSource = null;
                dataGridView_Uyeler.DataSource = dt;
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindKitaplar()
        {
            try
            {
                DataTable dt = bll.getAllKitaplarKitapFiyatlari();
                dataGridView_Kitaplar.DataSource = null;
                dataGridView_Kitaplar.DataSource = dt;
                yeniKayitKitaplar();
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindKitaplar(DataTable dt)
        {
            try
            {
                dataGridView_Kitaplar.DataSource = null;
                dataGridView_Kitaplar.DataSource = dt;
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindYayinEvleri()
        {
            try
            {
                DataTable dt = bll.getAllYayinEvleri();
                dataGridView_YayinEvleri.DataSource = null;
                dataGridView_YayinEvleri.DataSource = dt;
                yeniKayitYayinEvleri();
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindYayinEvleri(DataTable dt)
        {
            try
            {
                dataGridView_YayinEvleri.DataSource = null;
                dataGridView_YayinEvleri.DataSource = dt;
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindYazarlar()
        {
            try
            {
                DataTable dt = bll.getAllYazarlar();
                listView_Yazarlar.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[1].ToString());
                    for (int i = 2; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView_Yazarlar.Items.Add(item);
                }
                yeniKayitYazarKodu();
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindYazarlar(DataTable dt)
        {
            try
            {
                listView_Yazarlar.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[1].ToString());
                    for (int i = 2; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView_Yazarlar.Items.Add(item);
                }
                return true;
            }
            catch (Exception) { return false; }
        }
        private bool BindKitapTUrleri()
        {

            try
            {
                DataTable dt = bll.getAllKitapTuleri();
                listView_KitapTurleri.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[1].ToString());
                    for (int i = 2; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView_KitapTurleri.Items.Add(item);
                }
                yeniKayitKitapTuru();
                return true;
            }
            catch (Exception) { return false; }

        }
        private bool BindKitapTUrleri(DataTable dt)
        {

            try
            {

                listView_KitapTurleri.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[1].ToString());
                    for (int i = 2; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView_KitapTurleri.Items.Add(item);
                }
                return true;
            }
            catch (Exception) { return false; }

        }

        private void timer_datetime_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString();
            lbl_time.Text = DateTime.Now.ToShortTimeString();
        }
        // Kayıt Seçme İşlemleri
        private void dataGridView_KitapKiralama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mtxt_KiralamaKoduKitapKiralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[1].Value.ToString().Substring(3, 7);
                txt_KitapKoduKitapKiralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[2].Value.ToString();
                dtpicker_KiralamaBasTarihiKitapKiralama.Value = DateTime.Parse(dataGridView_KitapKiralama.CurrentRow.Cells[4].Value.ToString());
                dtpicker_KiralamaBitisTarihiKitapKiralama.Value = DateTime.Parse(dataGridView_KitapKiralama.CurrentRow.Cells[5].Value.ToString());
                dtpicker_KitabıTeslimTarihiKitapKiralama.Value = DateTime.Parse(dataGridView_KitapKiralama.CurrentRow.Cells[6].Value.ToString());
                mtxt_KiralamaUyeKoduKitapKiralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[7].Value.ToString().Substring(3, 5);
                txt_KiralamaFiyatiKitapKiralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[9].Value.ToString() + " TL";
                checkBox_KiralamaBitisDurumuKitapKiralama.Checked = Convert.ToBoolean(dataGridView_KitapKiralama.CurrentRow.Cells[11].Value.ToString());
                txt_KiralamaNotuKitapKİralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[10].Value.ToString();
                btn_KayitGuncellemeKitapKiralama.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void listView_KitapTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection selected = listView_KitapTurleri.SelectedItems;
                foreach (ListViewItem item in selected)
                {
                    mtxt_kturkoduKitapTurleri.Text = item.SubItems[0].Text;
                    txt_turAdiKitapTurleri.Text = item.SubItems[1].Text;
                    btn_KayitGuncelleKitapTurleri.Enabled = true;
                }

            }
            catch (Exception) { MessageBox.Show("Değerler Okunamadı"); }
        }
        private void listView_Yazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection selected = listView_Yazarlar.SelectedItems;
                foreach (ListViewItem item in selected)
                {
                    mtxt_YazarKoduYazarlar.Text = item.SubItems[0].Text;
                    txt_YazarAdiYazarlar.Text = item.SubItems[1].Text;
                    txt_YazarSoyadiYazarlar.Text = item.SubItems[2].Text;

                }
                btn_YKayitGuncelle.Enabled = true;
            }
            catch (Exception) { MessageBox.Show("Değerler Okunamadı"); }
        }
        private void dataGridView_YayinEvleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mtxt_FirmaKoduYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[1].Value.ToString();
                txt_FirmaAdiYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[2].Value.ToString();
                mtxt_FirmaTelIYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[3].Value.ToString();
                mtxt_FirmaTelIIYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[4].Value.ToString();
                mtxt_FirmaFaxYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[5].Value.ToString();
                txt_FirmaEmailYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[6].Value.ToString();
                txt_FirmaWebAdresiYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[7].Value.ToString();
                txt_FirmaAdresiYayinEvleri.Text = dataGridView_YayinEvleri.CurrentRow.Cells[8].Value.ToString();
                btn_KayitGuncelleYayinEvleri.Enabled = true;
            }
            catch (Exception) { MessageBox.Show("Değerler Okunamadı"); }
        }
        private void dataGridView_Uyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mtxt_UyeKoduUyeler.Text = dataGridView_Uyeler.CurrentRow.Cells[1].Value.ToString();
                txt_UyeAdiUyeler.Text = dataGridView_Uyeler.CurrentRow.Cells[2].Value.ToString();
                txt_UyeSoyadiUyeler.Text = dataGridView_Uyeler.CurrentRow.Cells[3].Value.ToString();
                dtpicker_UyeDogTarihiUyeler.Value = DateTime.Parse(dataGridView_Uyeler.CurrentRow.Cells[4].Value.ToString());
                mtxt_UyeTelUyeler.Text = dataGridView_Uyeler.CurrentRow.Cells[5].Value.ToString();
                txt_UyeEmailUyeler.Text = dataGridView_Uyeler.CurrentRow.Cells[6].Value.ToString();
                txt_UyeAdresUyeler.Text = dataGridView_Uyeler.CurrentRow.Cells[7].Value.ToString();
                btn_KayitGuncelleUyeler.Enabled = true;
            }
            catch (Exception) { MessageBox.Show("Değerler Okunamadı"); }
        }
        private void dataGridView_Kitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mtxt_kitapKoduKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[1].Value.ToString();
                txt_kitapISBNKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[2].Value.ToString();
                txt_kitapAdiKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[3].Value.ToString();
                mtxt_kitapTurKoduKitaplar.Text = (dataGridView_Kitaplar.CurrentRow.Cells[4].Value.ToString());
                mtxt_kitapYazarKoduKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[5].Value.ToString();
                txt_KitapSayfaSayisiKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[6].Value.ToString();
                mtxt_kitapYayinEviFirmaKoduKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[7].Value.ToString();
                dtpicker_KitaplarBasimTarihi.Value = DateTime.Parse(dataGridView_Kitaplar.CurrentRow.Cells[8].Value.ToString());
                mtxt_KitapDilKoduKitaplar.Text = dataGridView_Kitaplar.CurrentRow.Cells[9].Value.ToString();
                txt_KitapFiyatiKitapFiyalari.Text = dataGridView_Kitaplar.CurrentRow.Cells[10].Value.ToString();
                txt_KitapGunlukKiralamaFiyatiKitapFiyalari.Text = dataGridView_Kitaplar.CurrentRow.Cells[11].Value.ToString();
                btn_KayitGuncelleKitaplar_KitapFiyatlari.Enabled = true;
            }
            catch (Exception) { MessageBox.Show("Değerler Okunamadı"); }
        }
        // Kayıt Seçme İşlemleri

        //Kitap Türleri Kayıt Bul ve Silme İşlemleri
        private void btn_KayitAraKitapTurleri_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraKitapTurleri.SelectedIndex)
            {
                case 0:
                    if (!findKitapTurleriAtKitapTurKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!findKitapTurleriAtKitapTurAdi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                default:
                    break;
            }
        }
        private void btn_KayitSilKitapTurleri_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraKitapTurleri.SelectedIndex)
            {
                case 0:
                    if (!deleteKitapTurleriAtKitapTurKodu())
                        MessageBox.Show("Silinecek Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!deleteKitapTurleriAtKitapTurAdi())
                        MessageBox.Show("Silinecek Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                default:
                    break;
            }
        }
        private bool findKitapTurleriAtKitapTurAdi()
        {
            try
            {
                DataTable dt = bll.getKitapTurleriAtKitapTurAdi(mtxt_KayitAraKitapTurleri.Text);
                BindKitapTUrleri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitapTurleriAtKitapTurKodu()
        {
            try
            {
                DataTable dt = bll.getKitapTurleriAtKitapTurKodu(mtxt_KayitAraKitapTurleri.Text);
                BindKitapTUrleri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteKitapTurleriAtKitapTurAdi()
        {
            try
            {
                int adet = bll.deleteKitapTurleriAtKitapTurAdi(txt_turAdiKitapTurleri.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindKitapTUrleri();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteKitapTurleriAtKitapTurKodu()
        {
            try
            {
                int adet = bll.deleteKitapTurleriAtKitapTurKodu(mtxt_kturkoduKitapTurleri.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindKitapTUrleri();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Kitap Türleri Kayıt Bul ve Silme İşlemleri

        //Yazarlar Evleri Kayıt Bul ve Silme İşlemleri
        private void btn_YKayitBul_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraYazarlar.SelectedIndex)
            {
                case 0:
                    if (!findYazarlarAtYazarKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!findYazarlarAtYazarAdi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 2:
                    if (!findYazarlarAtYazarSoyadi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                default:
                    break;
            }
        }
        private void btn_YKayitSil_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraYazarlar.SelectedIndex)
            {
                case 0:
                    if (!deleteYazarlarAtYazarKodu())
                        MessageBox.Show("Silinecek Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!deleteYazarlarAtYazarAdi())
                        MessageBox.Show("Silinecek Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 2:
                    if (!deleteYazarlarAtYazarSoyadi())
                        MessageBox.Show("Silinecek Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                default:
                    break;
            }
        }
        private bool findYazarlarAtYazarSoyadi()
        {
            try
            {
                DataTable dt = bll.getYazarlarAtYazarSoyadi(mtxt_KayitAraYazarlar.Text);
                BindYazarlar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findYazarlarAtYazarAdi()
        {
            try
            {
                DataTable dt = bll.getYazarlarAtYazarAdi(mtxt_KayitAraYazarlar.Text);
                BindYazarlar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findYazarlarAtYazarKodu()
        {
            try
            {
                DataTable dt = bll.getYazarlarAtYazarKodu(mtxt_KayitAraYazarlar.Text);
                BindYazarlar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteYazarlarAtYazarSoyadi()
        {
            try
            {
                int adet = bll.deleteYazarlarAtYazarKodu(mtxt_YazarKoduYazarlar.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindYazarlar();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteYazarlarAtYazarAdi()
        {
            try
            {
                int adet = bll.deleteYazarlarAtYazarKodu(mtxt_YazarKoduYazarlar.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindYazarlar();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteYazarlarAtYazarKodu()
        {
            try
            {
                int adet = bll.deleteYazarlarAtYazarKodu(mtxt_YazarKoduYazarlar.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindYazarlar();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Yazarlar Evleri Kayıt Bul ve Silme İşlemleri

        //Yayın Evleri Kayıt Bul ve Silme İşlemleri
        private void btn_KayitAraYayinEvleri_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraYayinEvleri.SelectedIndex)
            {
                case 0:
                    if (!findYayinEvleriAtFirmaKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!findYayinEvleriAtFirmaAdi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 2:
                    if (!findYayinEvleriAtFirmaTel())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 3:
                    if (!findYayinEvleriAtFirmaFax())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                default:
                    break;
            }
        }
        private void btn_KayitSilYayinEvleri_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraYayinEvleri.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    if (!deleteYayinEvleriAtFirmaKodu())
                        MessageBox.Show("Yayin Evi Silinemedi. Yayin Evine Ait Kitaplar Bulunmaktadir.");
                    break;
                default:
                    break;
            }
        }
        private bool findYayinEvleriAtFirmaFax()
        {
            try
            {
                DataTable dt = bll.getYayinEvleriAtFirmaFax(mtxt_KayitAraYayinEvleri.Text);
                BindYayinEvleri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findYayinEvleriAtFirmaTel()
        {
            try
            {
                DataTable dt = bll.getYayinEvleriAtFirmaTel(mtxt_KayitAraYayinEvleri.Text);
                BindYayinEvleri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findYayinEvleriAtFirmaAdi()
        {
            try
            {
                DataTable dt = bll.getYayinEvleriAtFirmaAdi(mtxt_KayitAraYayinEvleri.Text);
                BindYayinEvleri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findYayinEvleriAtFirmaKodu()
        {
            try
            {
                DataTable dt = bll.getYayinEvleriAtFirmaKodu(mtxt_KayitAraYayinEvleri.Text);
                BindYayinEvleri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteYayinEvleriAtFirmaKodu()
        {
            try
            {
                int adet = bll.deleteYayinEvleriAtFirmaKodu(mtxt_FirmaKoduYayinEvleri.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindYayinEvleri();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Yayın Evleri Kayıt Bul ve Silme İşlemleri

        //Kitaplar Kayıt Bul ve Silme İşlemleri
        private void btn_KayitBulKitaplar_KitapFiyatlari_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraKitaplar.SelectedIndex)
            {
                case 0:
                    if (!findKitaplarAtKitapKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!findKitaplarAtKitapISBN())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 2:
                    if (!findKitaplarAtKitapAdi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 3:
                    if (!findKitaplarAtKitapTurKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 4:
                    if (!findKitaplarAtKitapYazarKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 5:
                    if (!findKitaplarAtKitapYayinEviFirmaKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 6:
                    if (!findKitaplarAtKitaDilKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
            }
        }
        private void btn_KayitSilKitaplar_KitapFiyatlari_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraKitaplar.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    if (!deleteKitaplarAtKitapKodu())
                        MessageBox.Show("Silinecek Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
            }
        }
        private bool findKitaplarAtKitapKodu()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitapKodu(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitaplarAtKitapISBN()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitapISBN(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitaplarAtKitapAdi()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitapAdi(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitaplarAtKitapTurKodu()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitapTurKodu(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitaplarAtKitapYazarKodu()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitapYazarKodu(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitaplarAtKitapYayinEviFirmaKodu()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitapYayinEviFirmaKodu(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKitaplarAtKitaDilKodu()
        {
            try
            {
                DataTable dt = bll.getKitaplarAtKitaDilKodu(mtxt_KayitAraKitaplar.Text);
                BindKitaplar(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteKitaplarAtKitapKodu()
        {
            try
            {
                int adet = bll.deleteKitaplarAtKitapKodu(mtxt_kitapKoduKitaplar.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindKitaplar();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Kitaplar Kayıt Bul ve Silme İşlemleri

        //Uyeler Kayıt Bul ve Silme İşlemleri
        private void btn_KayitAraUyeler_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraUyeler.SelectedIndex)
            {
                case 0:
                    if (!findUyelerAtUyeKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!findUyelerAtUyeAdi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 2:
                    if (!findUyelerAtUyeSoyadi())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 3:
                    if (!findUyelerAtUyeTel())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
            }
        }
        private void btnKayitSilUyeler_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraUyeler.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    if (!deleteUyelerAtUyeKodu())
                        MessageBox.Show("Silinece Değer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
            }
        }
        private bool findUyelerAtUyeKodu()
        {
            try
            {
                DataTable dt = bll.getUyelerAtUyeKodu(mtxt_KayitAraUyeler.Text);
                BindUyeler(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findUyelerAtUyeAdi()
        {
            try
            {
                DataTable dt = bll.getUyelerAtUyeAdi(mtxt_KayitAraUyeler.Text);
                BindUyeler(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findUyelerAtUyeSoyadi()
        {
            try
            {
                DataTable dt = bll.getUyelerAtUyeSoyadi(mtxt_KayitAraUyeler.Text);
                BindUyeler(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findUyelerAtUyeTel()
        {
            try
            {
                DataTable dt = bll.getUyelerAtUyeTel(mtxt_KayitAraUyeler.Text);
                BindUyeler(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteUyelerAtUyeKodu()
        {
            try
            {
                int adet = bll.deleteUyelerAtUyeKodu(mtxt_UyeKoduUyeler.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindUyeler();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Uyeler Kayıt Bul ve Silme İşlemleri

        //Kiralama Kayıt Bul ve Silme İşlemleri
        private void btn_KayitBulKitapKiralama_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraKitapKiralama.SelectedIndex)
            {
                case 0:
                    if (!findKiralamaAtKiralamaKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 1:
                    if (!findKiralamaAtKitapKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
                case 2:
                    if (!findKiralamaAtUyeKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
            }
        }
        private void btn_silKitapKiralama_Click(object sender, EventArgs e)
        {
            switch (cbbox_KayitAraKitapKiralama.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                    if (!deleteKiralamaAtKiralamaKodu())
                        MessageBox.Show("ArananDeğer Bulunamadı Lütfen Kodu Doğru Girdiğinizden Emin Olunuz");
                    break;
            }
        }
        private bool findKiralamaAtKiralamaKodu()
        {
            try
            {
                DataTable dt = bll.getKiralamaAtKiralamaKodu(mtxt_KayitAraKitapKiralama.Text);
                BindKiralamaBilgileri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKiralamaAtKitapKodu()
        {
            try
            {
                DataTable dt = bll.getKiralamaAtKitapKodu(mtxt_KayitAraKitapKiralama.Text);
                BindKiralamaBilgileri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool findKiralamaAtUyeKodu()
        {
            try
            {
                DataTable dt = bll.getKiralamaAtUyeKodu(mtxt_KayitAraKitapKiralama.Text);
                BindKiralamaBilgileri(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool deleteKiralamaAtKiralamaKodu()
        {
            try
            {
                int adet = bll.deleteKiralamaAtKiralamaKodu(mtxt_KiralamaKoduKitapKiralama.Text);
                if (adet == -1)
                {
                    return false;
                }
                else
                {
                    BindKiralamaBilgileri();
                    BindKitapKisaBilgiler();
                    MessageBox.Show(adet + " Adet Kayıt Silindi.");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Kiralama Kayıt Bul ve Silme İşlemleri

        //Kitap Türü Ekleme ve Güncelleme İşlemleri
        private void btn_YeniKayitKitapTurleri_Click(object sender, EventArgs e)
        {
            yeniKayitKitapTuru();
        }
        private void yeniKayitKitapTuru()
        {
            if (bll.getNewEntryKitapTurKodu() != "err")
            {
                mtxt_kturkoduKitapTurleri.Text = bll.getNewEntryKitapTurKodu();
                txt_turAdiKitapTurleri.Clear();
                btn_KayitGuncelleKitapTurleri.Enabled = false;
            }
            else MessageBox.Show("Tür Kodu Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_KayitGuncelleKitapTurleri_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.updateKitapTurleriAtKitapKodu(mtxt_kturkoduKitapTurleri.Text, txt_turAdiKitapTurleri.Text);
                if (updateSayisi != -1)
                {
                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindKitapTUrleri();
                }
                else MessageBox.Show("Kayıt Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_KayitEkleKitapTurleri_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.insertKitapTur(mtxt_kturkoduKitapTurleri.Text, txt_turAdiKitapTurleri.Text);
                if (updateSayisi != -1)
                {
                    MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindKitapTUrleri();
                }
                else MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Kitap Türü Ekleme ve Güncelleme İşlemleri

        //Yazarlar Kayıt Ekleme ve Güncelleme İşlemleri
        private void btn_YYeniKayıt_Click(object sender, EventArgs e)
        {
            yeniKayitYazarKodu();
        }
        private void yeniKayitYazarKodu()
        {
            if (bll.getNewEntryYazarKodu() != "err")
            {
                mtxt_YazarKoduYazarlar.Text = bll.getNewEntryYazarKodu();
                txt_YazarAdiYazarlar.Clear();
                txt_YazarSoyadiYazarlar.Clear();
                btn_YKayitGuncelle.Enabled = false;
            }
            else MessageBox.Show("Tür Kodu Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_YKayitGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.updateYazarlarAtYazarKodu(mtxt_YazarKoduYazarlar.Text, txt_YazarAdiYazarlar.Text, txt_YazarSoyadiYazarlar.Text);
                if (updateSayisi != -1)
                {
                    BindYazarlar();
                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_YKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int insertSayisi = bll.insertYazar(mtxt_YazarKoduYazarlar.Text, txt_YazarAdiYazarlar.Text, txt_YazarSoyadiYazarlar.Text);
                if (insertSayisi != -1)
                {
                    BindYazarlar();
                    MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Yazarlar Kayıt Ekleme ve Güncelleme İşlemleri

        //Yayın Evleri Kayıt Ekleme ve Güncelleme İşlemler
        private void btn_YeniKayitYayinEvleri_Click(object sender, EventArgs e)
        {
            yeniKayitYayinEvleri();
        }
        private void yeniKayitYayinEvleri()
        {
            if (bll.getNewEntryYayinEvleriFirmaKodu() != "err")
            {

                mtxt_FirmaKoduYayinEvleri.Text = bll.getNewEntryYayinEvleriFirmaKodu();
                txt_FirmaAdiYayinEvleri.Clear();
                mtxt_FirmaTelIYayinEvleri.Clear();
                mtxt_FirmaTelIIYayinEvleri.Clear();
                mtxt_FirmaFaxYayinEvleri.Clear();
                txt_FirmaEmailYayinEvleri.Clear();
                txt_FirmaWebAdresiYayinEvleri.Clear();
                txt_FirmaAdresiYayinEvleri.Clear();
                btn_KayitGuncelleYayinEvleri.Enabled = false;
            }
            else MessageBox.Show("Tür Kodu Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_KayitGuncelleYayinEvleri_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.updateYayinEvleriAtFirmaKodu(
                     mtxt_FirmaKoduYayinEvleri.Text,
                     txt_FirmaAdiYayinEvleri.Text,
                     mtxt_FirmaTelIYayinEvleri.Text,
                     mtxt_FirmaTelIIYayinEvleri.Text,
                     mtxt_FirmaFaxYayinEvleri.Text,
                     txt_FirmaEmailYayinEvleri.Text,
                     txt_FirmaWebAdresiYayinEvleri.Text,
                     txt_FirmaAdresiYayinEvleri.Text
                    );
                if (updateSayisi != -1)
                {
                    BindYayinEvleri();
                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_KayitEkleYayinEvleri_Click(object sender, EventArgs e)
        {
            try
            {
                int insertSayisi = bll.insertYayinEvi(
                     mtxt_FirmaKoduYayinEvleri.Text,
                     txt_FirmaAdiYayinEvleri.Text,
                     mtxt_FirmaTelIYayinEvleri.Text,
                     mtxt_FirmaTelIIYayinEvleri.Text,
                     mtxt_FirmaFaxYayinEvleri.Text,
                     txt_FirmaEmailYayinEvleri.Text,
                     txt_FirmaWebAdresiYayinEvleri.Text,
                     txt_FirmaAdresiYayinEvleri.Text
                    );
                if (insertSayisi != -1)
                {
                    BindYayinEvleri();
                    MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Yayın Evleri Kayıt Ekleme ve Güncelleme İşlemler

        //Kitaplar Kayıt Ekleme ve Güncelleme İşlemler
        private void btn_YeniKayitKitaplar_KitapFiyatlari_Click(object sender, EventArgs e)
        {
            yeniKayitKitaplar();
        }
        private void yeniKayitKitaplar()
        {
            if (bll.getNewEntryKitaplarAtKitapKodu() != "err")
            {

                mtxt_kitapKoduKitaplar.Text = bll.getNewEntryKitaplarAtKitapKodu();
                txt_kitapISBNKitaplar.Clear();
                txt_kitapAdiKitaplar.Clear();
                mtxt_kitapTurKoduKitaplar.Clear();
                mtxt_kitapYazarKoduKitaplar.Clear();
                txt_KitapSayfaSayisiKitaplar.Clear();
                mtxt_kitapYayinEviFirmaKoduKitaplar.Clear();
                dtpicker_KitaplarBasimTarihi.Value = DateTime.Now;
                mtxt_KitapDilKoduKitaplar.Clear();
                txt_KitapFiyatiKitapFiyalari.Clear();
                txt_KitapGunlukKiralamaFiyatiKitapFiyalari.Clear();
                btn_KayitGuncelleKitaplar_KitapFiyatlari.Enabled = false;
            }
            else MessageBox.Show("Tür Kodu Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_KayitGuncelleKitaplar_KitapFiyatlari_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.updateKitaplarAtKitapKodu(
                     mtxt_kitapKoduKitaplar.Text,
                     txt_kitapISBNKitaplar.Text,
                     txt_kitapAdiKitaplar.Text,
                     mtxt_kitapTurKoduKitaplar.Text,
                     mtxt_kitapYazarKoduKitaplar.Text,
                     txt_KitapSayfaSayisiKitaplar.Text,
                     mtxt_kitapYayinEviFirmaKoduKitaplar.Text,
                     dtpicker_KitaplarBasimTarihi.Value,
                     mtxt_KitapDilKoduKitaplar.Text,
                     txt_KitapFiyatiKitapFiyalari.Text,
                     txt_KitapGunlukKiralamaFiyatiKitapFiyalari.Text
                    );
                if (updateSayisi != -1)
                {
                    BindKitaplar();
                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_KayitEkleKitaplar_KitapFiyatlari_Click(object sender, EventArgs e)
        {
            try
            {
                int insertSayisi = bll.insertKitap(
                     mtxt_kitapKoduKitaplar.Text,
                     txt_kitapISBNKitaplar.Text,
                     txt_kitapAdiKitaplar.Text,
                     mtxt_kitapTurKoduKitaplar.Text,
                     mtxt_kitapYazarKoduKitaplar.Text,
                     txt_KitapSayfaSayisiKitaplar.Text,
                     mtxt_kitapYayinEviFirmaKoduKitaplar.Text,
                     dtpicker_KitaplarBasimTarihi.Value,
                     mtxt_KitapDilKoduKitaplar.Text,
                     txt_KitapFiyatiKitapFiyalari.Text,
                     txt_KitapGunlukKiralamaFiyatiKitapFiyalari.Text
                    );
                if (insertSayisi != -1)
                {
                    BindKitaplar();
                    MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Kitaplar Kayıt Ekleme ve Güncelleme İşlemler

        //Uyeler Kayıt Ekleme ve Güncelleme İşlemler
        private void btn_YeniKayitUyeler_Click(object sender, EventArgs e)
        {
            yeniKayitUyeler();
        }
        private void yeniKayitUyeler()
        {
            if (bll.getNewEntryUyelerAtUyeKodu() != "err")
            {

                mtxt_UyeKoduUyeler.Text = bll.getNewEntryUyelerAtUyeKodu();
                txt_UyeAdiUyeler.Clear();
                txt_kitapAdiKitaplar.Clear();
                txt_UyeSoyadiUyeler.Clear();
                dtpicker_UyeDogTarihiUyeler.Value = DateTime.Now;
                mtxt_UyeTelUyeler.Clear();
                txt_UyeEmailUyeler.Clear();
                txt_UyeAdresUyeler.Clear();
                btn_KayitGuncelleUyeler.Enabled = false;
            }
            else MessageBox.Show("Kod Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_KayitGuncelleUyeler_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.updateUyelerAtUyeKodu(
                     mtxt_UyeKoduUyeler.Text,
                     txt_UyeAdiUyeler.Text,
                     txt_UyeSoyadiUyeler.Text,
                     dtpicker_UyeDogTarihiUyeler.Value,
                     mtxt_UyeTelUyeler.Text,
                     txt_UyeEmailUyeler.Text,
                     txt_UyeAdresUyeler.Text
                    );
                if (updateSayisi != -1)
                {
                    BindUyeler();
                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_KayitEkleUyeler_Click(object sender, EventArgs e)
        {
            try
            {
                int insertSayisi = bll.insertUye(
                    mtxt_UyeKoduUyeler.Text,
                    txt_UyeAdiUyeler.Text,
                    txt_UyeSoyadiUyeler.Text,
                    dtpicker_UyeDogTarihiUyeler.Value,
                    mtxt_UyeTelUyeler.Text,
                    txt_UyeEmailUyeler.Text,
                    txt_UyeAdresUyeler.Text
                   );
                if (insertSayisi != -1)
                {
                    BindUyeler();
                    MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Uyeler Kayıt Ekleme ve Güncelleme İşlemler

        //Kiralama Kayıt Ekleme ve Güncelleme İşlemler
        private void btn_YeniKayitKitapKiralama_Click(object sender, EventArgs e)
        {
            yeniKayitKiralama();
        }
        private void yeniKayitKiralama()
        {
            if (bll.getNewEntryKiralamaAtKiralamaKodu() != "err")
            {
                mtxt_KiralamaKoduKitapKiralama.Text = bll.getNewEntryKiralamaAtKiralamaKodu();
                txt_KitapKoduKitapKiralama.Clear();
                dtpicker_KiralamaBasTarihiKitapKiralama.Value = DateTime.Now;
                dtpicker_KiralamaBitisTarihiKitapKiralama.Value = DateTime.Now;
                dtpicker_KitabıTeslimTarihiKitapKiralama.Value = DateTime.Now;
                mtxt_KiralamaUyeKoduKitapKiralama.Clear();
                txt_KiralamaFiyatiKitapKiralama.Clear();
                checkBox_KiralamaBitisDurumuKitapKiralama.Checked = false;
                txt_KiralamaNotuKitapKİralama.Clear();
                btn_KayitGuncellemeKitapKiralama.Enabled = false;
            }
            else MessageBox.Show("Kod Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_KayitGuncellemeKitapKiralama_Click(object sender, EventArgs e)
        {
            try
            {
                int updateSayisi = bll.updateKiralamaAtKiralamaKodu(
                     mtxt_KiralamaKoduKitapKiralama.Text,
                     txt_KitapKoduKitapKiralama.Text,
                     dtpicker_KiralamaBasTarihiKitapKiralama.Value,
                     dtpicker_KiralamaBitisTarihiKitapKiralama.Value,
                     dtpicker_KitabıTeslimTarihiKitapKiralama.Value,
                     mtxt_KiralamaUyeKoduKitapKiralama.Text,
                     txt_KiralamaFiyatiKitapKiralama.Text,
                     txt_KiralamaNotuKitapKİralama.Text,
                     checkBox_KiralamaBitisDurumuKitapKiralama.Checked == true ? true : false
                    );
                if (updateSayisi != -1)
                {
                    BindKiralamaBilgileri();
                    BindKitapKisaBilgiler();
                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_KayitEkleKitapKiralama_Click(object sender, EventArgs e)
        {
            try
            {
                int insertSayisi = bll.insertKiralama(
                    mtxt_KiralamaKoduKitapKiralama.Text,
                    txt_KitapKoduKitapKiralama.Text,
                    dtpicker_KiralamaBasTarihiKitapKiralama.Value,
                    dtpicker_KiralamaBitisTarihiKitapKiralama.Value,
                    dtpicker_KitabıTeslimTarihiKitapKiralama.Value,
                    mtxt_KiralamaUyeKoduKitapKiralama.Text,
                    txt_KiralamaFiyatiKitapKiralama.Text,
                    txt_KiralamaNotuKitapKİralama.Text,
                    checkBox_KiralamaBitisDurumuKitapKiralama.Checked == true ? true : false
                   );
                if (insertSayisi != -1)
                {
                    BindKiralamaBilgileri();
                    BindKitapKisaBilgiler();
                    MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Kiralama Kayıt Ekleme ve Güncelleme İşlemler

        //Form Kapatma İşlemi
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //Form Kapatma İşlemi

        //Kod Arama Button Eventleri
        private void btn_findkitapturkoduKitaplar_Click(object sender, EventArgs e)
        {
            bindAranacakDeger("KitapTurKodu");
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_kitapTurKoduKitaplar.Text = SecilenKodAdi;
            else MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SecilenKodAdi = null;

        }
        private void btn_findyazarkoduKitaplar_Click(object sender, EventArgs e)
        {
            bindAranacakDeger("YazarKodu");
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_kitapYazarKoduKitaplar.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(mtxt_kitapYazarKoduKitaplar.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void btn_findyayinevifirmakoduKitaplar_Click(object sender, EventArgs e)
        {
            bindAranacakDeger("YayinEviFirmaKodu");
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_kitapYayinEviFirmaKoduKitaplar.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(mtxt_kitapYayinEviFirmaKoduKitaplar.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void btn_findkitapdilkoduKitaplar_Click(object sender, EventArgs e)
        {
            bindAranacakDeger("DilKodu");
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_KitapDilKoduKitaplar.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(mtxt_KitapDilKoduKitaplar.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void btn_findkodKitaplar_Click(object sender, EventArgs e)//Kitaplar Kayıt Arama Bölümü KayıtBul Butonu 
        {
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_KayitAraKitaplar.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(mtxt_KayitAraKitaplar.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void btn_findkitapkoduKitapKiralama_Click(object sender, EventArgs e)
        {
            bindAranacakDeger("KitapKodu");
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                txt_KitapKoduKitapKiralama.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(txt_KitapKoduKitapKiralama.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void btn_findUkeKoduKitapKiralama_Click(object sender, EventArgs e)
        {
            bindAranacakDeger("UyeKodu");
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_KiralamaUyeKoduKitapKiralama.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(mtxt_KiralamaUyeKoduKitapKiralama.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void btn_findkodKitapKiralama_Click(object sender, EventArgs e)//Kitap Kiralama Kayıt Arama Bölümü KayıtBul Butonu 
        {
            showFindForm();
            if (!string.IsNullOrEmpty(SecilenKodAdi))
                mtxt_KayitAraKitapKiralama.Text = SecilenKodAdi;
            else
            {
                if (string.IsNullOrEmpty(mtxt_KayitAraKitapKiralama.Text))
                    MessageBox.Show("Kayıt Seçmediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SecilenKodAdi = null;
        }
        private void showFindForm()
        {
            FindCodeForm fCF = new FindCodeForm();
            fCF.ShowDialog();
        }
        private void bindAranacakDeger(string deger)
        {
            AranacakKodAdi = deger;
        }
        //Kod Arama Button Eventleri
    }
}
