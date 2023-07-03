using restauran.console.Interfaces.Common;
using restauran.console.Models;

namespace restauran.console.Interfaces.Repasitories
{
    public interface IProductRepasitory :
        ICreatable<Product>, IReadable<Product>,
        IDeleteable<Product>, IUpdateable<Product>,
        ISearchable<Product>
    {

    }
}
