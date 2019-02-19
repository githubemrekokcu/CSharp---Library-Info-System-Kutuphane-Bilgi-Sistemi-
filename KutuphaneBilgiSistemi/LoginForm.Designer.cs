namespace KutuphaneBilgiSistemi
{
    partial class LoginForm
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_showpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(441, 138);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(361, 29);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(441, 179);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(334, 29);
            this.txt_password.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane Bilgi Sistemi";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Location = new System.Drawing.Point(662, 266);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(140, 56);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Kapat";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(516, 266);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(140, 56);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(247, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(247, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(399, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(399, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // btn_showpass
            // 
            this.btn_showpass.BackColor = System.Drawing.SystemColors.Window;
            this.btn_showpass.BackgroundImage = global::KutuphaneBilgiSistemi.Properties.Resources.show_password_img__2_;
            this.btn_showpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_showpass.Location = new System.Drawing.Point(770, 179);
            this.btn_showpass.Name = "btn_showpass";
            this.btn_showpass.Size = new System.Drawing.Size(32, 29);
            this.btn_showpass.TabIndex = 5;
            this.btn_showpass.UseVisualStyleBackColor = false;
            this.btn_showpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showpass_MouseDown);
            this.btn_showpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showpass_MouseUp);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneBilgiSistemi.Properties.Resources.books_login_img;
            this.ClientSize = new System.Drawing.Size(856, 378);
            this.Controls.Add(this.btn_showpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_showpass;
    }
}

