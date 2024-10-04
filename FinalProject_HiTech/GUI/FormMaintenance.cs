using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_HiTech.GUI
{
    public partial class FormMaintenance : Form
    {
        public FormMaintenance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// using menustrip to make navigation bar for all the forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the employee form
            FormMISManager formMIS = new FormMISManager();
            formMIS.ShowDialog();

            // Close the current form after showing the employee form
            this.Close();
        }

        private void userAccounToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the employee form
            FormMISManager formMIS = new FormMISManager();
            formMIS.ShowDialog();

            // Close the current form after showing the employee form
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

            // Show the employee form
            FormCustomer formCUS = new FormCustomer();
            formCUS.ShowDialog();

            // Close the current form after showing the employee form
            this.Close();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the employee form
            FormBook formBk = new FormBook();
            formBk.ShowDialog();

            // Close the current form after showing the employee form
            this.Close();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the employee form
            FormOrder orderForm = new FormOrder();
            orderForm.ShowDialog();


            // Close the current form after showing the employee form
            this.Close();
        }

           

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to close this form?", "Confirmation", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();

                // Show the login form
                FormLogin loginForm = new FormLogin();
                loginForm.ShowDialog();

                // Close the current form after showing the login form
                this.Close();
            }
        }

        
    }
}
