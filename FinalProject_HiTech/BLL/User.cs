using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_HiTech.DAL;

namespace FinalProject_HiTech.BLL
{
    public class User
    {
        private int userId;
        private string password;
        private DateTime dateCreated;
        private int statusId;
        private string role;
        private string userName;

        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public int StatusId { get => statusId; set => statusId = value; }
        public string Role { get => role; set => role = value; }
        public string UserName { get => userName; set => userName = value; }

        public void AddUser(User u)
        {
            UserDB.AddRecord(u);
        }
        public List<User> GetUserList()
        {
            return UserDB.GetListRecords();
        }

        public User SearchUser(int uId)
        {
            return UserDB.SearchRecord(uId);
        }

        public void DeleteUser(int uId) => UserDB.DeleteRecord(uId);
        public void UpdateUser(User u) => UserDB.UpdateRecord(u);

        public bool IsUserIdUnique(int uId) => UserDB.IsUniqueUId(uId);
    }
}
