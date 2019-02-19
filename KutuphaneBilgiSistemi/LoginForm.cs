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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btn_showpass_MouseDown(object sender, MouseEventArgs e)//click hold event
        {
          //  MessageBox.Show("click btn_showpass_MouseDown hold");
            txt_password.PasswordChar = '\0';
        }

        private void btn_showpass_MouseUp(object sender, MouseEventArgs e)//click unhold event
        {
            txt_password.PasswordChar = '*';
        }

        private void btn_exit_Click(object sender, EventArgs e)//Form Close event.
        {
            Environment.Exit(0);
        }

    }
}
