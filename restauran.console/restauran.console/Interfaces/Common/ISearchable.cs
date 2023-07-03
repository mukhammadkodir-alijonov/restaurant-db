using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Interfaces.Common
{
    public interface ISearchable<T>
    {
        Task<IList<T>> GetAllWhereAsync(Func<T, bool> predicate);
    }
}
