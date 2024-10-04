using FinalProject_HiTech.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_HiTech.DAL;

namespace FinalProject_HiTech.DAL
{
    public class EmployeeDB
    {

        public static void AddRecord(Employee employee)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO EMPLOYEES (EmployeeId,FirstName,LastName,PhoneNumber,Email,JobId,StatusId) " +
                                    "VALUES(@EmployeeId,@FirstName,@LastName,@PhoneNumber,@Email,@JobId,@StatusId)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@Email", employee.Email);
            cmdInsert.Parameters.AddWithValue("@JobId", employee.JobId);
            cmdInsert.Parameters.AddWithValue("@StatusId", employee.StatusId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Employee> GetListRecords()
        {
            List<Employee> listEmp = new List<Employee>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("Select * From Employees", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            Employee emp;
            while (reader.Read())
            {

                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.PhoneNumber = reader["PhoneNumber"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.JobId = Convert.ToInt32(reader["JobId"]);
                emp.StatusId = Convert.ToInt32(reader["StatusId"]);
                listEmp.Add(emp);
            }
            conn.Close();

            return listEmp;
        }

        public static Employee SearchRecord(int eID)
        {
            Employee emp = new Employee();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "Select * from employees " +
                                       "Where employeeID=@employeeID";
            cmdSearchById.Parameters.AddWithValue("@EmployeeId", eID);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString().Trim();
                emp.LastName = reader["LastName"].ToString();
                emp.PhoneNumber = reader["PhoneNumber"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.JobId = Convert.ToInt32(reader["JobId"]);
                emp.StatusId = Convert.ToInt32(reader["StatusId"]);
            }
            else
            {
                emp = null;
            }
            conn.Close();
            return emp;
        }
        public static void DeleteRecord(int eId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "DELETE Employees " +
                                     "WHERE EmployeeId=@EmployeeId";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", eId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();

        }
        public static void UpdateRecord(Employee employeeUpdated)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE Employees " +
                                    "    set FirstName=@FirstName," +
                                    "        LastName=@LastName," +
                                    "        PhoneNumber=@PhoneNumber," +
                                    "        Email=@Email" +
                                    " WHERE EmployeeId=@EmployeeId";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", employeeUpdated.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", employeeUpdated.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", employeeUpdated.LastName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", employeeUpdated.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@Email", employeeUpdated.Email);
            cmdInsert.Parameters.AddWithValue("@JobId", employeeUpdated.JobId);
            cmdInsert.Parameters.AddWithValue("@StatusId", employeeUpdated.StatusId);
            cmdInsert.ExecuteNonQuery();

            conn.Close();
        }
        public static bool IsUniqueEmpId(int eId)
        {
            Employee emp = SearchRecord(eId);
            if (emp != null)
            {
                return false;
            }
            return true;
        }



    }
}
