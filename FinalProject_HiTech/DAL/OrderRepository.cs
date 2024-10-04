using FinalProject_HiTech.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject_HiTech.DAL
{
    public class OrderRepository
    {

        private readonly HiTechDBdbContext dbContext;
        public OrderRepository()
        {
            dbContext = new HiTechDBdbContext();
        }

        //methods to perform CRUD

        public IEnumerable<Order> GetAllStudents()
        {
            return dbContext.Orders.ToList();
        }

        public IEnumerable<Order> GetAllOrders() => dbContext.Orders.ToList();
        //CREATE
        public void AddOrder(Order order)
        {
           

            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public Order SearchOrder(int orderId) => dbContext.Orders.Find(orderId);
       

        public void DeleteOrder(int orderId)
        {
            var order = dbContext.Orders.Find(orderId);
            if (order != null)
            {
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Order not found!");
            }

        }

        public void UpdateOrder(Order order)
        {
            var orderToUpdate = dbContext.Orders.Find(order.OrderId);
            if (orderToUpdate != null)
            {
                orderToUpdate.CustomerId = order.CustomerId;
                orderToUpdate.EmployeeId = order.EmployeeId;
                orderToUpdate.DeliveryDate = order.DeliveryDate;
                orderToUpdate.OrderDate = order.OrderDate;
                orderToUpdate.PaymentMethod = order.PaymentMethod;
                dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Order not found!");
            }
        }

        
    }
}
