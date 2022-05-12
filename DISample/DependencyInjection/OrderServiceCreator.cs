using DAL;

namespace DISample.DependencyInjection
{
    internal class OrderServiceCreator
    {
        public API.Order Create()
        {
            var orderDal = new OrderDAL();
            var orderBlFactory = new OrderBLFactory(orderDal);
            return new API.Order(orderBlFactory);
        }
    }
}
