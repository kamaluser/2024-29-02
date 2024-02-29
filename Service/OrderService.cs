using Core.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService
    {
        private AppDbContext _context;
        public OrderService()
        {
            _context = new AppDbContext();
        }

        public void InsertOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(int id, Order order)
        {
            var orderToUpdate = _context.Orders.Find(id);
            if (orderToUpdate == null)
            {
                Console.WriteLine("Id Not Found!");
                return;
            }
            orderToUpdate.ProductId = order.ProductId;
            orderToUpdate.Count = order.Count;
        }

        public Order GetOrderById(int id)
        {
            if (_context.Orders.Find(id) != null)
            {
                return _context.Orders.Find(id);
            }
            else
            {
                return null;
            }
        }

        public List<Order> GetOrders()
        {
            var list = _context.Orders.ToList();
            return list;
        }

        public void DeleteOrder(int id)
        {
            var orderToDelete = _context.Orders.Find(id);
            if (orderToDelete == null)
            {
                Console.WriteLine("Order Not Found!");
            }
            else
            {
                _context.Remove(orderToDelete);
                _context.SaveChanges();
            }
        }
    }
}
