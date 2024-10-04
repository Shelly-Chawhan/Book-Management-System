namespace FinalProject_HiTech.GUI
{
    partial class FormMISManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewShowEmployee = new System.Windows.Forms.ListView();
            this.columnHeaderEmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJobId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatusId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxStatusIdEmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxJobIdEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClearEmp = new System.Windows.Forms.Button();
            this.buttonExitEmp = new System.Windows.Forms.Button();
            this.buttonListEmp = new System.Windows.Forms.Button();
            this.buttonSearchEmp = new System.Windows.Forms.Button();
            this.buttonModifyEmp = new System.Windows.Forms.Button();
            this.buttonRemoveEmp = new System.Windows.Forms.Button();
            this.buttonAddEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerCreationDateUser = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxStatusIdUser = new System.Windows.Forms.TextBox();
            this.buttonListAllUser = new System.Windows.Forms.Button();
            this.buttonExitUser = new System.Windows.Forms.Button();
            this.listViewShowUser = new System.Windows.Forms.ListView();
            this.columnHeaderUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatusIdU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClearAllUser = new System.Windows.Forms.Button();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonModifyUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1756, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.listViewShowEmployee);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.buttonClearEmp);
            this.tabPage1.Controls.Add(this.buttonExitEmp);
            this.tabPage1.Controls.Add(this.buttonListEmp);
            this.tabPage1.Controls.Add(this.buttonSearchEmp);
            this.tabPage1.Controls.Add(this.buttonModifyEmp);
            this.tabPage1.Controls.Add(this.buttonRemoveEmp);
            this.tabPage1.Controls.Add(this.buttonAddEmp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1748, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            // 
            // listViewShowEmployee
            // 
            this.listViewShowEmployee.BackColor = System.Drawing.Color.Pink;
            this.listViewShowEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmployeeId,
            this.columnHeaderFirstName,
            this.columnHeaderLastname,
            this.columnHeaderPhoneNumber,
            this.columnHeaderEmail,
            this.columnHeaderJobId,
            this.columnHeaderStatusId});
            this.listViewShowEmployee.GridLines = true;
            this.listViewShowEmployee.HideSelection = false;
            this.listViewShowEmployee.Location = new System.Drawing.Point(255, 410);
            this.listViewShowEmployee.Name = "listViewShowEmployee";
            this.listViewShowEmployee.Size = new System.Drawing.Size(1238, 208);
            this.listViewShowEmployee.TabIndex = 57;
            this.listViewShowEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewShowEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEmployeeId
            // 
            this.columnHeaderEmployeeId.Text = "EmployeeId";
            this.columnHeaderEmployeeId.Width = 108;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "FirstName";
            this.columnHeaderFirstName.Width = 141;
            // 
            // columnHeaderLastname
            // 
            this.columnHeaderLastname.Text = "Lastname";
            this.columnHeaderLastname.Width = 116;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "PhoneNumber";
            this.columnHeaderPhoneNumber.Width = 135;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 212;
            // 
            // columnHeaderJobId
            // 
            this.columnHeaderJobId.Text = "JobId";
            this.columnHeaderJobId.Width = 174;
            // 
            // columnHeaderStatusId
            // 
            this.columnHeaderStatusId.Text = "StatusId";
            this.columnHeaderStatusId.Width = 271;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxEmployeeId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxStatusIdEmp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxJobIdEmp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(83, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1582, 169);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "EmployeeId";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(12, 90);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(143, 26);
            this.textBoxEmployeeId.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Ex-> XXX-XXX-XXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(492, 90);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(143, 26);
            this.textBoxLastName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(252, 90);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(143, 26);
            this.textBoxFirstName.TabIndex = 31;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(728, 90);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(143, 26);
            this.textBoxPhoneNumber.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(962, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(966, 90);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(143, 26);
            this.textBoxEmail.TabIndex = 35;
            // 
            // textBoxStatusIdEmp
            // 
            this.textBoxStatusIdEmp.Location = new System.Drawing.Point(1424, 90);
            this.textBoxStatusIdEmp.Name = "textBoxStatusIdEmp";
            this.textBoxStatusIdEmp.Size = new System.Drawing.Size(143, 26);
            this.textBoxStatusIdEmp.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1193, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "JobId";
            // 
            // textBoxJobIdEmp
            // 
            this.textBoxJobIdEmp.Location = new System.Drawing.Point(1197, 90);
            this.textBoxJobIdEmp.Name = "textBoxJobIdEmp";
            this.textBoxJobIdEmp.Size = new System.Drawing.Size(143, 26);
            this.textBoxJobIdEmp.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1420, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "StatusId";
            // 
            // buttonClearEmp
            // 
            this.buttonClearEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEmp.Location = new System.Drawing.Point(1371, 302);
            this.buttonClearEmp.Name = "buttonClearEmp";
            this.buttonClearEmp.Size = new System.Drawing.Size(176, 53);
            this.buttonClearEmp.TabIndex = 58;
            this.buttonClearEmp.Text = "Clear Text";
            this.buttonClearEmp.UseVisualStyleBackColor = true;
            this.buttonClearEmp.Click += new System.EventHandler(this.buttonClearEmp_Click);
            // 
            // buttonExitEmp
            // 
            this.buttonExitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitEmp.Location = new System.Drawing.Point(1536, 571);
            this.buttonExitEmp.Name = "buttonExitEmp";
            this.buttonExitEmp.Size = new System.Drawing.Size(129, 47);
            this.buttonExitEmp.TabIndex = 56;
            this.buttonExitEmp.Text = "Exit";
            this.buttonExitEmp.UseVisualStyleBackColor = true;
            this.buttonExitEmp.Click += new System.EventHandler(this.buttonExitEmp_Click);
            // 
            // buttonListEmp
            // 
            this.buttonListEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListEmp.Location = new System.Drawing.Point(1137, 302);
            this.buttonListEmp.Name = "buttonListEmp";
            this.buttonListEmp.Size = new System.Drawing.Size(176, 53);
            this.buttonListEmp.TabIndex = 55;
            this.buttonListEmp.Text = "List All";
            this.buttonListEmp.UseVisualStyleBackColor = true;
            this.buttonListEmp.Click += new System.EventHandler(this.buttonListEmp_Click);
            // 
            // buttonSearchEmp
            // 
            this.buttonSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchEmp.Location = new System.Drawing.Point(903, 305);
            this.buttonSearchEmp.Name = "buttonSearchEmp";
            this.buttonSearchEmp.Size = new System.Drawing.Size(176, 53);
            this.buttonSearchEmp.TabIndex = 54;
            this.buttonSearchEmp.Text = "Search";
            this.buttonSearchEmp.UseVisualStyleBackColor = true;
            this.buttonSearchEmp.Click += new System.EventHandler(this.buttonSearchEmp_Click);
            // 
            // buttonModifyEmp
            // 
            this.buttonModifyEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyEmp.Location = new System.Drawing.Point(669, 305);
            this.buttonModifyEmp.Name = "buttonModifyEmp";
            this.buttonModifyEmp.Size = new System.Drawing.Size(176, 53);
            this.buttonModifyEmp.TabIndex = 53;
            this.buttonModifyEmp.Text = "Modify";
            this.buttonModifyEmp.UseVisualStyleBackColor = true;
            this.buttonModifyEmp.Click += new System.EventHandler(this.buttonModifyEmp_Click);
            // 
            // buttonRemoveEmp
            // 
            this.buttonRemoveEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveEmp.Location = new System.Drawing.Point(435, 305);
            this.buttonRemoveEmp.Name = "buttonRemoveEmp";
            this.buttonRemoveEmp.Size = new System.Drawing.Size(176, 53);
            this.buttonRemoveEmp.TabIndex = 52;
            this.buttonRemoveEmp.Text = "Remove";
            this.buttonRemoveEmp.UseVisualStyleBackColor = true;
            this.buttonRemoveEmp.Click += new System.EventHandler(this.buttonRemoveEmp_Click);
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmp.Location = new System.Drawing.Point(201, 305);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(176, 53);
            this.buttonAddEmp.TabIndex = 51;
            this.buttonAddEmp.Text = "Add";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(690, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 37);
            this.label2.TabIndex = 50;
            this.label2.Text = "Employee Maintenance";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.buttonListAllUser);
            this.tabPage2.Controls.Add(this.buttonExitUser);
            this.tabPage2.Controls.Add(this.listViewShowUser);
            this.tabPage2.Controls.Add(this.buttonClearAllUser);
            this.tabPage2.Controls.Add(this.buttonSearchUser);
            this.tabPage2.Controls.Add(this.buttonModifyUser);
            this.tabPage2.Controls.Add(this.buttonRemoveUser);
            this.tabPage2.Controls.Add(this.buttonAddUser);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1748, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UserAccounts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateTimePickerCreationDateUser);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxUserId);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxStatusIdUser);
            this.groupBox2.Location = new System.Drawing.Point(148, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1452, 136);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UserAccount Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(753, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Date Of Creation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "UserId";
            // 
            // dateTimePickerCreationDateUser
            // 
            this.dateTimePickerCreationDateUser.Location = new System.Drawing.Point(758, 92);
            this.dateTimePickerCreationDateUser.Name = "dateTimePickerCreationDateUser";
            this.dateTimePickerCreationDateUser.Size = new System.Drawing.Size(291, 26);
            this.dateTimePickerCreationDateUser.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1103, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "StatusId";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(59, 91);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(291, 26);
            this.textBoxUserId.TabIndex = 23;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(408, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(291, 26);
            this.textBoxPassword.TabIndex = 24;
            // 
            // textBoxStatusIdUser
            // 
            this.textBoxStatusIdUser.Location = new System.Drawing.Point(1106, 91);
            this.textBoxStatusIdUser.Name = "textBoxStatusIdUser";
            this.textBoxStatusIdUser.Size = new System.Drawing.Size(291, 26);
            this.textBoxStatusIdUser.TabIndex = 25;
            // 
            // buttonListAllUser
            // 
            this.buttonListAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAllUser.Location = new System.Drawing.Point(1177, 324);
            this.buttonListAllUser.Name = "buttonListAllUser";
            this.buttonListAllUser.Size = new System.Drawing.Size(126, 56);
            this.buttonListAllUser.TabIndex = 44;
            this.buttonListAllUser.Text = "List All";
            this.buttonListAllUser.UseVisualStyleBackColor = true;
            this.buttonListAllUser.Click += new System.EventHandler(this.buttonListAllUser_Click_1);
            // 
            // buttonExitUser
            // 
            this.buttonExitUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitUser.Location = new System.Drawing.Point(1421, 570);
            this.buttonExitUser.Name = "buttonExitUser";
            this.buttonExitUser.Size = new System.Drawing.Size(126, 56);
            this.buttonExitUser.TabIndex = 43;
            this.buttonExitUser.Text = "Exit";
            this.buttonExitUser.UseVisualStyleBackColor = true;
            this.buttonExitUser.Click += new System.EventHandler(this.buttonExitUser_Click_1);
            // 
            // listViewShowUser
            // 
            this.listViewShowUser.BackColor = System.Drawing.Color.LightSalmon;
            this.listViewShowUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUserId,
            this.columnHeaderPassword,
            this.columnHeaderDateCreated,
            this.columnHeaderStatusIdU});
            this.listViewShowUser.GridLines = true;
            this.listViewShowUser.HideSelection = false;
            this.listViewShowUser.Location = new System.Drawing.Point(427, 438);
            this.listViewShowUser.Name = "listViewShowUser";
            this.listViewShowUser.Size = new System.Drawing.Size(895, 188);
            this.listViewShowUser.TabIndex = 42;
            this.listViewShowUser.UseCompatibleStateImageBehavior = false;
            this.listViewShowUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUserId
            // 
            this.columnHeaderUserId.Text = "UserId";
            this.columnHeaderUserId.Width = 163;
            // 
            // columnHeaderPassword
            // 
            this.columnHeaderPassword.Text = "Password";
            this.columnHeaderPassword.Width = 261;
            // 
            // columnHeaderDateCreated
            // 
            this.columnHeaderDateCreated.Text = "Date Of Creation";
            this.columnHeaderDateCreated.Width = 269;
            // 
            // columnHeaderStatusIdU
            // 
            this.columnHeaderStatusIdU.Text = "Status Id";
            this.columnHeaderStatusIdU.Width = 170;
            // 
            // buttonClearAllUser
            // 
            this.buttonClearAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAllUser.Location = new System.Drawing.Point(1421, 324);
            this.buttonClearAllUser.Name = "buttonClearAllUser";
            this.buttonClearAllUser.Size = new System.Drawing.Size(126, 56);
            this.buttonClearAllUser.TabIndex = 41;
            this.buttonClearAllUser.Text = "ClearAll";
            this.buttonClearAllUser.UseVisualStyleBackColor = true;
            this.buttonClearAllUser.Click += new System.EventHandler(this.buttonClearAllUser_Click_1);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUser.Location = new System.Drawing.Point(933, 324);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(126, 56);
            this.buttonSearchUser.TabIndex = 40;
            this.buttonSearchUser.Text = "Search";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click_1);
            // 
            // buttonModifyUser
            // 
            this.buttonModifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyUser.Location = new System.Drawing.Point(689, 324);
            this.buttonModifyUser.Name = "buttonModifyUser";
            this.buttonModifyUser.Size = new System.Drawing.Size(126, 56);
            this.buttonModifyUser.TabIndex = 39;
            this.buttonModifyUser.Text = "Modify";
            this.buttonModifyUser.UseVisualStyleBackColor = true;
            this.buttonModifyUser.Click += new System.EventHandler(this.buttonModifyUser_Click_1);
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveUser.Location = new System.Drawing.Point(445, 324);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(126, 56);
            this.buttonRemoveUser.TabIndex = 38;
            this.buttonRemoveUser.Text = "Remove";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click_1);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Location = new System.Drawing.Point(201, 324);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(126, 56);
            this.buttonAddUser.TabIndex = 37;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(729, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 37);
            this.label10.TabIndex = 36;
            this.label10.Text = "User Maintenance";
            // 
            // FormMISManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1808, 725);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMISManager";
            this.Text = "FormMISManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewShowEmployee;
        private System.Windows.Forms.ColumnHeader columnHeaderEmployeeId;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastname;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderJobId;
        private System.Windows.Forms.ColumnHeader columnHeaderStatusId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxStatusIdEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxJobIdEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClearEmp;
        private System.Windows.Forms.Button buttonExitEmp;
        private System.Windows.Forms.Button buttonListEmp;
        private System.Windows.Forms.Button buttonSearchEmp;
        private System.Windows.Forms.Button buttonModifyEmp;
        private System.Windows.Forms.Button buttonRemoveEmp;
        private System.Windows.Forms.Button buttonAddEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreationDateUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxStatusIdUser;
        private System.Windows.Forms.Button buttonListAllUser;
        private System.Windows.Forms.Button buttonExitUser;
        private System.Windows.Forms.ListView listViewShowUser;
        private System.Windows.Forms.ColumnHeader columnHeaderUserId;
        private System.Windows.Forms.ColumnHeader columnHeaderPassword;
        private System.Windows.Forms.ColumnHeader columnHeaderDateCreated;
        private System.Windows.Forms.ColumnHeader columnHeaderStatusIdU;
        private System.Windows.Forms.Button buttonClearAllUser;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonModifyUser;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label10;
    }
}