using FinalProject_HiTech.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject_HiTech.DAL
{
    public class UserDB
    {
        public static void AddRecord(User user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO USERACCOUNTS (UserId,Password,DateCreated,StatusId) " +
                                    "VALUES(@UserId,@Password,@DateCreated,@StatusId)";
            cmdInsert.Parameters.AddWithValue("@UserId", user.UserId);
            cmdInsert.Parameters.AddWithValue("@Password", user.Password);
            cmdInsert.Parameters.AddWithValue("@DateCreated", user.DateCreated);
            cmdInsert.Parameters.AddWithValue("@StatusId", user.StatusId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static List<User> GetListRecords()
        {
            List<User> listU = new List<User>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("Select * From UserAccounts", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            User u;
            while (reader.Read())
            {

                u = new User();
                u.UserId = Convert.ToInt32(reader["UserId"]);
                u.Password = reader["Password"].ToString();
                u.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                u.StatusId = Convert.ToInt32(reader["StatusId"]);
                listU.Add(u);
            }
            conn.Close();

            return listU;
        }

        public static User SearchRecord(int uId)
        {
            User u = new User();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "Select * from UserAccounts " +
                                       "Where UserId=@UserId";
            cmdSearchById.Parameters.AddWithValue("@UserId", uId);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read())
            {
                u.UserId = Convert.ToInt32(reader["UserId"]);
                u.Password = reader["Password"].ToString().Trim();
                u.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                u.StatusId = Convert.ToInt32(reader["StatusId"]);
            }
            else
            {
                u = null;
            }
            conn.Close();
            return u;
        }
        public static void DeleteRecord(int uId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "DELETE UserAccounts " +
                                     "WHERE UserId=@UserId";
            cmdInsert.Parameters.AddWithValue("@UserId", uId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();

        }
        public static void UpdateRecord(User userUpdated)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE UserAccounts " +
                                    "    set Password=@Password" +
                                    " WHERE UserId=@UserId";
            cmdInsert.Parameters.AddWithValue("@UserId", userUpdated.UserId);
            cmdInsert.Parameters.AddWithValue("@Password", userUpdated.Password);
            cmdInsert.Parameters.AddWithValue("@DateCreated", userUpdated.DateCreated);
            cmdInsert.Parameters.AddWithValue("@StatusId", userUpdated.StatusId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static bool IsUniqueUId(int uId)
        {
            User u = SearchRecord(uId);
            if (u != null)
            {
                return false;
            }
            return true;
        }

    }
}
