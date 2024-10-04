using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_HiTech.BLL; 

namespace FinalProject_HiTech.DAL
{
    public class CustomerDB
    {
        public static List<Customer> GetAllRecords()
        {
            List<Customer> listC = new List<Customer>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Customers", conn);
            SqlDataReader dr = cmdSelectAll.ExecuteReader();
            Customer customer;
            while (dr.Read())
            {
                customer = new Customer();
                customer.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                customer.Name = dr["Name"].ToString();
                customer.Street = dr["Street"].ToString();
                customer.City = dr["City"].ToString();
                customer.PostalCode = dr["PostalCode"].ToString();
                customer.PhoneNumber = dr["PhoneNumber"].ToString();
                customer.FaxNumber = dr["FaxNumber"].ToString();
                customer.CreditLimit = Convert.ToInt32(dr["CreditLimit"]);
                listC.Add(customer);
            }
            conn.Close();
            return listC;
        }
    }
}
