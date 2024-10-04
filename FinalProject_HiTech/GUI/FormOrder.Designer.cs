namespace FinalProject_HiTech.GUI
{
    partial class FormOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDelivery = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderIdOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeIdOrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomerIdOrd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClearOrd = new System.Windows.Forms.Button();
            this.buttonExitOrd = new System.Windows.Forms.Button();
            this.buttonListOrd = new System.Windows.Forms.Button();
            this.buttonSearchOrd = new System.Windows.Forms.Button();
            this.buttonModifyOrd = new System.Windows.Forms.Button();
            this.buttonRemoveOrd = new System.Windows.Forms.Button();
            this.buttonAddOrd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePickerOrder);
            this.groupBox1.Controls.Add(this.dateTimePickerDelivery);
            this.groupBox1.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxOrderIdOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmployeeIdOrd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCustomerIdOrd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(67, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1582, 169);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "Auto-Generated";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(1084, 88);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(127, 26);
            this.dateTimePickerOrder.TabIndex = 4;
            // 
            // dateTimePickerDelivery
            // 
            this.dateTimePickerDelivery.Location = new System.Drawing.Point(846, 91);
            this.dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            this.dateTimePickerDelivery.Size = new System.Drawing.Size(127, 26);
            this.dateTimePickerDelivery.TabIndex = 3;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Credit",
            "Debit",
            "Cash"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(1315, 90);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(127, 28);
            this.comboBoxPaymentMethod.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(842, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "DeliveryDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "OrderId";
            // 
            // textBoxOrderIdOrder
            // 
            this.textBoxOrderIdOrder.Location = new System.Drawing.Point(130, 90);
            this.textBoxOrderIdOrder.Name = "textBoxOrderIdOrder";
            this.textBoxOrderIdOrder.Size = new System.Drawing.Size(127, 26);
            this.textBoxOrderIdOrder.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "EmployeeId";
            // 
            // textBoxEmployeeIdOrd
            // 
            this.textBoxEmployeeIdOrd.Location = new System.Drawing.Point(610, 90);
            this.textBoxEmployeeIdOrd.Name = "textBoxEmployeeIdOrd";
            this.textBoxEmployeeIdOrd.Size = new System.Drawing.Size(127, 26);
            this.textBoxEmployeeIdOrd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "CustomerId";
            // 
            // textBoxCustomerIdOrd
            // 
            this.textBoxCustomerIdOrd.Location = new System.Drawing.Point(370, 90);
            this.textBoxCustomerIdOrd.Name = "textBoxCustomerIdOrd";
            this.textBoxCustomerIdOrd.Size = new System.Drawing.Size(127, 26);
            this.textBoxCustomerIdOrd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1080, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "OrderDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1311, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "PaymentMethod";
            // 
            // buttonClearOrd
            // 
            this.buttonClearOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearOrd.Location = new System.Drawing.Point(1355, 312);
            this.buttonClearOrd.Name = "buttonClearOrd";
            this.buttonClearOrd.Size = new System.Drawing.Size(176, 53);
            this.buttonClearOrd.TabIndex = 68;
            this.buttonClearOrd.Text = "Clear Text";
            this.buttonClearOrd.UseVisualStyleBackColor = true;
            this.buttonClearOrd.Click += new System.EventHandler(this.buttonClearOrd_Click);
            // 
            // buttonExitOrd
            // 
            this.buttonExitOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitOrd.Location = new System.Drawing.Point(1520, 581);
            this.buttonExitOrd.Name = "buttonExitOrd";
            this.buttonExitOrd.Size = new System.Drawing.Size(129, 47);
            this.buttonExitOrd.TabIndex = 66;
            this.buttonExitOrd.Text = "Exit";
            this.buttonExitOrd.UseVisualStyleBackColor = true;
            this.buttonExitOrd.Click += new System.EventHandler(this.buttonExitOrd_Click);
            // 
            // buttonListOrd
            // 
            this.buttonListOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListOrd.Location = new System.Drawing.Point(1121, 312);
            this.buttonListOrd.Name = "buttonListOrd";
            this.buttonListOrd.Size = new System.Drawing.Size(176, 53);
            this.buttonListOrd.TabIndex = 65;
            this.buttonListOrd.Text = "List All";
            this.buttonListOrd.UseVisualStyleBackColor = true;
            this.buttonListOrd.Click += new System.EventHandler(this.buttonListOrd_Click);
            // 
            // buttonSearchOrd
            // 
            this.buttonSearchOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchOrd.Location = new System.Drawing.Point(887, 315);
            this.buttonSearchOrd.Name = "buttonSearchOrd";
            this.buttonSearchOrd.Size = new System.Drawing.Size(176, 53);
            this.buttonSearchOrd.TabIndex = 64;
            this.buttonSearchOrd.Text = "Search";
            this.buttonSearchOrd.UseVisualStyleBackColor = true;
            this.buttonSearchOrd.Click += new System.EventHandler(this.buttonSearchOrd_Click);
            // 
            // buttonModifyOrd
            // 
            this.buttonModifyOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyOrd.Location = new System.Drawing.Point(653, 315);
            this.buttonModifyOrd.Name = "buttonModifyOrd";
            this.buttonModifyOrd.Size = new System.Drawing.Size(176, 53);
            this.buttonModifyOrd.TabIndex = 63;
            this.buttonModifyOrd.Text = "Modify";
            this.buttonModifyOrd.UseVisualStyleBackColor = true;
            this.buttonModifyOrd.Click += new System.EventHandler(this.buttonModifyOrd_Click);
            // 
            // buttonRemoveOrd
            // 
            this.buttonRemoveOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveOrd.Location = new System.Drawing.Point(419, 315);
            this.buttonRemoveOrd.Name = "buttonRemoveOrd";
            this.buttonRemoveOrd.Size = new System.Drawing.Size(176, 53);
            this.buttonRemoveOrd.TabIndex = 62;
            this.buttonRemoveOrd.Text = "Remove";
            this.buttonRemoveOrd.UseVisualStyleBackColor = true;
            this.buttonRemoveOrd.Click += new System.EventHandler(this.buttonRemoveOrd_Click);
            // 
            // buttonAddOrd
            // 
            this.buttonAddOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrd.Location = new System.Drawing.Point(185, 315);
            this.buttonAddOrd.Name = "buttonAddOrd";
            this.buttonAddOrd.Size = new System.Drawing.Size(176, 53);
            this.buttonAddOrd.TabIndex = 61;
            this.buttonAddOrd.Text = "Add";
            this.buttonAddOrd.UseVisualStyleBackColor = true;
            this.buttonAddOrd.Click += new System.EventHandler(this.buttonAddOrd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(674, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 37);
            this.label2.TabIndex = 60;
            this.label2.Text = "Order Maintenance";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(302, 427);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1112, 201);
            this.dataGridViewOrders.TabIndex = 70;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1716, 858);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearOrd);
            this.Controls.Add(this.buttonExitOrd);
            this.Controls.Add(this.buttonListOrd);
            this.Controls.Add(this.buttonSearchOrd);
            this.Controls.Add(this.buttonModifyOrd);
            this.Controls.Add(this.buttonRemoveOrd);
            this.Controls.Add(this.buttonAddOrd);
            this.Controls.Add(this.label2);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderIdOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmployeeIdOrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCustomerIdOrd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClearOrd;
        private System.Windows.Forms.Button buttonExitOrd;
        private System.Windows.Forms.Button buttonListOrd;
        private System.Windows.Forms.Button buttonSearchOrd;
        private System.Windows.Forms.Button buttonModifyOrd;
        private System.Windows.Forms.Button buttonRemoveOrd;
        private System.Windows.Forms.Button buttonAddOrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelivery;
        private System.Windows.Forms.Label label11;
    }
}