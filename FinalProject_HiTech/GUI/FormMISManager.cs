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
    public partial class FormMISManager : Form
    {
        public FormMISManager()
        {
            InitializeComponent();
            /// <summary>
            /// employee in connected mode
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            // Data validation making employee ID 4 digits number only 
            string input = textBoxEmployeeId.Text.Trim();
            if (!Validator.IsValidEmployeeId(input, 4))
            {
                MessageBox.Show("Employee ID must be 4 digit numbers", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }

            string input1 = textBoxFirstName.Text.Trim();
            if (!Validator.IsValidName(input1))
            {
                MessageBox.Show("Invalid First Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }
            input1 = textBoxLastName.Text.Trim();
            if (!Validator.IsValidName(input1))
            {
                MessageBox.Show("Invalid Last Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            string input2 = textBoxPhoneNumber.Text.Trim();
            if (!Validator.IsValidPhoneNumber(input2))
            {
                MessageBox.Show("Invalid Phone Number! Please type like it As XXX-XXX-XXXX.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhoneNumber.Clear();
                textBoxPhoneNumber.Focus();
                return;
            }
            string input3 = textBoxEmail.Text.Trim();
            if (!Validator.IsValidEmail(input3))
            {
                MessageBox.Show("Invalid Email Address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Clear();
                textBoxEmail.Focus();
                return;
            }
            // Data validation making job ID 1 digits number only 
            string input4 = textBoxJobIdEmp.Text.Trim();
            if (!Validator.IsValidJobId(input4, 1))
            {
                MessageBox.Show("JobId ID must be 1 digit numbers", "Invalid Job ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxJobIdEmp.Clear();
                textBoxJobIdEmp.Focus();
                return;
            }
            // Data validation making status ID 1 digits number only 
            string input5 = textBoxStatusIdEmp.Text.Trim();
            if (!Validator.IsValidStatusId(input5, 1))
            {
                MessageBox.Show("Status ID must be 1 digit numbers", "Invalid status ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStatusIdEmp.Clear();
                textBoxStatusIdEmp.Focus();
                return;
            }

            if (!emp.IsEmployeeIdUnique(Convert.ToInt32(input)))
            {
                MessageBox.Show("Employee id must be unique.\n" + "Please enter another EmployeeId. ", "Duplicate EmployeeId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }

            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            emp.Email = textBoxEmail.Text.Trim();
            emp.JobId = Convert.ToInt32(textBoxJobIdEmp.Text.Trim());
            emp.StatusId = Convert.ToInt32(textBoxStatusIdEmp.Text.Trim());
            emp.AddEmployee(emp);
            MessageBox.Show("Employee Data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExitEmp_Click(object sender, EventArgs e)
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

        private void buttonModifyEmp_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Please enter an Employee ID  and Search it before updating the Info.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Focus();
                return;
            }
            Employee employeeUpdated = new Employee();
            employeeUpdated.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            employeeUpdated.FirstName = textBoxFirstName.Text.Trim();
            employeeUpdated.LastName = textBoxLastName.Text.Trim();
            employeeUpdated.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            employeeUpdated.Email = textBoxEmail.Text.Trim();
            employeeUpdated.JobId = Convert.ToInt32(textBoxJobIdEmp.Text.Trim());
            employeeUpdated.StatusId = Convert.ToInt32(textBoxStatusIdEmp.Text.Trim());
            employeeUpdated.UpdateEmployee(employeeUpdated);
            MessageBox.Show("Employee data has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonListEmp_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            List<Employee> listEmp = employee.GetEmployeeList();

            foreach (Employee emp in listEmp)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.PhoneNumber);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.JobId.ToString());
                item.SubItems.Add(emp.StatusId.ToString());


                listViewShowEmployee.Items.Add(item);
            }
        }

        private void buttonRemoveEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Please enter an Employee ID before deleting.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Focus();
                return;
            }
            Employee empDeleted = new Employee();
            var answer = MessageBox.Show("Do you really want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                empDeleted.DeleteEmployee(Convert.ToInt32(textBoxEmployeeId.Text.Trim()));
                MessageBox.Show("Employee data has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonSearchEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Please enter an Employee ID before searching.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Focus();
                return;
            }

            string input = "";
            Employee emp = new Employee();
            input = textBoxEmployeeId.Text.Trim();
            if (!Validator.IsValidEmployeeId(input, 4))
            {
                MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }
            emp = emp.SearchEmployee(Convert.ToInt32(input));
            if (emp != null)
            {
                textBoxEmployeeId.Text = emp.EmployeeId.ToString();
                textBoxFirstName.Text = emp.FirstName.ToString();
                textBoxLastName.Text = emp.LastName.ToString();
                textBoxPhoneNumber.Text = emp.PhoneNumber.ToString();
                textBoxEmail.Text = emp.Email.ToString();
                textBoxJobIdEmp.Text = emp.JobId.ToString();
                textBoxStatusIdEmp.Text = emp.StatusId.ToString();
            }
            else
            {
                MessageBox.Show("Employee not found!", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }
        }

        private void buttonClearEmp_Click(object sender, EventArgs e)
        {
            // Clear text of each textbox
            textBoxEmployeeId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxJobIdEmp.Clear();
            textBoxStatusIdEmp.Clear();

            // Set focus to the first textbox (optional)
            textBoxEmployeeId.Focus();
        }

        /// <summary>
        /// this is user account using connecting mode
        /// </summary>
        /// 
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            User u = new User();
            string input6 = textBoxUserId.Text.Trim();
            if (!Validator.IsValidUserId(input6, 4))
            {
                MessageBox.Show("User ID must be 4 digit numbers", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            string input7 = textBoxPassword.Text.Trim();
            if (!Validator.IsValidPassword(input7))
            {
                MessageBox.Show("Invalid Password.It should contain a mix of uppercase letters, lowercase letters, numbers, and special characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }
            string input5 = textBoxStatusIdUser.Text.Trim();
            if (!Validator.IsValidStatusId(input5, 1))
            {
                MessageBox.Show("Status ID must be 1 digit numbers", "Invalid status ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStatusIdUser.Clear();
                textBoxStatusIdUser.Focus();
                return;
            }
            if (!u.IsUserIdUnique(Convert.ToInt32(input6)))
            {
                MessageBox.Show("User id must be unique.\n" + "Please enter another UserId. ", "Duplicate UserId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }

            u.UserId = Convert.ToInt32(textBoxUserId.Text.Trim());
            u.Password = textBoxPassword.Text.Trim();
            u.DateCreated = Convert.ToDateTime(dateTimePickerCreationDateUser.Text.Trim());
            u.StatusId = Convert.ToInt32(textBoxStatusIdUser.Text.Trim());
            u.AddUser(u);
            MessageBox.Show("User Data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRemoveUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserId.Text))
            {
                MessageBox.Show("Please enter an User ID before deleting.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Focus();
                return;
            }
            User uDel = new User();
            var answer = MessageBox.Show("Do you really want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                uDel.DeleteUser(Convert.ToInt32(textBoxUserId.Text.Trim()));
                MessageBox.Show("User data has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonModifyUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserId.Text))
            {
                MessageBox.Show("Please enter an User ID  and Search it before updating the Info.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Focus();
                return;
            }
            User UserUp = new User();
            UserUp.UserId = Convert.ToInt32(textBoxUserId.Text.Trim());
            UserUp.Password = textBoxPassword.Text.Trim();
            UserUp.DateCreated = Convert.ToDateTime(dateTimePickerCreationDateUser.Text.Trim());
            UserUp.StatusId = Convert.ToInt32(textBoxStatusIdUser.Text.Trim());
            UserUp.UpdateUser(UserUp);
            MessageBox.Show("User data has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearchUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserId.Text))
            {
                MessageBox.Show("Please enter an User ID before searching.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Focus();
                return;
            }

            string input = "";
            User u = new User();
            input = textBoxUserId.Text.Trim();
            if (!Validator.IsValidUserId(input, 4))
            {
                MessageBox.Show("User Id must be 4-digit number.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            u = u.SearchUser(Convert.ToInt32(input));
            if (u != null)
            {
                textBoxUserId.Text = u.UserId.ToString();
                textBoxPassword.Text = u.Password.ToString();
                dateTimePickerCreationDateUser.Text = u.DateCreated.ToString();
                textBoxStatusIdUser.Text = u.StatusId.ToString();
            }
            else
            {
                MessageBox.Show("User not found!", "Invalid User Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
        }

        private void buttonClearAllUser_Click_1(object sender, EventArgs e)
        {
            // Clear text of each textbox
            textBoxUserId.Clear();
            textBoxPassword.Clear();
            textBoxStatusIdUser.Clear();

            // Set focus to the first textbox (optional)
            textBoxUserId.Focus();
        }

        private void buttonListAllUser_Click_1(object sender, EventArgs e)
        {
            User u = new User();
            List<User> listU = u.GetUserList();

            foreach (User user in listU)
            {
                ListViewItem item = new ListViewItem(user.UserId.ToString());
                item.SubItems.Add(user.Password);
                item.SubItems.Add(user.DateCreated.ToString());
                item.SubItems.Add(user.StatusId.ToString());


                listViewShowUser.Items.Add(item);
            }
        }

        private void buttonExitUser_Click_1(object sender, EventArgs e)
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

        
    }
}


