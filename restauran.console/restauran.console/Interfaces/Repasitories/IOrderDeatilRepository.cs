using restauran.console.Interfaces.Common;
using restauran.console.Models;

namespace restauran.console.Interfaces.Repasitories
{
    public interface IOrderDeatilRepository :
        ICreatable<OrderDetail>, IReadable<OrderDetail>,
        IDeleteable<OrderDetail>
    {
    }
}
