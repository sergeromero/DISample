using BL;
using BL.Contracts;
using Common;
using DAL.Contracts;
using System;

namespace DISample.DependencyInjection
{
    public class OrderBLFactory : IOrderBLFactory
    {
        private readonly IOrderDAL orderDAL;

        public OrderBLFactory(IOrderDAL orderDAL)
        {
            this.orderDAL = Argument.NotNull(orderDAL, nameof(orderDAL));
        }

        public IOrderBL Create(OrderType orderType)
        {
            switch (orderType)
            {
                case OrderType.Domestic:
                    return new OrderDomesticBL(this.orderDAL);
                case OrderType.International:
                    return new OrderInternationalBL(this.orderDAL);
                case OrderType.Undefined:
                default:
                    throw new ApplicationException("Invalid Order Type selected");
            }
        }
    }
}
