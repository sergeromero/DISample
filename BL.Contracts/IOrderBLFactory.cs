using Common;

namespace BL.Contracts
{
    public interface IOrderBLFactory
    {
        IOrderBL Create(OrderType orderType);
    }
}
