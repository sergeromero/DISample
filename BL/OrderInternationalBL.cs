using BL.Contracts;
using Common;
using DAL.Contracts;
using Entities;
using System;

namespace BL
{
    public class OrderInternationalBL : IOrderBL
    {
        private readonly IOrderDAL orderDAL;

        public OrderInternationalBL(IOrderDAL orderDAL)
        {
            this.orderDAL = Argument.NotNull(orderDAL, nameof(orderDAL));
        }

        public Order CreateOrder(Order order)
        {
            Console.WriteLine("Creating an INTERNATIONAL Order in the OrderInternationalBL class");
            return this.orderDAL.CreateOrder(order);
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
