using Common;
using System;

namespace DTO
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public OrderType OrderType { get; set; }
    }
}
