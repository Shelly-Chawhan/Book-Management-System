using FinalProject_HiTech.BLL;
using FinalProject_HiTech.DAL;
using FinalProject_HiTech.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_HiTech.GUI
{
    public partial class FormCustomer : Form
    {
        /// <summary>
        /// customers using disconnecting mode
        /// </summary>

        SqlDataAdapter da;
        DataSet dsHiTechDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlCommandBuilder;
        
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            

            Customer cus = new Customer();
          

            DataRow drCustomer = dtCustomers.NewRow();
          
            drCustomer["Name"] = textBoxCustomerName.Text.Trim();
            drCustomer["Street"] = textBoxCustomerStreet.Text.Trim();
            drCustomer["City"] = textBoxCustomerCity.Text.Trim();
            drCustomer["PostalCode"] = textBoxCustomerPostal.Text.Trim();
            drCustomer["PhoneNumber"] = textBoxCustomerPhone.Text.Trim();
            drCustomer["FaxNumber"] = textBoxCustomerFax.Text.Trim();

           
            string input1 = textBoxCustomerName.Text.Trim();
            if (!Validator.IsValidName(input1))
            {
                MessageBox.Show("Invalid  Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerName.Clear();
                textBoxCustomerName.Focus();
                return;
            }
            input1 = textBoxCustomerStreet.Text.Trim();
            if (!Validator.IsValidName(input1))
            {
                MessageBox.Show("Invalid Street .", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerStreet.Clear();
                textBoxCustomerStreet.Focus();
                return;
            }
            input1 = textBoxCustomerCity.Text.Trim();
            if (!Validator.IsValidName(input1))
            {
                MessageBox.Show("Invalid City.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerCity.Clear();
                textBoxCustomerCity.Focus();
                return;
            }

            string postalCode = textBoxCustomerPostal.Text.Trim();
            if (!Validator.ValidatePostalCode(postalCode))
            {
                MessageBox.Show("Invalid Postal Code! Please enter a valid postal code in the format A1A 1A1.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerPostal.Clear();
                textBoxCustomerPostal.Focus();
                return;
            }
            string input2 = textBoxCustomerPhone.Text.Trim();
            if (!Validator.IsValidPhoneNumber(input2))
            {
                MessageBox.Show("Invalid Phone Number! Please type like it As XXX-XXX-XXXX.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerPhone.Clear();
                textBoxCustomerPhone.Focus();
                return;
            }

            string faxNumber = textBoxCustomerFax.Text.Trim();
            if (!Validator.IsValidFaxNumber(faxNumber))
            {
                MessageBox.Show("Invalid Fax Number! Please type like it As (123) 456-7890.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerFax.Clear();
                textBoxCustomerFax.Focus();
                return;
            }

            int creditLimit;
            if (!int.TryParse(textBoxCustomerCredit.Text.Trim(), out creditLimit))
            {
                MessageBox.Show("Invalid Credit Limit! Please enter a valid integer value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            drCustomer["CreditLimit"] = creditLimit;

            dtCustomers.Rows.Add(drCustomer);
            MessageBox.Show("RowState in the dataTable Customers : " + drCustomer.RowState, "RowState");



        }

        private void buttonSearchCustomer_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID before searching.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerId.Focus();
                return;
            }
            int searchId = Convert.ToInt32(textBoxCustomerId.Text.Trim());

            // Search directly from the DataSet instead of the DataGridView
            DataRow dr = dsHiTechDB.Tables["Customers"].Rows.Find(searchId);
            if (dr != null)
            {
                textBoxCustomerName.Text = dr["Name"].ToString();
                textBoxCustomerStreet.Text = dr["Street"].ToString();
                textBoxCustomerCity.Text = dr["City"].ToString();
                textBoxCustomerPostal.Text = dr["PostalCode"].ToString();
                textBoxCustomerPhone.Text = dr["PhoneNumber"].ToString();
                textBoxCustomerFax.Text = dr["FaxNumber"].ToString();
                textBoxCustomerCredit.Text = dr["CreditLimit"].ToString();
            }
            else
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID");
            }
        }

        private void buttonModifyCustomer_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID before modifying.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerId.Focus();
                return;
            }
            int searchId = Convert.ToInt32(textBoxCustomerId.Text.Trim());

            // Search directly from the DataSet instead of the DataGridView
            DataRow dr = dsHiTechDB.Tables["Customers"].Rows.Find(searchId);
            if (dr != null)
            {
                // Update the DataRow directly
                dr["Name"] = textBoxCustomerName.Text.Trim();
                dr["Street"] = textBoxCustomerStreet.Text.Trim();
                dr["City"] = textBoxCustomerCity.Text.Trim();
                dr["PostalCode"] = textBoxCustomerPostal.Text.Trim();
                dr["PhoneNumber"] = textBoxCustomerPhone.Text.Trim();
                dr["FaxNumber"] = textBoxCustomerFax.Text.Trim();
                dr["CreditLimit"] = textBoxCustomerCredit.Text.Trim();
                MessageBox.Show("The Row State in the dataTable customers: " + dr.RowState, "RowState");
            }
            else
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID");
            }
        }

        private void buttonDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID before deleting.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerId.Focus();
                return;
            }
            int searchId = Convert.ToInt32(textBoxCustomerId.Text.Trim());

            // Search directly from the DataSet instead of the DataGridView
            DataRow dr = dsHiTechDB.Tables["Customers"].Rows.Find(searchId);
            if (dr != null)
            {
                dr.Delete();
                MessageBox.Show("The Row State in the dataTable customers: " + dr.RowState, "RowState");
            }
            else
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID");
            }
        }

        private void buttonUpdateDatabaseCustomer_Click_1(object sender, EventArgs e)
        {
            da.Update(dsHiTechDB, "Customers");
            MessageBox.Show("Database has been updated successfully!", "Database updated");
        }

        private void buttonListCustomerFromDB_Click_1(object sender, EventArgs e)
        {
            // Clear existing data in the DataSet
            dsHiTechDB.Tables["Customers"].Clear();

            // Fill the DataSet with data from the database
            using (SqlConnection connection = UtilityDB.GetDBConnection())
            {
                string query = "SELECT * FROM Customers";
                SqlCommand command = new SqlCommand(query, connection);
                da.SelectCommand = command;
                da.Fill(dsHiTechDB, "Customers");

                dataGridViewFromDB.DataSource = dsHiTechDB.Tables["Customers"];
            }
        }


        private void buttonListCustomerFromDS_Click_1(object sender, EventArgs e)
        {

            da.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            da.Fill(dsHiTechDB, "Customers");
            //dataGridViewFromDS.DataSource = dsHiTechDB.Tables["Customers"];
        }

        private void buttonCloseCustomer_Click_1(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Are you sure you want to close this form?", "Confirmation", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                // Close the current form
                this.Close();

                // Show the login form
                FormLogin loginForm = new FormLogin();
                loginForm.Show();
            }
        }

        private void FormCustomer_Load_1(object sender, EventArgs e)
        {
            dsHiTechDB = new DataSet("HiTechDS");
            dtCustomers = new DataTable("Customers");
            dsHiTechDB.Tables.Add(dtCustomers);
            dtCustomers.Columns.Add("CustomerId", typeof(int));
            dtCustomers.Columns.Add("Name", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("PhoneNumber", typeof(string));
            dtCustomers.Columns.Add("FaxNumber", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(int));
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };
            dtCustomers.Columns["CustomerId"].AutoIncrement = true;
            dtCustomers.Columns["CustomerId"].AutoIncrementSeed = 1111111;
            dtCustomers.Columns["CustomerId"].AutoIncrementStep = 1;
            da = new SqlDataAdapter();
            da.TableMappings.Add("Customers", "Customers");
            sqlCommandBuilder = new SqlCommandBuilder(da);

            //SqlCommand selectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            //da.SelectCommand = selectCommand;




        }

        private void buttonClearCustomer_Click(object sender, EventArgs e)
        {
            // Clear text of each textbox
            textBoxCustomerId.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerStreet.Clear();
            textBoxCustomerCity.Clear();
            textBoxCustomerPhone.Clear();
            textBoxCustomerPostal.Clear();
            textBoxCustomerFax.Clear();
            textBoxCustomerCredit.Clear();

            // Set focus to the first textbox (optional)
            textBoxCustomerName.Focus();
        }
    }
}


