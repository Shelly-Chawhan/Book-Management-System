using FinalProject_HiTech.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_HiTech.DAL
{
    public class BookDB
    {
        public static void AddRecord(Book book)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO BOOKS (BookId,ISBN,Title,UnitPrice,QOH,CategoryId,PublisherId) " +
                                    "VALUES(@BookId,@ISBN,@Title,@UnitPrice,@QOH,@CategoryId,@PublisherId)";
            cmdInsert.Parameters.AddWithValue("@BookId", book.BookId);
            cmdInsert.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmdInsert.Parameters.AddWithValue("@Title", book.Title);
            cmdInsert.Parameters.AddWithValue("@UnitPrice", book.UnitPrice);
            cmdInsert.Parameters.AddWithValue("@QOH", book.QOH);
            cmdInsert.Parameters.AddWithValue("@CategoryId", book.CategoryId);
            cmdInsert.Parameters.AddWithValue("@PublisherId", book.PublisherId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Book> GetListRecords()
        {
            List<Book> listBook = new List<Book>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("Select * From Books", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            Book book;
            while (reader.Read())
            {

                book = new Book();
                book.BookId = Convert.ToInt32(reader["BookId"]);
                book.ISBN = reader["ISBN"].ToString();
                book.Title = reader["Title"].ToString();
                book.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                book.QOH = Convert.ToInt32(reader["QOH"]);
                book.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                book.PublisherId = Convert.ToInt32(reader["PublisherId"]);
                listBook.Add(book);
            }
            conn.Close();

            return listBook;
        }

        public static Book SearchRecord(int bookId)
        {
            Book book = new Book();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "Select * from Books " +
                                       "Where BookId=@BookId";
            cmdSearchById.Parameters.AddWithValue("@BookId", bookId);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read())
            {
                book.BookId = Convert.ToInt32(reader["BookId"]);
                book.ISBN= reader["ISBN"].ToString().Trim();
                book.Title = reader["Title"].ToString().Trim();
                book.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                book.QOH = Convert.ToInt32(reader["QOH"]);
                book.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                book.PublisherId = Convert.ToInt32(reader["PublisherId"]);
            }
            else
            {
                book = null;
            }
            conn.Close();
            return book;
        }
        public static void DeleteRecord(int bookId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "DELETE Books " +
                                     "WHERE BookId=@BookId";
            cmdInsert.Parameters.AddWithValue("@BookId", bookId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();

        }
        public static void UpdateRecord(Book bookUpdated)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE Books " +
                                    "    set ISBN=@ISBN," +
                                    "        Title=@Title," +
                                    "        UnitPrice=@UnitPrice," +
                                    "        QOH=@QOH," +
                                    "        CategoryId=@CategoryId," +
                                    "        PublisherId=@PublisherId" +
                                    " WHERE BookId=@BookId";
            cmdInsert.Parameters.AddWithValue("@BookId", bookUpdated.BookId);
            cmdInsert.Parameters.AddWithValue("@ISBN", bookUpdated.ISBN);
            cmdInsert.Parameters.AddWithValue("@Title", bookUpdated.Title);
            cmdInsert.Parameters.AddWithValue("@UnitPrice", bookUpdated.UnitPrice);
            cmdInsert.Parameters.AddWithValue("@QOH", bookUpdated.QOH);
            cmdInsert.Parameters.AddWithValue("@CategoryId", bookUpdated.CategoryId);
            cmdInsert.Parameters.AddWithValue("@PublisherId", bookUpdated.PublisherId);
            cmdInsert.ExecuteNonQuery();

            conn.Close();
        }
        public static bool IsUniqueBookId(int bookId)
        {
            Book book = SearchRecord(bookId);
            if (book != null)
            {
                return false;
            }
            return true;
        }



    }
}

