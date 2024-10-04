using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_HiTech.DAL;

namespace FinalProject_HiTech.BLL
{
    public class OrderController
    {
        private readonly OrderRepository orderRepository;
        public OrderController()
        {
            orderRepository = new OrderRepository();
        }

        public IEnumerable<Order> GetOrders() => orderRepository.GetAllOrders();
        public void AddOrder(Order order) => orderRepository.AddOrder(order);
        public void UpdateOrder(Order order) => orderRepository.UpdateOrder(order);
        public void DeleteOrder(int orderId) => orderRepository.DeleteOrder(orderId);
        public Order SearchOrder(int orderId) => orderRepository.SearchOrder(orderId);
    }
}
