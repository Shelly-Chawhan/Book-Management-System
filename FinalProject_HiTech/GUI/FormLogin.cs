using FinalProject_HiTech.BLL;
using FinalProject_HiTech.VALIDATION;
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
    public partial class FormLogin : Form
    {

        private List<User> users;
        public FormLogin()
        {
            InitializeComponent();
            // Initialize list of users (replace this with your database logic)
            users = new List<User>
        {
            new User { UserId = 1111, UserName = "MIS Manager",Password = "Henry1111@", Role = "MIS Manager" },
            new User { UserId = 2222, UserName = "Sales Manager",Password = "Thomas2222@", Role = "Sales Manager" },
            new User { UserId = 3333, UserName = "Inventory Controller",Password = "Peter3333@", Role = "Inventory Controller" },
            new User { UserId = 4444, UserName = "Order Clerk1",Password = "Mary4444@", Role = "Order Clerk1" },
            new User { UserId = 5555, UserName = "Order Clerk2",Password = "Jennifer5555@", Role = "Order Clerk2" },
            new User { UserId = 1001, UserName = "Head Manager",Password = "Head1001@", Role = "Head Manager" }

        };

            // Populate the combo box with usernames
            foreach (User user in users)
            {
                comboBoxUser.Items.Add(user.UserName);
            }
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to close this form?", "Confirmation");
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string selectedUserName = comboBoxUser.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUserName))
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            string input6 = textBoxUserId.Text.Trim();
            if (!Validator.IsValidUserId(input6, 4))
            {
                MessageBox.Show("User ID must be a 4-digit number.");
                return;
            }

            string password = textBoxPassword.Text;
            int userId = Convert.ToInt32(textBoxUserId.Text);

            // Find the user in the list
            User user = users.Find(u => u.UserId == userId && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                // Redirect user based on user type
                switch (user.Role)
                {
                    
                    case "MIS Manager":
                        FormMISManager misManagerForm = new FormMISManager();
                        misManagerForm.Show();
                        break;
                    case "Sales Manager":
                        FormCustomer salesManagerForm = new FormCustomer();
                        salesManagerForm.Show();
                        break;
                    case "Inventory Controller":
                        FormBook inventoryManagerForm = new FormBook();
                        inventoryManagerForm.Show();
                        break;
                    case "Order Clerk1":
                        FormOrder orderClerkForm1 = new FormOrder();
                        orderClerkForm1.Show();
                        break;
                    case "Order Clerk2":
                        FormOrder orderClerkForm2 = new FormOrder();
                        orderClerkForm2.Show();
                        break;
                    case "Head Manager":
                        FormMaintenance headManagerForm = new FormMaintenance();
                        headManagerForm.Show();
                        break;
                    default:
                        MessageBox.Show("Invalid user type.");
                        break;
                }

                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid user ID or password.");
            }
        }
    }
}
