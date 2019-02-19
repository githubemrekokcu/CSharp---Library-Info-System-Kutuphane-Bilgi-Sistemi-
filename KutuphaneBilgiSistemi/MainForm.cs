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
                btn_findkodKitaplar.Visible = false;
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
            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 4)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Yazar Kodu";
                mtxt_KayitAraKitaplar.Mask = "YK-00000";
                btn_findkodKitaplar.Visible = true;
            }
            else if (cbbox_KayitAraKitaplar.SelectedIndex == 5)
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Yayın Evi Firma Kodu";
                mtxt_KayitAraKitaplar.Mask = "YEFK-0000";
                btn_findkodKitaplar.Visible = true;
            }
            else
            {
                mtxt_KayitAraKitaplar.Clear();
                lbl_KayitAraKitaplar.Text = "Kitap Dil Kodu";
                mtxt_KayitAraKitaplar.Mask = "0";
                btn_findkodKitaplar.Visible = true;
            }
        }

        private void cbbox_KayitAraUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_KayitAraUyeler.SelectedIndex == 0)
            {
                mtxt_KayitAraUyeler.Clear();
                lbl_KayitAraUyeler.Text = "Firma Kodu";
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
            }
            else
            {
                mtxt_KayitAraKitapKiralama.Clear();
                lbl_KayitAraKiralama.Text = "Üye Kodu";
                mtxt_KayitAraKitapKiralama.Mask = "UK-00000";
                btn_findkodKitapKiralama.Visible = true;
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
                return true;
            }
            catch (Exception) { return false; }

        }

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
                txt_KiralamaFiyatiKitapKiralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[9].Value.ToString()+" TL";
                checkBox_KiralamaBitisDurumuKitapKiralama.Checked = Convert.ToBoolean(dataGridView_KitapKiralama.CurrentRow.Cells[11].Value.ToString());
                txt_KiralamaNotuKitapKİralama.Text = dataGridView_KitapKiralama.CurrentRow.Cells[10].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer_datetime_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString();
            lbl_time.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
