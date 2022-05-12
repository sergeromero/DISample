using BL.Contracts;
using Common;
using DAL.Contracts;
using Entities;
using System;

namespace BL
{
    public class OrderDomesticBL : IOrderBL
    {
        private readonly IOrderDAL orderDAL;

        public OrderDomesticBL(IOrderDAL orderDAL)
        {
            this.orderDAL = Argument.NotNull(orderDAL, nameof(orderDAL));
        }

        public Order CreateOrder(Order order)
        {
            Console.WriteLine("Creating a DOMESTIC Order in the OrderDomesticBL class");
            return this.orderDAL.CreateOrder(order);
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
