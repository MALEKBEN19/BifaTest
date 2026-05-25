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
            this.label9 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tpBudget = new System.Windows.Forms.TabPage();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.lblTotalBudget = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPerivous = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iLSmallPic = new System.Windows.Forms.ImageList(this.components);
            this.ilLargePic = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tpAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpEmployeeList.SuspendLayout();
            this.tpBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMenu);
            this.tabControl1.Controls.Add(this.tpAddEmployee);
            this.tabControl1.Controls.Add(this.tpEmployeeList);
            this.tabControl1.Controls.Add(this.tpBudget);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.BackgroundImage = global::BifaProject.Properties.Resources.bifo;
            this.tpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpMenu.Location = new System.Drawing.Point(4, 28);
            this.tpMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tpMenu.Size = new System.Drawing.Size(1075, 494);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // tpAddEmployee
            // 
            this.tpAddEmployee.BackColor = System.Drawing.Color.Beige;
            this.tpAddEmployee.Controls.Add(this.label9);
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
            this.tpAddEmployee.Location = new System.Drawing.Point(4, 28);
            this.tpAddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAddEmployee.Name = "tpAddEmployee";
            this.tpAddEmployee.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAddEmployee.Size = new System.Drawing.Size(1075, 494);
            this.tpAddEmployee.TabIndex = 1;
            this.tpAddEmployee.Text = "Add Employees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(412, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 41);
            this.label9.TabIndex = 8;
            this.label9.Text = "Add Employees";
            // 
            // pbIdentity
            // 
            this.pbIdentity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbIdentity.Location = new System.Drawing.Point(750, 57);
            this.pbIdentity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnAddEmployee.Location = new System.Drawing.Point(459, 286);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(181, 54);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(419, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(156, 58);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.label6.Location = new System.Drawing.Point(22, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 189);
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
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // mkbSalary
            // 
            this.mkbSalary.BeepOnError = true;
            this.mkbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbSalary.Location = new System.Drawing.Point(27, 377);
            this.mkbSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mkbSalary.Mask = "\\D\\A 000000";
            this.mkbSalary.Name = "mkbSalary";
            this.mkbSalary.Size = new System.Drawing.Size(330, 31);
            this.mkbSalary.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbEmail.Location = new System.Drawing.Point(27, 297);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(330, 32);
            this.txbEmail.TabIndex = 0;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbAddress.Location = new System.Drawing.Point(27, 217);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(330, 32);
            this.txbAddress.TabIndex = 0;
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbLastName.Location = new System.Drawing.Point(27, 137);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(330, 32);
            this.txbLastName.TabIndex = 0;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txbFirstName.Location = new System.Drawing.Point(27, 57);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(330, 32);
            this.txbFirstName.TabIndex = 0;
            // 
            // tpEmployeeList
            // 
            this.tpEmployeeList.BackColor = System.Drawing.Color.Beige;
            this.tpEmployeeList.Controls.Add(this.button2);
            this.tpEmployeeList.Controls.Add(this.label8);
            this.tpEmployeeList.Controls.Add(this.listView1);
            this.tpEmployeeList.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpEmployeeList.Name = "tpEmployeeList";
            this.tpEmployeeList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpEmployeeList.Size = new System.Drawing.Size(1075, 494);
            this.tpEmployeeList.TabIndex = 2;
            this.tpEmployeeList.Text = "Employees List";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(892, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Employee";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "Employees List";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmEmail,
            this.clmAddress,
            this.clmSalary});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ilLargePic;
            this.listView1.Location = new System.Drawing.Point(6, 71);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1063, 416);
            this.listView1.SmallImageList = this.iLSmallPic;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tpBudget
            // 
            this.tpBudget.BackColor = System.Drawing.Color.Beige;
            this.tpBudget.Controls.Add(this.lblTotalEmployees);
            this.tpBudget.Controls.Add(this.lblTotalBudget);
            this.tpBudget.Controls.Add(this.label7);
            this.tpBudget.Controls.Add(this.button1);
            this.tpBudget.Location = new System.Drawing.Point(4, 28);
            this.tpBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpBudget.Name = "tpBudget";
            this.tpBudget.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpBudget.Size = new System.Drawing.Size(1075, 494);
            this.tpBudget.TabIndex = 3;
            this.tpBudget.Text = "Budget/Employees";
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.BackColor = System.Drawing.Color.White;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.Location = new System.Drawing.Point(125, 261);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(308, 41);
            this.lblTotalEmployees.TabIndex = 3;
            this.lblTotalEmployees.Text = "Total Employees :";
            // 
            // lblTotalBudget
            // 
            this.lblTotalBudget.AutoSize = true;
            this.lblTotalBudget.BackColor = System.Drawing.Color.White;
            this.lblTotalBudget.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBudget.Location = new System.Drawing.Point(125, 169);
            this.lblTotalBudget.Name = "lblTotalBudget";
            this.lblTotalBudget.Size = new System.Drawing.Size(155, 41);
            this.lblTotalBudget.TabIndex = 3;
            this.lblTotalBudget.Text = "Budget :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "Budget / Total Employes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(77, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(929, 214);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1006, 544);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnPerivous.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lblUser.Size = new System.Drawing.Size(222, 29);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User Will Be Here";
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.BackColor = System.Drawing.Color.White;
            this.btnLoginLogout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoginLogout.FlatAppearance.BorderSize = 2;
            this.btnLoginLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoginLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoginLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLogout.Location = new System.Drawing.Point(1120, 40);
            this.btnLoginLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(72, 43);
            this.btnLoginLogout.TabIndex = 4;
            this.btnLoginLogout.Text = "Login & Logout";
            this.btnLoginLogout.UseVisualStyleBackColor = false;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(928, 8);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(185, 25);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Date will be here";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "First Name";
            this.clmFirstName.Width = 120;
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            this.clmLastName.Width = 120;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 100;
            // 
            // clmAddress
            // 
            this.clmAddress.Text = "Address";
            this.clmAddress.Width = 100;
            // 
            // clmSalary
            // 
            this.clmSalary.Text = "Salary";
            this.clmSalary.Width = 80;
            // 
            // iLSmallPic
            // 
            this.iLSmallPic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLSmallPic.ImageStream")));
            this.iLSmallPic.TransparentColor = System.Drawing.Color.Transparent;
            this.iLSmallPic.Images.SetKeyName(0, "Rajel.png");
            this.iLSmallPic.Images.SetKeyName(1, "mara.png");
            // 
            // ilLargePic
            // 
            this.ilLargePic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLargePic.ImageStream")));
            this.ilLargePic.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLargePic.Images.SetKeyName(0, "Rajel.png");
            this.ilLargePic.Images.SetKeyName(1, "mara.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1200, 590);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnLoginLogout);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnPerivous);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Bifa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAddEmployee.ResumeLayout(false);
            this.tpAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpEmployeeList.ResumeLayout(false);
            this.tpEmployeeList.PerformLayout();
            this.tpBudget.ResumeLayout(false);
            this.tpBudget.PerformLayout();
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
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label lblTotalBudget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmAddress;
        private System.Windows.Forms.ColumnHeader clmSalary;
        private System.Windows.Forms.ImageList iLSmallPic;
        private System.Windows.Forms.ImageList ilLargePic;
    }
}

