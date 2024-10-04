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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        /// <summary>
        /// here im doing all the buttons and validation as per connecting mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            
            string input = textBoxBookId.Text.Trim();
            if (!Validator.IsValidBookId(input, 2))
            {
                MessageBox.Show("Book ID must be 2 digit numbers", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Clear();
                textBoxBookId.Focus();
                return;
            }

            string isbn = textBoxIsbn.Text.Trim();
            if (!Validator.IsValidIsbn(isbn))
            {
                MessageBox.Show("Invalid ISBN! Please enter correct format of only 10 digits  ISBN as 0-306-40615-2 .", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIsbn.Clear();
                textBoxIsbn.Focus();
                return;
            }
            string input1 = textBoxTitle.Text.Trim();
            if (!Validator.IsValidName(input1))
            {
                MessageBox.Show("Invalid Title.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitle.Clear();
                textBoxTitle.Focus();
                return;
            }

            string unit = textBoxUnitPrice.Text.Trim();
            if (!Validator.IsValidUnitPrice(unit))
            {
                MessageBox.Show("Invalid Unit Price! Please enter a float value only.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUnitPrice.Clear();
                textBoxUnitPrice.Focus();
                return;
            }
            string qoh = textBoxQOH.Text.Trim();
            if (!Validator.IsValidQoh(qoh))
            {
                MessageBox.Show("Invalid QOH! Please enter a valid quantity on hand..", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQOH.Clear();
                textBoxQOH.Focus();
                return;
            }

            input = textBoxCategoryIdBook.Text.Trim();
            if (!Validator.IsValidCategoryId(input, 3))
            {
                MessageBox.Show("CategoryId ID must be 3 digit numbers", "Invalid Category ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCategoryIdBook.Clear();
                textBoxCategoryIdBook.Focus();
                return;
            }

            input = textBoxPublisherIdBook.Text.Trim();
            if (!Validator.IsValidPublisherId(input, 6))
            {
                MessageBox.Show("Publisher ID must be 6 digit numbers", "Invalid Publisher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublisherIdBook.Clear();
                textBoxPublisherIdBook.Focus();
                return;
            }

            if (!book.IsBookIdUnique(Convert.ToInt32(input)))
            {
                MessageBox.Show("Book id must be unique.\n" + "Please enter another BookId. ", "Duplicate BookId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Clear();
                textBoxBookId.Focus();
                return;
            }

            book.BookId = Convert.ToInt32(textBoxBookId.Text.Trim());
            book.ISBN = textBoxIsbn.Text.Trim();
            book.Title = textBoxTitle.Text.Trim();
            book.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
            book.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
            book.CategoryId = Convert.ToInt32(textBoxCategoryIdBook.Text.Trim());
            book.PublisherId = Convert.ToInt32(textBoxPublisherIdBook.Text.Trim());
            book.AddBook(book);
            MessageBox.Show("Book Details has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonExitBook_Click_1(object sender, EventArgs e)
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

        private void buttonRemoveBook_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBookId.Text))
            {
                MessageBox.Show("Please enter an Book ID before deleting.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Focus();
                return;
            }
            Book bookDeleted = new Book();
            var answer = MessageBox.Show("Do you really want to delete this Book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                bookDeleted.DeleteBook(Convert.ToInt32(textBoxBookId.Text.Trim()));
                MessageBox.Show("Book details has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonModifyBook_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBookId.Text))
            {
                MessageBox.Show("Please enter an Book ID  and Search it before updating the Info.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Focus();
                return;
            }
            Book bookUpdated = new Book();
            bookUpdated.BookId = Convert.ToInt32(textBoxBookId.Text.Trim());
            bookUpdated.ISBN = textBoxIsbn.Text.Trim();
            bookUpdated.Title = textBoxTitle.Text.Trim();
            bookUpdated.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
            bookUpdated.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
            bookUpdated.CategoryId = Convert.ToInt32(textBoxCategoryIdBook.Text.Trim());
            bookUpdated.PublisherId = Convert.ToInt32(textBoxPublisherIdBook.Text.Trim());
            bookUpdated.UpdateBook(bookUpdated);
            MessageBox.Show("Book detailss has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearchBook_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBookId.Text))
            {
                MessageBox.Show("Please enter an Book ID before searching.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Focus();
                return;
            }

            string input = "";
            Book book = new Book();
            input = textBoxBookId.Text.Trim();
            if (!Validator.IsValidBookId(input, 2))
            {
                MessageBox.Show("Book Id must be 2-digit number.", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Clear();
                textBoxBookId.Focus();
                return;
            }
            book = book.SearchBook(Convert.ToInt32(input));
            if (book != null)
            {
                textBoxBookId.Text = book.BookId.ToString();
                textBoxIsbn.Text = book.ISBN.ToString();
                textBoxTitle.Text = book.Title.ToString();
                textBoxUnitPrice.Text = book.UnitPrice.ToString();
                textBoxQOH.Text = book.QOH.ToString();
                textBoxCategoryIdBook.Text = book.CategoryId.ToString();
                textBoxPublisherIdBook.Text = book.PublisherId.ToString();
            }
            else
            {
                MessageBox.Show("Book not found!", "Invalid Book Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookId.Clear();
                textBoxBookId.Focus();
                return;
            }
        }

        private void buttonListBook_Click_1(object sender, EventArgs e)
        {
            Book book = new Book();
            List<Book> listBook = book.GetBookList();

            foreach (Book bk in listBook)
            {
                ListViewItem item = new ListViewItem(bk.BookId.ToString());
                item.SubItems.Add(bk.ISBN);
                item.SubItems.Add(bk.Title);
                item.SubItems.Add(bk.UnitPrice.ToString());
                item.SubItems.Add(bk.QOH.ToString());
                item.SubItems.Add(bk.CategoryId.ToString());
                item.SubItems.Add(bk.PublisherId.ToString());


                listViewShowBook.Items.Add(item);
            }
        }

        private void buttonClearBook_Click_1(object sender, EventArgs e)
        {
            // Clear text of each textbox
            textBoxBookId.Clear();
            textBoxIsbn.Clear();
            textBoxTitle.Clear();
            textBoxUnitPrice.Clear();
            textBoxQOH.Clear();
            textBoxCategoryIdBook.Clear();
            textBoxPublisherIdBook.Clear();

            // Set focus to the first textbox (optional)
            textBoxBookId.Focus();
        }
    }
}
