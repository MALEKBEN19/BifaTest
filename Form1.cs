using BifaProject.Properties;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            lblUser.Text = "User : ";
            btnAddEmployee.Enabled = false;
            using (LoginScreen Login = new LoginScreen()) {

                if (Login.ShowDialog()==DialogResult.OK) {
                    lblUser.Text = "User : "+Login.LoggedIn;
                    btnAddEmployee.Enabled=true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex--;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked) {
                pbIdentity.Image = Resources.Rajel;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                pbIdentity.Image = Resources.mara;
            }
        }
        void UpdateScreen()
        {
            btnAddEmployee.Enabled = false;
            lblUser.Text = "User : ";
            rbMale.Checked = true;
            txbFirstName.Clear();
            txbLastName.Clear();
            txbEmail.Clear();
            txbAddress.Clear();
            mkbSalary.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
       void ValidtingBoxes(TextBox TxtBx,CancelEventArgs x) 
        {
            
            if (string.IsNullOrWhiteSpace(TxtBx.Text))
            {
                x.Cancel = true;
                TxtBx.Focus();
                btnNext.Enabled = false;
                btnPerivous.Enabled = false;
                epMenu.SetError(TxtBx,"Filed Is Empty");
                
            }
            else
            {
            
                btnNext.Enabled = true;
                btnPerivous.Enabled = true;
                x.Cancel= false;
                epMenu.SetError(TxtBx, "");
            
            }
        }
        private void txbFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidtingBoxes((TextBox)sender,e);
        }

        private void txbLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidtingBoxes((TextBox)sender, e);
        }

        private void txbAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidtingBoxes((TextBox)sender, e);
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidtingBoxes((TextBox)sender, e);
        }

        private void mkbSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mkbSalary.Text))
            {
                e.Cancel = true;
                mkbSalary.Focus();
                epMenu.SetError(mkbSalary,"Filed Is Empty");
            }
            else
            {
                e.Cancel = false;
                epMenu.SetError(mkbSalary, "");
            }
        }
    }
}
