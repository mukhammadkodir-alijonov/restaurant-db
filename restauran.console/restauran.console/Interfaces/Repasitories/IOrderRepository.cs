using restauran.console.Interfaces.Common;
using restauran.console.Models;

namespace restauran.console.Interfaces.Repasitories
{
    public interface IOrderRepository :
        ICreatable<Order>, IReadable<Order>,
        IUpdateable<Order>, IDeleteable<Order>
    {
    }
}
