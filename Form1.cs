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
        DateTime Mydate=DateTime.Now;
        double TotalSalaries = 0;
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
            lbDate.Text = Mydate.ToString();
            lblTotalBudget.Text = "Budget Per Month : DZA " + TotalSalaries.ToString();
            lblTotalEmployees.Text="Total Employees : "+listView1.Items.Count.ToString()+" Employee(s)";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbFirstName.Text)||
                string.IsNullOrWhiteSpace(txbLastName.Text) ||
                string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbAddress.Text)||
                 string.IsNullOrWhiteSpace(mkbSalary.Text)
                )
            {
                MessageBox.Show("You Need To fil all fields First","warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {

                ListViewItem Item=new ListViewItem();
                Item.Text=txbFirstName.Text;

                if (rbMale.Checked)
                {
                    Item.ImageIndex = 0;
                }
                else
                {
                    Item.ImageIndex = 1;
                }
                Item.SubItems.Add(txbLastName.Text);
                Item.SubItems.Add(txbEmail.Text);
                Item.SubItems.Add(txbAddress.Text);
              
                string clean = new string(mkbSalary.Text.Where(char.IsDigit).ToArray());
                if (string.IsNullOrWhiteSpace(clean))
                {
                    MessageBox.Show("Enter a valid salary!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                double Salary = Convert.ToDouble(clean);

                TotalSalaries += Salary;
                Item.SubItems.Add(Salary.ToString()+" DZA ");
                listView1.Items.Add(Item);

                UpdateScreen();
                MessageBox.Show("Employee was Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




       
    }
}
