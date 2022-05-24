using BL;
using DAL.Contracts;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderSampleTests.BL
{
    public class OrderDomesticBLTests
    {
        protected OrderDomesticBL sut;
        protected Mock<IOrderDAL> dal;

        public OrderDomesticBLTests()
        {
            dal = new Mock<IOrderDAL>();
            sut = new OrderDomesticBL(dal.Object);
        }

        public class CreateOrderTests : OrderDomesticBLTests
        {
            [Fact]
            public void CreatesNewOrderCorrectly()
            {
                Entities.Order order = new Entities.Order {CustomerId = 333 };
                               
                var result = sut.CreateOrder(order);

                dal.Verify(d => d.CreateOrder(It.Is<Entities.Order>(o => o.CustomerId == 333)), Times.Once);
            }

            [Fact]
            public void DoesFunkyStuffToExistingOrder()
            {
                var order = new Entities.Order { CustomerId = 1, OrderId = 10001, OrderType = Common.OrderType.Domestic };

                dal.Setup(d => d.GetOrder(It.IsAny<int>())).Returns(order);
            }
        }
    }
}
