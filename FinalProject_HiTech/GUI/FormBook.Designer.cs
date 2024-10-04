namespace FinalProject_HiTech.GUI
{
    partial class FormBook
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
            this.listViewShowBook = new System.Windows.Forms.ListView();
            this.columnHeaderBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQOH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPublisherId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.textBoxPublisherIdBook = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCategoryIdBook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClearBook = new System.Windows.Forms.Button();
            this.buttonExitBook = new System.Windows.Forms.Button();
            this.buttonListBook = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.buttonModifyBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewShowBook
            // 
            this.listViewShowBook.BackColor = System.Drawing.Color.Thistle;
            this.listViewShowBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookId,
            this.columnHeaderISBN,
            this.columnHeaderTitle,
            this.columnHeaderUnitPrice,
            this.columnHeaderQOH,
            this.columnHeaderCategoryId,
            this.columnHeaderPublisherId});
            this.listViewShowBook.GridLines = true;
            this.listViewShowBook.HideSelection = false;
            this.listViewShowBook.Location = new System.Drawing.Point(248, 426);
            this.listViewShowBook.Name = "listViewShowBook";
            this.listViewShowBook.Size = new System.Drawing.Size(1238, 208);
            this.listViewShowBook.TabIndex = 57;
            this.listViewShowBook.UseCompatibleStateImageBehavior = false;
            this.listViewShowBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBookId
            // 
            this.columnHeaderBookId.Text = "BookId";
            this.columnHeaderBookId.Width = 108;
            // 
            // columnHeaderISBN
            // 
            this.columnHeaderISBN.Text = "ISBN";
            this.columnHeaderISBN.Width = 141;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 116;
            // 
            // columnHeaderUnitPrice
            // 
            this.columnHeaderUnitPrice.Text = "UnitPrice";
            this.columnHeaderUnitPrice.Width = 135;
            // 
            // columnHeaderQOH
            // 
            this.columnHeaderQOH.Text = "QOH";
            this.columnHeaderQOH.Width = 212;
            // 
            // columnHeaderCategoryId
            // 
            this.columnHeaderCategoryId.Text = "CategoryId";
            this.columnHeaderCategoryId.Width = 174;
            // 
            // columnHeaderPublisherId
            // 
            this.columnHeaderPublisherId.Text = "PublisherId";
            this.columnHeaderPublisherId.Width = 271;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBookId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxIsbn);
            this.groupBox1.Controls.Add(this.textBoxUnitPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxQOH);
            this.groupBox1.Controls.Add(this.textBoxPublisherIdBook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCategoryIdBook);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(76, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1582, 169);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "UnitPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "BookId";
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.BackColor = System.Drawing.Color.Thistle;
            this.textBoxBookId.Location = new System.Drawing.Point(16, 90);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(143, 26);
            this.textBoxBookId.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Thistle;
            this.textBoxTitle.Location = new System.Drawing.Point(496, 90);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(143, 26);
            this.textBoxTitle.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "ISBN";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.BackColor = System.Drawing.Color.Thistle;
            this.textBoxIsbn.Location = new System.Drawing.Point(256, 90);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(143, 26);
            this.textBoxIsbn.TabIndex = 31;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.BackColor = System.Drawing.Color.Thistle;
            this.textBoxUnitPrice.Location = new System.Drawing.Point(732, 90);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(143, 26);
            this.textBoxUnitPrice.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(966, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "QOH";
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.BackColor = System.Drawing.Color.Thistle;
            this.textBoxQOH.Location = new System.Drawing.Point(970, 90);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(143, 26);
            this.textBoxQOH.TabIndex = 35;
            // 
            // textBoxPublisherIdBook
            // 
            this.textBoxPublisherIdBook.BackColor = System.Drawing.Color.Thistle;
            this.textBoxPublisherIdBook.Location = new System.Drawing.Point(1428, 90);
            this.textBoxPublisherIdBook.Name = "textBoxPublisherIdBook";
            this.textBoxPublisherIdBook.Size = new System.Drawing.Size(143, 26);
            this.textBoxPublisherIdBook.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1197, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "CategoryId";
            // 
            // textBoxCategoryIdBook
            // 
            this.textBoxCategoryIdBook.BackColor = System.Drawing.Color.Thistle;
            this.textBoxCategoryIdBook.Location = new System.Drawing.Point(1201, 90);
            this.textBoxCategoryIdBook.Name = "textBoxCategoryIdBook";
            this.textBoxCategoryIdBook.Size = new System.Drawing.Size(143, 26);
            this.textBoxCategoryIdBook.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1424, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "PublisherId";
            // 
            // buttonClearBook
            // 
            this.buttonClearBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonClearBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearBook.Location = new System.Drawing.Point(1364, 318);
            this.buttonClearBook.Name = "buttonClearBook";
            this.buttonClearBook.Size = new System.Drawing.Size(176, 53);
            this.buttonClearBook.TabIndex = 58;
            this.buttonClearBook.Text = "Clear Text";
            this.buttonClearBook.UseVisualStyleBackColor = false;
            this.buttonClearBook.Click += new System.EventHandler(this.buttonClearBook_Click_1);
            // 
            // buttonExitBook
            // 
            this.buttonExitBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonExitBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitBook.Location = new System.Drawing.Point(1529, 587);
            this.buttonExitBook.Name = "buttonExitBook";
            this.buttonExitBook.Size = new System.Drawing.Size(129, 47);
            this.buttonExitBook.TabIndex = 56;
            this.buttonExitBook.Text = "Exit";
            this.buttonExitBook.UseVisualStyleBackColor = false;
            this.buttonExitBook.Click += new System.EventHandler(this.buttonExitBook_Click_1);
            // 
            // buttonListBook
            // 
            this.buttonListBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonListBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListBook.Location = new System.Drawing.Point(1130, 318);
            this.buttonListBook.Name = "buttonListBook";
            this.buttonListBook.Size = new System.Drawing.Size(176, 53);
            this.buttonListBook.TabIndex = 55;
            this.buttonListBook.Text = "List All";
            this.buttonListBook.UseVisualStyleBackColor = false;
            this.buttonListBook.Click += new System.EventHandler(this.buttonListBook_Click_1);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchBook.Location = new System.Drawing.Point(896, 321);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(176, 53);
            this.buttonSearchBook.TabIndex = 54;
            this.buttonSearchBook.Text = "Search";
            this.buttonSearchBook.UseVisualStyleBackColor = false;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click_1);
            // 
            // buttonModifyBook
            // 
            this.buttonModifyBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonModifyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyBook.Location = new System.Drawing.Point(662, 321);
            this.buttonModifyBook.Name = "buttonModifyBook";
            this.buttonModifyBook.Size = new System.Drawing.Size(176, 53);
            this.buttonModifyBook.TabIndex = 53;
            this.buttonModifyBook.Text = "Modify";
            this.buttonModifyBook.UseVisualStyleBackColor = false;
            this.buttonModifyBook.Click += new System.EventHandler(this.buttonModifyBook_Click_1);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveBook.Location = new System.Drawing.Point(428, 321);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(176, 53);
            this.buttonRemoveBook.TabIndex = 52;
            this.buttonRemoveBook.Text = "Remove";
            this.buttonRemoveBook.UseVisualStyleBackColor = false;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click_1);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.Lavender;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(194, 321);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(176, 53);
            this.buttonAddBook.TabIndex = 51;
            this.buttonAddBook.Text = "Add";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(709, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 37);
            this.label2.TabIndex = 50;
            this.label2.Text = "Books Management";
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1735, 701);
            this.Controls.Add(this.listViewShowBook);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearBook);
            this.Controls.Add(this.buttonExitBook);
            this.Controls.Add(this.buttonListBook);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.buttonModifyBook);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewShowBook;
        private System.Windows.Forms.ColumnHeader columnHeaderBookId;
        private System.Windows.Forms.ColumnHeader columnHeaderISBN;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderQOH;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoryId;
        private System.Windows.Forms.ColumnHeader columnHeaderPublisherId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.TextBox textBoxPublisherIdBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCategoryIdBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClearBook;
        private System.Windows.Forms.Button buttonExitBook;
        private System.Windows.Forms.Button buttonListBook;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonModifyBook;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label2;
    }
}