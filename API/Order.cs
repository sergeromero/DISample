using BL.Contracts;
using Common;
using System;

namespace API
{
    public class Order
    {
        private readonly IOrderBLFactory orderBLFactory;

        public Order(IOrderBLFactory orderBLFactory)
        {
            this.orderBLFactory = Argument.NotNull(orderBLFactory, nameof(orderBLFactory));
        }

        public DTO.Order Get(int id)
        {
            return new DTO.Order();
        }

        public DTO.Order Post(DTO.Order order)
        {
            var entity = new Entities.Order
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId,
                OrderType = order.OrderType
            };

            var orderBL = this.orderBLFactory.Create(order.OrderType);
            var newOrder = orderBL.CreateOrder(entity);

            var result = new DTO.Order
            {
                OrderId = newOrder.OrderId,
                CustomerId = newOrder.CustomerId,
                OrderType = newOrder.OrderType
            };

            return result;
        }
    }
}
