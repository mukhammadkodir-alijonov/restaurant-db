using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Interfaces.Common
{
    public interface ICreatable<T>
    {
        Task<bool> CreateAsync(T obj);
    }
}
