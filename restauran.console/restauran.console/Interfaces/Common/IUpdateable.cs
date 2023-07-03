using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        Task<bool> UpdateAsync(long id,T obj);
    }
}
