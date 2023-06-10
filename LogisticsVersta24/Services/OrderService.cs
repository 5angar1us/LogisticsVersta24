using LogisticsVersta24.Extension;
using LogisticsVersta24.Models;
using LogisticsVersta24.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsVersta24.Service
{
    public class OrderService
    {
        public ApplicationDBcontext _DBcontext;

        public OrderService(ApplicationDBcontext dBcontext)
        {
            _DBcontext = dBcontext;
        }

        public void Add(Order order)
        {
            _DBcontext.Orders.Add(order);
            _DBcontext.SaveChanges();
        }

        public Order Get(Guid id)
        {
            var order = _DBcontext.Orders.Find(id);
            if (order == null)
            {
                throw new NotFoundException();
            }
            return order;
        }
        public void Delete(Guid orderId)
        {
            _DBcontext.Orders.Remove(new Order(orderId));
            _DBcontext.SaveChanges();
        }
        public void Delete(Order order)
        {
            _DBcontext.Orders.Remove(order);
            _DBcontext.SaveChanges();
        }
        public IReadOnlyList<Order> GetAll()
        {
            return _DBcontext.Orders.ToList();
        }

    }
    
}
