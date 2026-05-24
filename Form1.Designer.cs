namespace BifaProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.tpAddEmployee = new System.Windows.Forms.TabPage();
            this.pbIdentity = new System.Windows.Forms.PictureBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mkbSalary = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.tpEmployeeList = new System.Windows.Forms.TabPage();
            this.tpBudget = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPerivous = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.epMenu = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMenu);
            this.tabControl1.Controls.Add(this.tpAddEmployee);
            this.tabControl1.Controls.Add(this.tpEmployeeList);
            this.tabControl1.Controls.Add(this.tpBudget);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 526);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tpMenu
            // 
            this.tpMenu.BackgroundImage = global::BifaProject.Properties.Resources.bifo;
            this.tpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpMenu.Location = new System.Drawing.Point(4, 22);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.tpMenu.Size = new System.Drawing.Size(1075, 500);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // tpAddEmployee
            // 
            this.tpAddEmployee.BackColor = System.Drawing.Color.Beige;
            this.tpAddEmployee.Controls.Add(this.pbIdentity);
            this.tpAddEmployee.Controls.Add(this.btnAddEmployee);
            this.tpAddEmployee.Controls.Add(this.groupBox1);
            this.tpAddEmployee.Controls.Add(this.label6);
            this.tpAddEmployee.Controls.Add(this.label5);
            this.tpAddEmployee.Controls.Add(this.label4);
            this.tpAddEmployee.Controls.Add(this.label3);
            this.tpAddEmployee.Controls.Add(this.label2);
            this.tpAddEmployee.Controls.Add(this.label1);
            this.tpAddEmployee.Controls.Add(this.mkbSalary);
            this.tpAddEmployee.Controls.Add(this.txbEmail);
            this.tpAddEmployee.Controls.Add(this.txbAddress);
            this.tpAddEmployee.Controls.Add(this.txbLastName);
            this.tpAddEmployee.Controls.Add(this.txbFirstName);
            this.tpAddEmployee.Location = new System.Drawing.Point(4, 22);
            this.tpAddEmployee.Name = "tpAddEmployee";
            this.tpAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddEmployee.Size = new System.Drawing.Size(1075, 500);
            this.tpAddEmployee.TabIndex = 1;
            this.tpAddEmployee.Text = "Add Employees";
            // 
            // pbIdentity
            // 
            this.pbIdentity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbIdentity.Location = new System.Drawing.Point(750, 57);
            this.pbIdentity.Name = "pbIdentity";
            this.pbIdentity.Size = new System.Drawing.Size(309, 351);
            this.pbIdentity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIdentity.TabIndex = 6;
            this.pbIdentity.TabStop = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Green;
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(488, 286);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(181, 54);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(439, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(156, 58);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(107, 29);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(30, 58);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(81, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // mkbSalary
            // 
            this.mkbSalary.BeepOnError = true;
            this.mkbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbSalary.Location = new System.Drawing.Point(54, 377);
            this.mkbSalary.Mask = "\\D\\A 000000";
            this.mkbSalary.Name = "mkbSalary";
            this.mkbSalary.Size = new System.Drawing.Size(330, 31);
            this.mkbSalary.TabIndex = 1;
            
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbEmail.Location = new System.Drawing.Point(54, 297);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(330, 32);
            this.txbEmail.TabIndex = 0;
            
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbAddress.Location = new System.Drawing.Point(54, 217);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(330, 32);
            this.txbAddress.TabIndex = 0;

            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbLastName.Location = new System.Drawing.Point(54, 137);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(330, 32);
            this.txbLastName.TabIndex = 0;

            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbFirstName.Location = new System.Drawing.Point(54, 57);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(330, 32);
            this.txbFirstName.TabIndex = 0;
           
            // 
            // tpEmployeeList
            // 
            this.tpEmployeeList.BackColor = System.Drawing.Color.Beige;
            this.tpEmployeeList.Location = new System.Drawing.Point(4, 22);
            this.tpEmployeeList.Name = "tpEmployeeList";
            this.tpEmployeeList.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeList.Size = new System.Drawing.Size(1075, 500);
            this.tpEmployeeList.TabIndex = 2;
            this.tpEmployeeList.Text = "Employees List";
            // 
            // tpBudget
            // 
            this.tpBudget.BackColor = System.Drawing.Color.Beige;
            this.tpBudget.Location = new System.Drawing.Point(4, 22);
            this.tpBudget.Name = "tpBudget";
            this.tpBudget.Padding = new System.Windows.Forms.Padding(3);
            this.tpBudget.Size = new System.Drawing.Size(1075, 500);
            this.tpBudget.TabIndex = 3;
            this.tpBudget.Text = "Budget/Employees";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1006, 544);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 38);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPerivous
            // 
            this.btnPerivous.BackColor = System.Drawing.Color.White;
            this.btnPerivous.Location = new System.Drawing.Point(883, 544);
            this.btnPerivous.Name = "btnPerivous";
            this.btnPerivous.Size = new System.Drawing.Size(107, 38);
            this.btnPerivous.TabIndex = 2;
            this.btnPerivous.Text = "Perivous...";
            this.btnPerivous.UseVisualStyleBackColor = false;
            this.btnPerivous.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(30, 548);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 29);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User : ";
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.BackColor = System.Drawing.Color.White;
            this.btnLoginLogout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoginLogout.FlatAppearance.BorderSize = 2;
            this.btnLoginLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoginLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoginLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLogout.Location = new System.Drawing.Point(1119, 34);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(72, 43);
            this.btnLoginLogout.TabIndex = 4;
            this.btnLoginLogout.Text = "Login & Logout";
            this.btnLoginLogout.UseVisualStyleBackColor = false;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // epMenu
            // 
            this.epMenu.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1203, 590);
            this.Controls.Add(this.btnLoginLogout);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnPerivous);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bifa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAddEmployee.ResumeLayout(false);
            this.tpAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpAddEmployee;
        private System.Windows.Forms.TabPage tpEmployeeList;
        private System.Windows.Forms.TabPage tpBudget;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPerivous;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLoginLogout;
        private System.Windows.Forms.MaskedTextBox mkbSalary;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.PictureBox pbIdentity;
        private System.Windows.Forms.ErrorProvider epMenu;
    }
}

