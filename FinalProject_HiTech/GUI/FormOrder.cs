using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_HiTech.BLL;
using FinalProject_HiTech.DAL;
using FinalProject_HiTech.VALIDATION;

namespace FinalProject_HiTech.GUI
{
    public partial class FormOrder : Form
    {
        private readonly OrderController orderController;
        private int lastOrderId = 11111111;

        public FormOrder()
        {
            InitializeComponent();
            orderController = new OrderController();
        }

        private void buttonAddOrd_Click(object sender, EventArgs e)
        {

            lastOrderId++;

            // Rest of your code...
            // Use lastOrderId as the ID for the new order


            string input = textBoxCustomerIdOrd.Text.Trim();
            if (!Validator.IsValidCustomerId(input, 7))
            {
                MessageBox.Show("Customer ID must be 7 digit numbers", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerIdOrd.Clear();
                textBoxCustomerIdOrd.Focus();
                return;
            }
            input = textBoxEmployeeIdOrd.Text.Trim();
            if (!Validator.IsValidEmployeeId(input, 4))
            {
                MessageBox.Show("Employee ID must be 4 digit numbers", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeIdOrd.Clear();
                textBoxEmployeeIdOrd.Focus();
                return;
            }

            DateTime orderDate = DateTime.Parse(dateTimePickerOrder.Text);
            DateTime deliveryDate = DateTime.Parse(dateTimePickerDelivery.Text);

            if (deliveryDate <= orderDate || deliveryDate <= DateTime.Today)
            {
                MessageBox.Show("Delivery date must be in the future and after the order date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validator.IsValidPaymentMethod(comboBoxPaymentMethod.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please choose a valid payment method.", "Invalid Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPaymentMethod.Focus();
                return;
            }
            textBoxCustomerIdOrd.Focus();
            textBoxCustomerIdOrd.TabIndex = 0;
            textBoxEmployeeIdOrd.TabIndex = 1;
            dateTimePickerDelivery.TabIndex = 2;
            dateTimePickerOrder.TabIndex = 3;
            comboBoxPaymentMethod.TabIndex = 4;




            Order order = new Order
            {
                OrderId = lastOrderId,
                CustomerId = int.Parse(textBoxCustomerIdOrd.Text),
                EmployeeId = int.Parse(textBoxEmployeeIdOrd.Text),
                DeliveryDate = DateTime.Parse(dateTimePickerDelivery.Text),
                OrderDate = DateTime.Parse(dateTimePickerOrder.Text),
                PaymentMethod = comboBoxPaymentMethod.Text
            };
            orderController.AddOrder(order);
            MessageBox.Show("Order added successfully.");
        }

        private void buttonRemoveOrd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOrderIdOrder.Text))
            {
                MessageBox.Show("Please enter an order ID before deleting.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOrderIdOrder.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int orderId = int.Parse(textBoxOrderIdOrder.Text);
                    orderController.DeleteOrder(orderId);
                    MessageBox.Show("Order removed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred while deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonModifyOrd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOrderIdOrder.Text))
            {
                MessageBox.Show("Please enter an order ID before updating.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOrderIdOrder.Focus();
                return;
            }
            Order order = new Order
            {
                OrderId = int.Parse(textBoxOrderIdOrder.Text),
                CustomerId = int.Parse(textBoxCustomerIdOrd.Text),
                EmployeeId = int.Parse(textBoxEmployeeIdOrd.Text),
                DeliveryDate = DateTime.Parse(dateTimePickerDelivery.Text),
                OrderDate = DateTime.Parse(dateTimePickerOrder.Text),
                PaymentMethod = comboBoxPaymentMethod.Text
            };
            orderController.UpdateOrder(order);
            MessageBox.Show("Order updated successfully.");
        }

        private void buttonSearchOrd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxOrderIdOrder.Text))
            {
                MessageBox.Show("Please enter an order ID before searching.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOrderIdOrder.Focus();
                return;
            }
            int orderId = int.Parse(textBoxOrderIdOrder.Text);
            Order order = orderController.SearchOrder(orderId);
            if (order != null)
            {
                // Assuming you want to display the details in TextBox controls, replace txtCustomerId, txtEmployeeId, etc. with the actual names of your TextBox controls
                textBoxCustomerIdOrd.Text = order.CustomerId.ToString();
                textBoxEmployeeIdOrd.Text = order.EmployeeId.ToString();
                dateTimePickerDelivery.Text = order.DeliveryDate.ToString();
                dataGridViewOrders.Text = order.OrderDate.ToString();
                comboBoxPaymentMethod.Text = order.PaymentMethod;
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }

        private void buttonListOrd_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.DataSource = orderController.GetOrders();
            dataGridViewOrders.Columns["Customer"].Visible = false;
            dataGridViewOrders.Columns["Employee"].Visible = false;
            dataGridViewOrders.Columns["OrderLines"].Visible = false;
        }

        private void buttonClearOrd_Click(object sender, EventArgs e)
        {
            // Clear text of each textbox
            textBoxOrderIdOrder.Clear();
            textBoxCustomerIdOrd.Clear();
            textBoxEmployeeIdOrd.Clear();



            // Set focus to the first textbox (optional)
            textBoxCustomerIdOrd.Focus();
        }

        private void buttonExitOrd_Click(object sender, EventArgs e)
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

   

