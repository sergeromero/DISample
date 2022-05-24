using BL;
using DAL;
using DAL.Contracts;
using DISample.DependencyInjection;
using Moq;
using System;
using Xunit;

namespace OrderSampleTests.DependencyInjection
{
    public class OrderBLFactoryTests
    {
        private OrderBLFactory sut;

        public OrderBLFactoryTests()
        {
            var dal = new Mock<IOrderDAL>();
            sut = new OrderBLFactory(dal.Object);
        }

        [Theory]
        [InlineData(Common.OrderType.Domestic, typeof(OrderDomesticBL))]
        [InlineData(Common.OrderType.International, typeof(OrderInternationalBL))]
        public void CreatesDomesticOrderClass(Common.OrderType orderType, Type expected)
        {
            var actual = sut.Create(orderType);

            Assert.Equal(actual.GetType().FullName, expected.FullName);
        }

        [Fact]
        public void CreatesInternationalOrderClass()
        {
            Assert.Throws<ApplicationException>(() => sut.Create(Common.OrderType.Undefined));
        }
    }
}
