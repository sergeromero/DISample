using Entities;
using System;

namespace BL.Contracts
{
    public interface IOrderBL
    {
        Order GetOrder(int id);
        Order CreateOrder(Order order);
    }
}
