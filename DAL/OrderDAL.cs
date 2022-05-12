using DAL.Contracts;
using Entities;
using System;

namespace DAL
{
    public class OrderDAL : IOrderDAL
    {
        public Order CreateOrder(Order order)
        {
            Console.WriteLine("An order is created in the Database from the OrderDAL");

            order.OrderId = 999;
            return order;
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
