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
        byte counter = 0;
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
                tabControl1.SelectTab(tabControl1.SelectedIndex+1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectTab(tabControl1.SelectedIndex - 1);
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
            this.AutoValidate = AutoValidate.Disable;
        }
  
            


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
       
            if (tabControl1.SelectedTab == tpAddEmployee)
            {
               
                if(string.IsNullOrWhiteSpace(txbFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txbLastName.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbAddress.Text) || 
                    !mkbSalary.MaskCompleted)
                {
                    
                    MessageBox.Show("Please Fill The Filled","Warning",MessageBoxButtons.OK);
                    e.Cancel=true;
                    
                }
            }
         
        }
    }
}
