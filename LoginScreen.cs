using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BifaProject
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        public string LoggedIn {  get;protected set; }
        private void txbUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUser.Text)) {
                e.Cancel = true;
                txbUser.Focus();
                epLoginScreen.SetError(txbUser,"Filed Is Empty");

            }
            else
            {
                e.Cancel = false;
                epLoginScreen.SetError(txbUser,"");
            }
        }

        private void mkbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mkbPassword.Text))
            {
                e.Cancel = true;
                mkbPassword.Focus();
                epLoginScreen.SetError(mkbPassword, "Filed Is Empty");

            }
            else
            {
                e.Cancel = false;
                epLoginScreen.SetError(mkbPassword, "");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "Malek" && mkbPassword.Text == "malekcrb123")
            {
                DialogResult= DialogResult.OK;
                LoggedIn = txbUser.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Filed","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (mkbPassword.PasswordChar == '\0')
            {
                mkbPassword.PasswordChar = '*';
                btnShowHide.Text = "Show";
            }
            else
            {
                mkbPassword.PasswordChar = '\0';
                btnShowHide.Text = "Hide";
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            mkbPassword.PasswordChar = '*';
        }
    }
}
