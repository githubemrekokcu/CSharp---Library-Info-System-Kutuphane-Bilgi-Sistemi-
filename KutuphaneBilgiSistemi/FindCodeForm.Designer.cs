namespace KutuphaneBilgiSistemi
{
    partial class FindCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_FinCode = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbox_KayitAraKriter = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.lbl_KayitAra = new System.Windows.Forms.Label();
            this.mtxt_KayitAra = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FinCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_FinCode
            // 
            this.dataGridView_FinCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FinCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FinCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_FinCode.Location = new System.Drawing.Point(0, 113);
            this.dataGridView_FinCode.Name = "dataGridView_FinCode";
            this.dataGridView_FinCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FinCode.Size = new System.Drawing.Size(532, 201);
            this.dataGridView_FinCode.TabIndex = 0;
            this.dataGridView_FinCode.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_FinCode_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_KayitAra);
            this.groupBox1.Controls.Add(this.mtxt_KayitAra);
            this.groupBox1.Controls.Add(this.cbbox_KayitAraKriter);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Bulma İşlemleri";
            // 
            // cbbox_KayitAraKriter
            // 
            this.cbbox_KayitAraKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_KayitAraKriter.FormattingEnabled = true;
            this.cbbox_KayitAraKriter.Items.AddRange(new object[] {
            "Kiralama Kodu",
            "Kitap Kodu",
            "Üye Kodu"});
            this.cbbox_KayitAraKriter.Location = new System.Drawing.Point(257, 26);
            this.cbbox_KayitAraKriter.Name = "cbbox_KayitAraKriter";
            this.cbbox_KayitAraKriter.Size = new System.Drawing.Size(238, 21);
            this.cbbox_KayitAraKriter.TabIndex = 3;
            this.cbbox_KayitAraKriter.SelectedIndexChanged += new System.EventHandler(this.cbbox_KayitAraKriter_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label40.Location = new System.Drawing.Point(12, 29);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(194, 13);
            this.label40.TabIndex = 4;
            this.label40.Text = "Hangi Değere Göre Aranacak Seçiniz : ";
            // 
            // lbl_KayitAra
            // 
            this.lbl_KayitAra.AutoSize = true;
            this.lbl_KayitAra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_KayitAra.Location = new System.Drawing.Point(12, 74);
            this.lbl_KayitAra.Name = "lbl_KayitAra";
            this.lbl_KayitAra.Size = new System.Drawing.Size(68, 13);
            this.lbl_KayitAra.TabIndex = 6;
            this.lbl_KayitAra.Text = "Kitap Tür Adı";
            // 
            // mtxt_KayitAra
            // 
            this.mtxt_KayitAra.Location = new System.Drawing.Point(257, 67);
            this.mtxt_KayitAra.Mask = "KTK-00";
            this.mtxt_KayitAra.Name = "mtxt_KayitAra";
            this.mtxt_KayitAra.Size = new System.Drawing.Size(238, 20);
            this.mtxt_KayitAra.TabIndex = 5;
            this.mtxt_KayitAra.TextChanged += new System.EventHandler(this.mtxt_KayitAra_TextChanged);
            // 
            // FindCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_FinCode);
            this.Name = "FindCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KÜTÜPHANE BİLGİ SİSTEMİ - Kod Arama Ekranı";
            this.Load += new System.EventHandler(this.FindCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FinCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_FinCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbox_KayitAraKriter;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lbl_KayitAra;
        private System.Windows.Forms.MaskedTextBox mtxt_KayitAra;
    }
}