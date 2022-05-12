using Entities;
using System;

namespace DAL.Contracts
{
    public interface IOrderDAL
    {
        Order CreateOrder(Order order);
        Order GetOrder(int id);
    }
}
