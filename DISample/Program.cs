using DISample.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new OrderServiceCreator().Create();

            var dto = new DTO.Order
            {
                CustomerId = 230,
                OrderType = Common.OrderType.International
            };

            api.Post(dto);

            Console.WriteLine("**********************************************");

            var dto2 = new DTO.Order
            {
                CustomerId = 101,
                OrderType = Common.OrderType.Domestic
            };

            api.Post(dto2);
        }
    }
}
