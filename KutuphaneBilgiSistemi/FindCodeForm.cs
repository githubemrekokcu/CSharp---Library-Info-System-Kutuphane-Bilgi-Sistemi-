using BusinessLogicLayer;
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
    public partial class FindCodeForm : Form
    {
        private string AranacakKodAdi;
        BLL bll;
        public FindCodeForm()
        {
            InitializeComponent();
            bll = new BLL();
        }

        private void FindCodeForm_Load(object sender, EventArgs e)
        {
            if (!FindDataGridview(MainForm.AranacakKodAdi))
            {
                MessageBox.Show("Tablo Yüklenemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        // Data Gridview ve cmbbox Doldurma İşlemleri
        private bool FindDataGridview(string aranacakKodAdi)
        {
            switch (aranacakKodAdi)
            {
                case "UyeKodu":
                    AranacakKodAdi = aranacakKodAdi;
                    BindGridView(bll.getAllUyeler());
                    BindCmbboxKayitAraKriter(new String[] { "Üye Kodu", "Üye Adı", "Üye Soyadı", "Üye Tel" });
                    return true;
                case "KitapKodu":
                    AranacakKodAdi = aranacakKodAdi;
                    BindGridView(bll.getAllKitaplarKitapFiyatlari());
                    BindCmbboxKayitAraKriter(new String[] { "Kitap Kodu", "Kitap ISBN", "Kitap Adı", "Kitap Tür Kodu",
                    "Yazar Kodu","Yayın Evi Firma Kodu","Kitap Dil Kodu"});
                    return true;
                case "KitapTurKodu":
                    AranacakKodAdi = aranacakKodAdi;
                    BindGridView(bll.getAllKitapTuleri());
                    BindCmbboxKayitAraKriter(new String[] { "Kitap Tür Kodu", "Kitap Tür Adı" });
                    return true;
                case "YazarKodu":
                    AranacakKodAdi = aranacakKodAdi;
                    BindGridView(bll.getAllYazarlar());
                    BindCmbboxKayitAraKriter(new String[] { "Yazar Kodu", "Yazar Adı", "Yazar Soyadı" });
                    return true;
                case "YayinEviFirmaKodu":
                    AranacakKodAdi = aranacakKodAdi;
                    BindGridView(bll.getAllYayinEvleri());
                    BindCmbboxKayitAraKriter(new String[] { "Firma Kodu", "Firma Adı", "Firma Tel", "Firma Fax" });
                    return true;
                case "DilKodu":
                    AranacakKodAdi = aranacakKodAdi;
                    BindGridView(bll.getAllDiller());
                    BindCmbboxKayitAraKriter(new String[] { "Dil Adı" });
                    return true;
            }
            return false;
        }
        private void BindCmbboxKayitAraKriter(string[] items)
        {
            cbbox_KayitAraKriter.Items.Clear();
            cbbox_KayitAraKriter.Items.AddRange(items);
            cbbox_KayitAraKriter.SelectedIndex = 0;
        }
        private void BindGridView(DataTable dt)
        {
            dataGridView_FinCode.DataSource = null;
            dataGridView_FinCode.DataSource = dt;
        }
        // Data Gridview ve cmbbox Doldurma İşlemleri

        // Datagridview kayıt seçme işlemleri
        private void dataGridView_FinCode_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (MainForm.AranacakKodAdi == "DilKodu")
                {
                    MainForm.SecilenKodAdi = dataGridView_FinCode.CurrentRow.Cells[0].Value.ToString();
                    this.Close();
                    return;
                }
                MainForm.SecilenKodAdi = dataGridView_FinCode.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cbbox_KayitAraKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AranacakKodAdi)
            {
                case "UyeKodu":
                    setlblAndtxtUyeKodu(cbbox_KayitAraKriter.SelectedIndex);
                    return;
                case "KitapKodu":
                    setlblAndtxtKitapKodu(cbbox_KayitAraKriter.SelectedIndex);
                    return;
                case "KitapTurKodu":
                    setlblAndtxtKitapTurKodu(cbbox_KayitAraKriter.SelectedIndex);

                    return;
                case "YazarKodu":
                    setlblAndtxtYazarKodu(cbbox_KayitAraKriter.SelectedIndex);
                    return;
                case "YayinEviFirmaKodu":
                    setlblAndtxtYayinEviFirmaKodu(cbbox_KayitAraKriter.SelectedIndex);

                    return;
                case "DilKodu":
                    setlblAndtxtDilKodu(cbbox_KayitAraKriter.SelectedIndex);

                    return;
            }
        }
        private void setlblAndtxtDilKodu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Dil Adı";
                    mtxt_KayitAra.Mask = "";
                    break;

            }
        }
        private void setlblAndtxtYayinEviFirmaKodu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Firma Kodu";
                    mtxt_KayitAra.Mask = "YEFK-0000";
                    break;
                case 1:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Firma Adı";
                    mtxt_KayitAra.Mask = "";
                    break;
                case 2:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Firma Tel";
                    mtxt_KayitAra.Mask = "(999) 000-0000";
                    break;
                case 3:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Firma Fax";
                    mtxt_KayitAra.Mask = "(999) 000-0000";
                    break;
            }
        }
        private void setlblAndtxtYazarKodu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Yazar Kodu";
                    mtxt_KayitAra.Mask = "YK-00000";
                    break;
                case 1:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Yazar Adı";
                    mtxt_KayitAra.Mask = "";
                    break;
                case 2:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Yazar Soyadı";
                    mtxt_KayitAra.Mask = "";
                    break;
            }
        }
        private void setlblAndtxtKitapTurKodu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap Tür Kodu";
                    mtxt_KayitAra.Mask = "KTK-00";
                    break;
                case 1:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap Tür Adı";
                    mtxt_KayitAra.Mask = "";
                    break;
            }
        }
        private void setlblAndtxtUyeKodu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Üye Kodu";
                    mtxt_KayitAra.Mask = "UK-00000";
                    break;
                case 1:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Üye Adı";
                    mtxt_KayitAra.Mask = "";
                    break;
                case 2:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Üye Soyadı";
                    mtxt_KayitAra.Mask = "";
                    break;
                case 3:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Üye Tel";
                    mtxt_KayitAra.Mask = "(999) 000-0000";
                    break;
            }
        }
        private void setlblAndtxtKitapKodu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap Kodu";
                    mtxt_KayitAra.Mask = "";
                    break;
                case 1:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap ISBN";
                    mtxt_KayitAra.Mask = "0000000000000";
                    break;
                case 2:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap Adı";
                    mtxt_KayitAra.Mask = "";
                    break;
                case 3:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap Tür Kodu";
                    mtxt_KayitAra.Mask = "KTK-00";
                    break;
                case 4:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Yazar Kodu";
                    mtxt_KayitAra.Mask = "YK-00000";
                    break;
                case 5:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Yayın Evi Firma Kodu";
                    mtxt_KayitAra.Mask = "YEFK-0000";
                    break;
                case 6:
                    mtxt_KayitAra.Clear();
                    lbl_KayitAra.Text = "Kitap Dil Kodu";
                    mtxt_KayitAra.Mask = "0";
                    break;
            }
        }
        // Datagridview kayıt seçme işlemleri


        //Kayıt Arama İşlmeleri
        private void mtxt_KayitAra_TextChanged(object sender, EventArgs e)
        {
          
            switch (AranacakKodAdi)
            {
                case "UyeKodu":
                    return;
                case "KitapKodu":
                    return;
                case "KitapTurKodu":
                    return;
                case "YazarKodu":
                    return;
                case "YayinEviFirmaKodu":
                    return;
                case "DilKodu":
                    return;
            }
        }
        //Kayıt Arama İşlmeleri

    }
}
